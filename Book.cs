using System;
using System.Collections.Generic;
using System.Text;

namespace mockAssessment
{
    public class Book
    {
        public string title;
        public string author;
        public string isbn;
        public Book (string aTitle,string aAuthor, string aIsbn)
        {
            title = aTitle;
            author = aAuthor;
            isbn = aIsbn;
        }
    }
}
