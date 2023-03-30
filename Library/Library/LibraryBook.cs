namespace Library;

public class LibraryBook : Book
{
    private readonly string author;
    private readonly string genre;
    private bool isBorrowed;
    private List<Observer> observers;
    private readonly DateTime publishedDate;
    private readonly string publisher;
    private readonly string title;

    public LibraryBook(string title, string author, string genre, string publisher, DateTime publishedDate)
    {
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.publisher = publisher;
        this.publishedDate = publishedDate;
        isBorrowed = false;
        observers = new List<Observer>();
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
            isBorrowed = true;
        else
            Console.WriteLine("This book is already borrowed.");
    }

    public void ReturnBook()
    {
        if (isBorrowed)
        {
            isBorrowed = false;
            NotifyObservers();
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
        foreach (var observer in observers) observer.Update(this);
    }
}