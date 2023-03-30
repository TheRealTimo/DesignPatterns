namespace Library;

public interface BookFactory
{
    Book CreateBook(string title, string author, string genre, string publisher, DateTime publishedDate);
}