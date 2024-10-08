using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;
        private int noofpages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int NoOfPages
        {
            get { return noofpages; }
            set { noofpages = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
            this.noofpages = bookNoOfPages;
        }

        

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Book no of pages: {NoOfPages}");
            Console.WriteLine();
        }
    }
}