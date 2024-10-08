class Book
{

    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

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

         

         Book book = new Book();
         book.Title = "C# for beginners";
         book.Author = "BillGates";
         book.ISBN = "12345678";
         book.NoOfPages = 200;


         Book book1 = new Book();
         book1.Title = "C# Methods and Classes";
         book1.Author = "Microsoft";
         book1.ISBN = "55667778";
         book1.NoOfPages = 200;

         // Output book information to the console

         book.DisplayInfo();
         book1.DisplayInfo();



    }

}