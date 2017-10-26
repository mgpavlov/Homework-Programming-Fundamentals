using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Book_Library
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
            var lines = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");

            int n = int.Parse(lines[0]);
            Library library = new Library() { Name = "Pavlov", ListOfBooks = new List<Book>() };

            for (int i = 1; i <= n; i++)
            {
                string input = lines[i];
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
            var authorsSales = new Dictionary<string, decimal>();
            var authors = library.ListOfBooks.Select(b => b.Author).Distinct().ToList();
            foreach (var author in authors)
            {
                var sales = library.ListOfBooks.Where(a => a.Author == author).Sum(p => p.Price);

                authorsSales.Add(author, sales);
                //Console.WriteLine($"{author} -> {authorsSales:f2}");
            }
            var printFormat = authorsSales.OrderByDescending(p => p.Value).ThenBy(a => a.Key)/*.ToDictionary(a => a)*/;

            foreach (var item in printFormat)
            {
                File.AppendAllText("../../output.txt", ($"{item.Key} -> {item.Value:f2}" + Environment.NewLine));
            }
        }
    }
}
