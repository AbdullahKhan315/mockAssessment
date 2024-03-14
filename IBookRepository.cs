using System;
using System.Collections.Generic;
using System.Text;

namespace mockAssessment
{
    public interface IBookRepository
    {
        public void CreateBook();

        public abstract void AddBook(Book book);

        public abstract List<Book> GetAllBooks();

        public abstract List<Book> SearchBooks(string search);
    }
}
