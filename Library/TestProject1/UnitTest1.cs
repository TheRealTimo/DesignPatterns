using System;
using static System.Net.Mime.MediaTypeNames;
using Library;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BookCanBeCreated()
        {
            NovelFactory novelFactory = new NovelFactory();
            Book book = novelFactory.CreateBook("Trouble's Just Begun", "Roy", "Thriller", "Kluitman", new DateTime());

            Assert.IsInstanceOfType(book, typeof(Book));
        }

        [TestMethod]
        public void BookCanBeBorrowed()
        {
            NovelFactory novelFactory = new NovelFactory();
            Book book = novelFactory.CreateBook("Trouble's Just Begun", "Roy", "Thriller", "Kluitman", new DateTime());

            book.BorrowBook();

            Assert.IsFalse(book.IsAvailable());
        }

        [TestMethod]
        public void BorrowedBookCanBeReturned()
        {
            NovelFactory novelFactory = new NovelFactory();
            Book book = novelFactory.CreateBook("Trouble's Just Begun", "Roy", "Thriller", "Kluitman", new DateTime());

            book.BorrowBook();
            book.ReturnBook();

            Assert.IsTrue(book.IsAvailable());
        }
    }
}