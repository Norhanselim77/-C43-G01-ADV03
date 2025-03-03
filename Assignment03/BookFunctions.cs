using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B?.Title;
        }

        public static string GetAuthors(Book B)
        {
            return B?.Authors != null ? string.Join(", ", B.Authors) : null;
        }

        public static string GetPrice(Book B)
        {
            return B?.Price.ToString("C");
        }

    }
}