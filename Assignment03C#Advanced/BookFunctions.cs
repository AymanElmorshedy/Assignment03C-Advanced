using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03C_Advanced
{
    internal static class BookFunctions
    {
        public static string GetTitle(Book book) =>book.Title;

        public static string[] GetAuthors(Book book)=>book.Authors;

        public static string GetPrice(Book book)=>book.Price.ToString();
    }
}
