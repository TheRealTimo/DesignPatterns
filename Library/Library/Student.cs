using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Student : Borrower
    {
        public Student(string id, string name) : base(id, name) {
        }

        public void Update() { }
    }
}
