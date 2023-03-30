namespace Library;

public class Magazine : LibraryBook
{
    private readonly string issueNumber;

    public Magazine(string title, string author, string genre, string publisher, DateTime publishedDate,
        string issueNumber)
        : base(title, author, genre, publisher, publishedDate)
    {
        this.issueNumber = issueNumber;
    }

    public string GetIssueNumber()
    {
        return issueNumber;
    }
}