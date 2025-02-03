using System;
#region MyRegion

public class Book
{
    // Properties
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }

    // Constructor
    public Book(string ISBN, string Title, string[] Authors, DateTime PublicationDate, decimal _Price)
    {
        this.ISBN = ISBN;
        this.Title = Title;
        this.Authors = Authors;
        this.PublicationDate = PublicationDate;
        this.Price = _Price;
    }

    // ToString override
    public override string ToString()
    {
        return $"Title: {Title}, ISBN: {ISBN}, Authors: {string.Join(", ", Authors)}, " +
               $"Publication Date: {PublicationDate.ToString("d")}, Price: {Price:C}";
    }

    // Delegate Definitions

    // a. User Defined Delegate Datatype
    public delegate string BookInfoDelegate(Book book);

    // b. BCL Delegate
    public delegate bool ComparisonDelegate(Book book1, Book book2);

    // c. Anonymous Method (GetISBN)
    public void GetISBN()
    {
        // Anonymous method to print the ISBN of the book
        Action printISBN = delegate
        {
            Console.WriteLine("ISBN: " + this.ISBN);
        };

        printISBN.Invoke();
    }

    // d. Lambda Expression (GetPublicationDate)
    public void GetPublicationDate()
    {
        // Lambda expression to print the publication date of the book
        Action printPublicationDate = () => Console.WriteLine("Publication Date: " + this.PublicationDate.ToString("d"));

        printPublicationDate.Invoke();
    }

    // Usage of delegate methods

    public static void UseDelegateExamples()
    {
        // Create a sample book object
        var book = new Book("123456789", "C# Programming", new string[] { "Author A", "Author B" }, DateTime.Now, 29.99m);

        // a. Using User Defined Delegate
        BookInfoDelegate bookInfo = b => $"Title: {b.Title}, ISBN: {b.ISBN}, Price: {b.Price:C}";
        Console.WriteLine(bookInfo(book));

        // b. Using BCL Delegate (ComparisonDelegate)
        ComparisonDelegate compareBooks = (b1, b2) => b1.Price < b2.Price; // Compares by price
        var book2 = new Book("987654321", "Java Programming", new string[] { "Author X" }, DateTime.Now, 19.99m);
        Console.WriteLine("Is book1 cheaper than book2? " + compareBooks(book, book2));

        // c. Using Anonymous Method (GetISBN)
        book.GetISBN();

        // d. Using Lambda Expression (GetPublicationDate)
        book.GetPublicationDate();
    }
}

class Program
{
    static void Main()
    {
        Book.UseDelegateExamples();
    }
}





#endregion