using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Library
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releaseDate { get; set; }
        public string isbn { get; set; }
        public double price { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, double price)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.isbn = isbn;
            this.price = price;
        }



    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Library> library = new List<Library>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                library.Add(new Library(line[0], line.Skip(1).ToList());
            }
        }
    }
}
