using System;
using System.Collections.Generic;
using System.Linq;

namespace mockAssessment
{
    public class BookService : IBookRepository
    {
        private List<Book> books;

        public BookService()
        {
            books = new List<Book>();
        }

        public void CreateBook()
        {
            Console.WriteLine("Enter the Title:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter the Author:");
            var author = Console.ReadLine();
            Console.WriteLine("Enter the ISBN:");
            var isbn = Console.ReadLine();
            var book = new Book(title, author, isbn);
            AddBook(book);
            Console.WriteLine("Added");
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            books.ForEach(Console.WriteLine);
            return books;
        }

        public List<Book> SearchBooks(string search)
        {
            return books.Where(book => book.title.Contains(search) || book.author.Contains(search)).ToList();
        }
    }
}