using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03C_Advanced
{
    
    internal class Book
    {

        
        
        public string ISPN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        

        
        public Book(string iSPN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISPN = iSPN;
            Title = title;
            Authors = authors;
            this.PublicationDate = publicationDate;
            Price = price;
        }
        

        public override string ToString() => $"ISBN:{ISPN}, Title:{Title}, Authors:{Authors}, DataTimePublicationDate:{PublicationDate}, Price:{Price}";

      
        
    }
}
