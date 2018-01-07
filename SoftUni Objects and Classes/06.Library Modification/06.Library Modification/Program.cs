using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Library_Modification
{

 
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime Release { get; set; }
            public string ISBN { get; set; }
            public double Price { get; set; }
        }
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        static Book ReadBook()
        {
            var book = new Book();
            string[] args = Console.ReadLine().Split(' ');
            book.Title = args[0];
            book.Release = DateTime.ParseExact(args[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            return book;
        }
        static Library ReadAllBooks()
        {
            var libraray = new Library();
            libraray.Books = new List<Book>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var book = ReadBook();
                libraray.Books.Add(book);
            }
            return libraray;
        }
        static void Main(string[] args)
        {
            var lib = ReadAllBooks();
            var books = lib.Books;

            var dict = new Dictionary<string, DateTime>();
            string inn = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inn, "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in books)
            {
                var tit = item.Title;
                var relD = item.Release;
                if (!dict.ContainsKey(tit)) dict.Add(tit, relD);
                else dict[tit] = relD;
            }

            foreach (var item in dict.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                var D = item.Value.Date;
                if (item.Value > date) Console.WriteLine("{0} -> {1:d.MM.yyyy}", item.Key, D);
            }
        }
    }
}
