using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class BookDecorator : Book
    {
        private Book book;

        public BookDecorator(Book book)
        {
            this.book = book;
        }
        public string GetTitle()
        {
            return book.GetTitle();
        }

        public string GetAuthor()
        {
            return book.GetAuthor();
        }

        public string GetGenre()
        {
            return book.GetGenre();
        }

        public string GetPublisher()
        {
            return book.GetPublisher();
        }

        public DateTime GetPublishedDate()
        {
            return book.GetPublishedDate();
        }

        public bool IsAvailable()
        {
            return book.IsAvailable();
        }

        public virtual void BorrowBook()
        {
            book.BorrowBook();
        }

        public virtual void ReturnBook()
        {
            book.ReturnBook();
        }
    }
}
