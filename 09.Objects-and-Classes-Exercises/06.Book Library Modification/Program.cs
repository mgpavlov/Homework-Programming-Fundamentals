using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime RealeaseDate { get; set; }
            public string ISBNumber { get; set; }
            public decimal Price { get; set; }
        }
        class Library
        {
            public string Name { get; set; }
            public List<Book> ListOfBooks { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library() { Name = "Pavlov", ListOfBooks = new List<Book>() };

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var tokens = input.Split().ToList();

                Book book = new Book();
                book.Title = tokens[0];
                book.Author = tokens[1];
                book.Publisher = tokens[2];
                book.RealeaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBNumber = tokens[4];
                book.Price = decimal.Parse(tokens[5]);

                library.ListOfBooks.Add(book);
            }

            var inputCurrentDate = Console.ReadLine();

            DateTime currentDate = DateTime.ParseExact(inputCurrentDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            

            var print = library.ListOfBooks.Where(d => d.RealeaseDate > currentDate).OrderBy(d => d.RealeaseDate).ThenBy(t => t.Title);

            foreach (var book in print)
            {
                Console.WriteLine($"{book.Title} -> {book.RealeaseDate:dd.MM.yyyy}");
            }
        }
    }
}
