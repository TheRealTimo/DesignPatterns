using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LateFeeDecorator : BookDecorator
    {
        private double lateFee;
        public LateFeeDecorator(Book book, double lateFee) : base(book)
        {
            this.lateFee = lateFee;
        }

        public override void ReturnBook()
        {
            base.ReturnBook();
            Console.WriteLine("Late fee charge:" + lateFee);
        }
    }
}
