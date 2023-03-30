namespace Library;

public interface Book
{
    string GetTitle();
    string GetAuthor();
    string GetGenre();
    string GetPublisher();
    DateTime GetPublishedDate();
    bool IsAvailable();
    void BorrowBook();
    void ReturnBook();
}