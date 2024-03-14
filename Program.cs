using System;

namespace mockAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BookService service = new BookService();
            while (true)
            {
                Console.WriteLine("Enter '1' to Add a book");
                Console.WriteLine("Enter '2' to See all books");
                Console.WriteLine("Enter '3' to Search books");

                var entered = Console.ReadLine();

                switch (entered)
                {
                    case "1":

                        service.CreateBook();
                        break;
                    case "2":
                        service.GetAllBooks();
                        break;
                    case "3":
                        Console.WriteLine("Enter a Title or Author:");
                        var search = Console.ReadLine();
                        service.SearchBooks(search);
                        break;
                }
            }
        }

    }
}
