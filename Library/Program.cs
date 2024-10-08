class Book
{

    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    

    // Book object 
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()
    {
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Auhtor: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book No of pages: {NoOfPages}");
        Console.WriteLine();

    }


    static void Main(string[] args)
    {

         Book book = new Book("C# for beginners", "Bill Gates", "1234567", 200);

         

         // Output book information to the console

         book.DisplayInfo();
         



    }

}