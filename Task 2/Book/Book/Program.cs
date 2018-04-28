using System;


namespace Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            var author = new Author("Bob","Marley",DateTime.Parse("01.01.1970"));

            var book = new Book("Bible", 300, "Drofa", "01.01.2018", "21 days", author);
           
            Console.WriteLine(book);
        }
    }
}
