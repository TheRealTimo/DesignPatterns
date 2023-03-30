namespace Library;

public class BorrowingPeriodExtensionDecorator : BookDecorator
{
    private readonly int extentionDays;

    public BorrowingPeriodExtensionDecorator(Book book, int extentionDays) : base(book)
    {
        this.extentionDays = extentionDays;
    }

    public override void BorrowBook()
    {
        base.BorrowBook();
        var newReturnDate = DateTime.Today.AddDays(extentionDays);
        Console.WriteLine("Return date has been extended to " + newReturnDate);
    }
}