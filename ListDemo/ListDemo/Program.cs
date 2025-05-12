namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Clean Code", "Robert C. Martin", "Software"),
                new Book("Clean Architecture", "Robert C. Martin", "Software"),
                new Book("The Pragmatic Programmer", "Andrew Hunt", "Software"),
                new Book("The Art of Computer Programming", "Donald Knuth", "Software"),
                new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy"),
                new Book("The Lord of the Rings", "J.R.R. Tolkien", "Fantasy")
            };

            //Displays all books in the list
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} in the {book.Genre} genre.");
            }

            Console.WriteLine(); //spacing

            Console.WriteLine("Enter a book title to search: ");
            string searchTitle = Console.ReadLine();

            Console.WriteLine(); //spacing

            //Finds the first book that contains the search title
            Book foundBook = books.Find(book => book.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase));
            if (foundBook != null)
            {
                Console.WriteLine("First Book Found: ");
                Console.WriteLine($"Book found: {foundBook.Title} by {foundBook.Author} in the {foundBook.Genre} genre.");
            }
            else
            {
                Console.WriteLine("Book not found.");

            }

            Console.WriteLine(); //spacing

            //Finds all books that contain the search title
            List<Book> foundBooks = books.FindAll(book => book.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase));
            if (foundBooks != null)
            {
                foreach (Book book in foundBooks)
                {
                    Console.WriteLine("All Books Found: ");
                    Console.WriteLine($"Book found: {book.Title} by {book.Author} in the {book.Genre} genre.");
                }
            }
            else
            {
                Console.WriteLine("No books found.");
            }

        }
    }
}
