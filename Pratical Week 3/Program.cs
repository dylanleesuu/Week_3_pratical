class Book
{
    // Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Create a Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }


    void DisplayInfo()
    {
        //Output book info to console
        Console.WriteLine("Book Information");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {NoOfPages}");
        Console.WriteLine();

    }


    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book("C# for beginners", "Bill Gates", "1234566", 200);
        Book book1 = new Book("C# for intermediate", "Microsoft", "123490", 510);

        //Output Book info to console

        book.DisplayInfo();
        book1.DisplayInfo();
    }
}