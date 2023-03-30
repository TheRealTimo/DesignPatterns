namespace Library;

internal class Program
{
    private static void Main(string[] args)
    {
        var factory = new NovelFactory();

        var book1 = (LibraryBook)factory.CreateBook("Book", "Fernando", "Fiction", "Big S", new DateTime(1925, 4, 10));
        var book2 = (LibraryBook)factory.CreateBook("Patterns", "Gerjan", "Fiction", "JB", new DateTime(1960, 7, 11));
        var book3 = (LibraryBook)factory.CreateBook("Something", "Ro", "Science Fiction", "Flag", new DateTime(1949, 6, 8));

        Observer staff1 = new LibraryStaff("Roy");
        Observer staff2 = new LibraryStaff("John");
        book3.RegisterObserver(staff1);
        book3.RegisterObserver(staff2);

        BookDecorator extendedBook1 = new BorrowingPeriodExtensionDecorator(book1, 7);

        BookDecorator lateFeeBook2 = new LateFeeDecorator(book2, 5.0);

        Borrower borrower1 = new Student("1234", "Rob");
        Borrower borrower2 = new Student("5678", "Niels");
        Borrower borrower = new NullStudent("00000", "No Student");

        if (extendedBook1.IsAvailable())
        {
            extendedBook1.BorrowBook();
            Console.WriteLine(borrower1 + " has borrowed the book: " + extendedBook1.GetTitle());
        }

        if (lateFeeBook2.IsAvailable())
        {
            lateFeeBook2.BorrowBook();
            Console.WriteLine(borrower2 + " has borrowed the book: " + lateFeeBook2.GetTitle());
        }

        if (!extendedBook1.IsAvailable())
        {
            extendedBook1.ReturnBook();
            Console.WriteLine(borrower1 + "has returned the book: " + extendedBook1.GetTitle());
        }

        if (!lateFeeBook2.IsAvailable())
        {
            lateFeeBook2.ReturnBook();
            Console.WriteLine(borrower2 + " has returned the book: " + lateFeeBook2.GetTitle());
        }

        Console.ReadLine();
    }
}