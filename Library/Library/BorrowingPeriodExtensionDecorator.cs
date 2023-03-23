using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BorrowingPeriodExtensionDecorator : BookDecorator
    {
        private int extentionDays;
        public BorrowingPeriodExtensionDecorator(Book book, int extentionDays) : base(book)
        {
            this.extentionDays = extentionDays;
        }

        public override void BorrowBook()
        {
            base.BorrowBook();
            DateTime newReturnDate= DateTime.Today.AddDays(extentionDays);
            Console.WriteLine("Return date has been extended to " + newReturnDate);
        }
    }
}
