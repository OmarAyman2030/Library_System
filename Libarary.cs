using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Libarary
    {
        private Book[] books = new Book[1000];
        private int currrentBookCounts = 0;
        private Book[] booksBoworred = new Book[50];
        private int currrentBookBoworredCounts = 0;



        public void Display()
        {
            //Add logic
            for(int i = 0; i<currrentBookCounts;i++)
            {
                Console.WriteLine($"Book Name: {books[i].Title} published by: {books[i].Author}");
            }
            
        }

        public void AddBook(Book book)
        {
            if(currrentBookCounts <= books.Length)
            {
                books[currrentBookCounts++] = book;
                Console.WriteLine("\t\t\tBook added Successfully");
            }
            else
            {
                Console.WriteLine("Library is Full, So Can't Add new books");
            }
        }

        public void RemoveBook(Book book)
        {
            //Add Logic
            int index = Array.IndexOf(books, book);
            books[index] = null;
            currrentBookCounts--;
            Console.WriteLine("Book Removed");
            
        }

        public void BorrowBooks(Book book)
        {
            if (currrentBookBoworredCounts <= booksBoworred.Length)
            {
                books[currrentBookBoworredCounts++] = book;
                Console.WriteLine("\t\t\tBook Borrowed Successfully");
            }
            else
            {
                Console.WriteLine("Sorry Can't borrow the book you passed the limit avaliable!");
            }
        }
    }
}
