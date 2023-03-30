namespace Library;

public class Student : Borrower, Observer
{
    public Student(string id, string name) : base(id, name)
    {
    }

    public override void Update(Book book)
    {
        Console.WriteLine($"Student {Name} has been notified that the book '{book.GetTitle()}' is now available.");
    }
}