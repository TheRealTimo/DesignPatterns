using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal interface BookFactory
    {
        Book CreateBook(string title, string author, string genre, string publisher, DateTime publishedDate);
    }
}
