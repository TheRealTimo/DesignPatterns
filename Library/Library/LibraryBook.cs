using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class LibraryBook : Book
    {
        private string title;
        private string author;
        private string genre;
        private string publisher;
        private DateTime publishedDate;
        private bool isBorrowed;
        private List<Observer> observers;

        public LibraryBook(string title, string author, string genre, string publisher, DateTime publishedDate)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.publisher = publisher;
            this.publishedDate = publishedDate;
            this.isBorrowed = false;
            this.observers = new List<Observer>(); 
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetGenre()
        {
            return genre;
        }

        public string GetPublisher()
        {
            return publisher;
        }

        public DateTime GetPublishedDate()
        {
            return publishedDate;
        }

        public bool IsAvailable()
        {
            return !isBorrowed;
        }

        public void BorrowBook()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
            }
            else
            {
                Console.WriteLine("This book is already borrowed.");
            }
        }

        public void ReturnBook()
        {
            if (isBorrowed)
            {
                isBorrowed = false;
            }
            else
            {
                Console.WriteLine("This book is not borrowed.");
            }
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
