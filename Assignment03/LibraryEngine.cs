using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    // User-defined delegate
    public delegate string BookFunction(Book B);
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookFunction fPtr) // Using user-defined delegate
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}