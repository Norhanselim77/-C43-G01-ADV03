namespace Assignment03
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Considering the Code Below , Write Down the Body of all Listed Methods and Properties , you need to Define fPtr as the following cases: 

            // Creating book objects
            List<Book> books = new List<Book>
            {
                new Book("123-456789", "C# Basics", new[] { "Haneen Elfaioumy" }, new DateTime(2021, 6, 1), 29.99m),
                new Book("789-123456", "Advanced C#", new[] { "Haneen Elfaioumy", "Karma Ahmed" }, new DateTime(2022, 3, 15), 39.99m)
            };

            #region a. User Defined Delegate Datatype 

            // a. Using User-defined Delegate
            Console.WriteLine("Using User-defined Delegate:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            #endregion

            #region b. BCL Delegates 

            // b. Using BCL Delegate (Func<Book, string>)
            Console.WriteLine("\nUsing BCL Delegate (Func<Book, string>):");
            Func<Book, string> getBookTitle = BookFunctions.GetTitle;
            foreach (var book in books)
            {
                Console.WriteLine(getBookTitle(book));
            }

            #endregion

            #region c. Anonymous Method (GetISBN) 

            // c. Using Anonymous Method (GetISBN)
            Console.WriteLine("\nUsing Anonymous Method (GetISBN):");
            BookFunction getISBN = delegate (Book B)
            {
                return B.ISBN;
            };
            LibraryEngine.ProcessBooks(books, getISBN);

            #endregion

            #region d. Lambda Expression (GetPublicationDate) 

            // d. Using Lambda Expression (GetPublicationDate)
            Console.WriteLine("\nUsing Lambda Expression (GetPublicationDate):");
            Func<Book, string> getPublicationDate = B => B.PublicationDate.ToShortDateString();
            foreach (var book in books)
            {
                Console.WriteLine(getPublicationDate(book));
            }


            #endregion

            #endregion
        }
    }
}