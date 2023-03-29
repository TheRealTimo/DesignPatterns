using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Library
{
    public class Student : Borrower, Observer
    {
        public Student(string id, string name) : base(id, name) { }

        public void Update(Book book)
        {
            Console.WriteLine($"Student {Name} has been notified that the book '{book.GetTitle()}' is now available.");
        }
    }
}


