using Library;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestBookCreation()
    {
        var factory = new NovelFactory();
        var book = factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));

        Assert.AreEqual("Test Book", book.GetTitle());
        Assert.AreEqual("Test Author", book.GetAuthor());
        Assert.AreEqual("Test Genre", book.GetGenre());
        Assert.AreEqual("Test Publisher", book.GetPublisher());
        Assert.AreEqual(new DateTime(2020, 1, 1), book.GetPublishedDate());
    }

    [TestMethod]
    public void TestBorrowingAndReturningBook()
    {
        var factory = new NovelFactory();
        var book = (LibraryBook)factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));

        Assert.IsTrue(book.IsAvailable());
        book.BorrowBook();
        Assert.IsFalse(book.IsAvailable());
        book.ReturnBook();
        Assert.IsTrue(book.IsAvailable());
    }

    [TestMethod]
    public void TestObserverNotification()
    {
        var factory = new NovelFactory();
        var book = (LibraryBook)factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher",new DateTime(2020, 1, 1));
        var staff = new LibraryStaff("Test Staff");

        book.RegisterObserver(staff);
        book.BorrowBook();
        book.ReturnBook(); // Staff should be notified when the book is returned
    }

    [TestMethod]
    public void TestLateFeeDecorator()
    {
        var factory = new NovelFactory();
        var book = factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));
        var lateFeeBook = new LateFeeDecorator(book, 10.0);

        lateFeeBook.ReturnBook(); // Late fee should be displayed
    }

    [TestMethod]
    public void TestBorrowingPeriodExtensionDecorator()
    {
        var factory = new NovelFactory();
        var book = factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));
        var extendedBook = new BorrowingPeriodExtensionDecorator(book, 7);

        extendedBook.BorrowBook(); // Return date should be extended by 7 days
    }

    [TestMethod]
    public void TestMagazineCreation()
    {
        var factory = new MagazineFactory();
        var magazine = factory.CreateBook("Test Magazine", "Test Editor", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1), "Issue 1");

        Assert.AreEqual("Test Magazine", magazine.GetTitle());
        Assert.AreEqual("Test Editor", magazine.GetAuthor());
        Assert.AreEqual("Test Genre", magazine.GetGenre());
        Assert.AreEqual("Test Publisher", magazine.GetPublisher());
        Assert.AreEqual(new DateTime(2020, 1, 1), magazine.GetPublishedDate());

        // Cast the Book to Magazine to access GetIssueNumber()
        var castedMagazine = magazine as Magazine;

        Assert.IsNotNull(castedMagazine);
        Assert.AreEqual("Issue 1", castedMagazine.GetIssueNumber());
    }

    [TestMethod]
    public void TestConcreteStudentBorrowingAndReturningBook()
    {
        var factory = new NovelFactory();
        var book = (LibraryBook)factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));
        var student = new Student("Test Student", "Test Student");

        book.RegisterObserver(student);
        book.BorrowBook(); // ConcreteStudent should be able to borrow the book
        Assert.IsFalse(book.IsAvailable());
        book.ReturnBook();
        Assert.IsTrue(book.IsAvailable());
    }

    [TestMethod]
    public void TestUnregisterObserver()
    {
        var factory = new NovelFactory();
        var book = (LibraryBook)factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));
        var staff = new LibraryStaff("Test Staff");

        book.RegisterObserver(staff);
        book.RemoveObserver(staff);
        book.BorrowBook();
        book.ReturnBook(); // Staff should not be notified since they have been unregistered
    }

    [TestMethod]
    public void TestMultipleObservers()
    {
        var factory = new NovelFactory();
        var book = (LibraryBook)factory.CreateBook("Test Book", "Test Author", "Test Genre", "Test Publisher", new DateTime(2020, 1, 1));
        var staff1 = new LibraryStaff("Test Staff 1");
        var staff2 = new LibraryStaff("Test Staff 2");

        book.RegisterObserver(staff1);
        book.RegisterObserver(staff2);
        book.BorrowBook();
        book.ReturnBook(); // Both staff members should be notified
    }
}