using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Library
{
    internal class LibraryStaff : Observer
    {
        private string name;

        public LibraryStaff(string name)
        {
            this.name = name;
        }

        public void Update(Book book)
        {
            Console.WriteLine($"Library staff {name} has been notified that the book '{book.GetTitle()}' is now available.");
        }
    }
}
