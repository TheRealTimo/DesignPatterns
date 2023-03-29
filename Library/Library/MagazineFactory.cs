using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MagazineFactory
    {
        public Book CreateBook(string title, string author, string genre, string publisher, DateTime publishedDate, string issueNumber)
        {
            return new Magazine(title, author, genre, publisher, publishedDate, issueNumber);
        }
    }
}
