namespace Library;

public class MagazineFactory
{
    public Book CreateBook(string title, string author, string genre, string publisher, DateTime publishedDate,
        string issueNumber)
    {
        return new Magazine(title, author, genre, publisher, publishedDate, issueNumber);
    }
}