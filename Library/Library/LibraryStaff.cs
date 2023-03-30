namespace Library;

public class LibraryStaff : Observer
{
    public LibraryStaff(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Update(Book book)
    {
        Console.WriteLine(
            $"Library staff {Name} has been notified that the book '{book.GetTitle()}' is now available.");
    }
}