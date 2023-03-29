using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class NovelFactory
    {
        public Book CreateBook(string title, string author, string genre, string publisher, DateTime publishedDate)
        {
            return new LibraryBook(title, author, genre, publisher, publishedDate);
        }
    }
}
