using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal abstract class Borrower
    {
        private string _name;
        private string _id;

        public Borrower(string id, string name) {
            this._name = name;
            this._id = id;
        }

        public string Name { get { return _name; } }
        public string Id { get { return _id;} }


    }
}
