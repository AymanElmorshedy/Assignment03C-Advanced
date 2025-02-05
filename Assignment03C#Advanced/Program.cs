namespace Assignment03C_Advanced
{
    internal delegate string BookDelegate(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>()
            {
                new Book("123","C#Basics",new string[]{"Ali","Amr"},new DateTime(2020,5,16),150),
                new Book("567","AI benefits",new string[]{"john","sam"},new DateTime(2022,2,16),200),

            };

            #region User defined delegate

            LibalaryEngine.ProcessBooks(list, BookFunctions.GetTitle);
            #endregion

            #region Useing Built in delegate
            //LibalaryEngine.ProcessBooks(list, BookFunctions.GetPrice);
            #endregion

            #region Annomus method
            //LibalaryEngine.ProcessBooks(list,delegate(Book book) {return book.ISPN; });
            #endregion
            #region Lamda Exceprition 
            LibalaryEngine.ProcessBooks(list,book=>book.PublicationDate.ToShortDateString());
            #endregion

        }
    }
}
