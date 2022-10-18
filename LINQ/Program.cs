using System.Collections.Generic;
namespace LINQ;

public static class Program
{
    public static void Main()
    {
        /*
         * what is linq ?
         * Linq is Language Integrated Query
         * Used for -> gives you capability to query objects in memory natively
         * linq can used to query following type of objects
         *      - objects in memory
         *      - Database
         *      - XML
         *      - ADO.NET DataSet
         */

        var bookList = new BookRepository().GetBooks();
        
        var books = bookList.Select(book => book.Price > 10); // linq expression 

        var books2 = from b in bookList where b.Price > 10 select b.Title ; // linq expression
        
        // select Title from Book where Price > 10 (SQL -> Structured Query Language)

        var otherWayOfLinq = bookList.Where(b => b.Price > 10)// Linq Expression 
            .OrderBy(c => c.Title)
            .Select(b => b.Title);
        
        // ORM -> 

        foreach (var items in books2)
        {
            Console.WriteLine(items);
        }

    }
}