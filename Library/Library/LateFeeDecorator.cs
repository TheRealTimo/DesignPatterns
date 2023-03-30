namespace Library;

public class LateFeeDecorator : BookDecorator
{
    public double lateFee;

    public LateFeeDecorator(Book book, double lateFee) : base(book)
    {
        this.lateFee = lateFee;
    }

    public override void ReturnBook()
    {
        base.ReturnBook();
        Console.WriteLine("Late fee charge:" + lateFee);
    }
}