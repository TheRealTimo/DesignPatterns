using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface Book
    {
        string GetTitle();
        string GetAuthor();
        string GetGenre();
        string GetPublisher();
        DateTime GetPublishedDate();
        bool IsAvailable();
        void BorrowBook();
        void ReturnBook();
    }
}
