using System;
using System.Runtime.InteropServices;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Session 10 : Lambda Expression 

            /*
             What is Lambda Expression ?
            Ans - 
                - An anonymous method which does not have 
                    - access modifier
                    - no name 
                    - no return type 

            Why do we requrie this expression ?
                - ans : for dev convience and code readablity 

                // arg => expression
             */

            //var result = square(5);
            //Console.WriteLine(result);

            //Func<int, int> square = number => number * number;

            //Console.WriteLine(square(5));

            /*
             () => expression
             x => expression
            (x, y,z) => expression
             
             */

            // WAP to print the multiplier of 50
            /*  10 * 5 = 50 */
            //const int factor = 5;
            //Func<int, int> multiplier = n => factor * n;
            //Console.WriteLine(multiplier(10));



            var books = new BookRepository().GetBook();
            var collection = books.FindAll(book => book.Price < 10);

            foreach (var book in collection)
            {
                Console.WriteLine(book.Title);
            }

        }


        public static int square(int number)
        {
            return number * number;
        }

        public class BookRepository
        {
            public List<Book> GetBook()
            {
                return new List<Book>
                {
                    new Book() { Title = "Harry Potter", Price = 10.2 },
                    new Book() { Title = "Narnia", Price = 5 },
                    new Book() { Title = "Mein Kampe", Price = 7 }
                };
            }
        }

    }


}