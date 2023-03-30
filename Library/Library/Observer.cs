namespace Library;

public interface Observer
{
    string Name { get; }
    void Update(Book book);
}