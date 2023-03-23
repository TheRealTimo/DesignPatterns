using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Library
{
    internal class Student : Borrower, Observer
    {
        private string id;
        private string name;

        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Update(Book book)
        {
            Console.WriteLine($"Student {name} has been notified that the book '{book.GetTitle()}' is now available.");
        }

        public override  string GetBorrowerId()
        {
            return id;
        }

        public override  string GetBorrowerName()
        {
            return name;
        }
    }
}

