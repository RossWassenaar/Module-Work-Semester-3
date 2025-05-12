namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictonairies store key-value pairs.
             * Keys are unique identifiers of the value stored adjacent to it.
             * Dictionaries allow fast searches or look-up.
             */

            Dictionary<string, string> books = new Dictionary<string, string>();
            books.Add("978-01", "Clean Code: Robot C. Martin");
            books.Add("978-02", "The Pragmatic Programmer: Andrew Hunt");

            //Display the dictionary with the keys and values
            foreach (var book in books)
            {
                Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
            }

            //Adding a book to the dictionary
            Console.WriteLine("Enter the ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Enter the book title");
            string title = Console.ReadLine();

            //prevents addition of duplicate books
            if (!books.ContainsKey(isbn))
            {
                books.Add(isbn, title);
                Console.WriteLine("The book has been added to the dictionary");
                foreach (var book in books)
                {
                    Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
                }
            }
            else
            {
                Console.WriteLine("The book already exists in the dictionary");
            }

            //Searching for a book in the dictionary
            //Prompting the user for the ISBN of the book to search
            Console.Write("Enter the ISBN of the book to search for: ");
            string isbnSearch = Console.ReadLine();
            books.TryGetValue(isbnSearch, out string bookTitle);
            if (bookTitle != null)
            {
                Console.WriteLine(bookTitle);
            }
            else
            {
                Console.WriteLine("The book does not exist in the dictionary");
            }

            //Removing a book from the dictionary
            //Prompting the user for the ISBN of the book to remove
            Console.WriteLine("Please enter an isbn of the book to remove from the dictionary:");
            string isbnRemove = Console.ReadLine();
            if (books.ContainsKey(isbnRemove))
            {
                books.Remove(isbnRemove);
                Console.WriteLine("The book has been removed from the dictionary");
                foreach (var book in books)
                {
                    Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
                }
            }
            else
            {
                Console.WriteLine("The book does not exist in the dictionary");
            }
        }
    }
}
