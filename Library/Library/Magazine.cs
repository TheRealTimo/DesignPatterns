using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Magazine : LibraryBook
    {
        private string issueNumber;

        public Magazine(string title, string author, string genre, string publisher, DateTime publishedDate, string issueNumber)
            : base(title, author, genre, publisher, publishedDate)
        {
            this.issueNumber = issueNumber;
        }

        public string GetIssueNumber()
        {
            return issueNumber;
        }
    }
}
