using System;
using System.Linq;
using EF2.DB_Lib;

namespace EF2.TestApp
{
    class Program
    {
        static void Main()
        {
            var db = new BookStoreDb();

            foreach (var author in db.TabAuthors.ToList())
            {
                Console.WriteLine($"#{author.Id}: {author.LastName} {author.FirstName}");
                foreach (var book in author.TabBooks.ToList())
                {
                    Console.WriteLine($"\t#{book.Id}: {book.Title}, {book.YearOfCreation}");
                }
            }
        }
    }
}