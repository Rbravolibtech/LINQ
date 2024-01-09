using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var books = new BookRepository().GetBooks();

            //LINQ Extension methods

            books.Where();
            books.Single();
            books.SingleOrDefault();

            books.First();
            books.FirstOrDefault();

            books.Last();
            books.LastOrDefault();

            books.Min();
            books.LastOrDefault();

            books.Min();
            books.Max();
            books.Count();
            books.Sum();
            books.Average(b => b.Price);

            books.Skip(5).Take(3);
            


            //////////LINQ EXTENTION METHODS//////////////////

            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");

            Console.WriteLine(book == null);

            /////////////////LINQ query operators////////////////

            //var cheaperBooks =
            //                from b in books
            //                where b.Price < 10
            //                orderby b.Title
            //                select b.Title; 

            //////////// ///////using LINQ Extentions //////////////////

            //var cheapBooks = books
            //                    .Where(b => b.Price < 10)
            //                    .OrderBy(b => b.Title)
            //                    .Select(b => b.Title);



            /////////THE CODE below give the same output as the one on above////

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //foreach (var book in cheapBooks)
            //    Console.WriteLine(book);
            //        Console.WriteLine(book.Title + " " + book.Price);
        }
    }
}