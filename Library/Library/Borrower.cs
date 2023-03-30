namespace Library;

public abstract class Borrower : Observer
{
    public Borrower(string id, string name)
    {
        Name = name;
        Id = id;
    }

    public string Id { get; }

    public string Name { get; }

    public abstract void Update(Book book);
}