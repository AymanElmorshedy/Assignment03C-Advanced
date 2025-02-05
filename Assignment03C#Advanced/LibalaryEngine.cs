using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03C_Advanced
{
    internal static class LibalaryEngine
    {
        public static void ProcessBooks(List<Book> books, Func<Book, string> Selector)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(Selector(book));
            }
        }
    }
}
