using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp8
{
    internal class Library 
    {
        public string Name { get; set; }
        Book[] books;
        public int currentBooks = 0;

        public Library( string name) 
        {
            this.Name = name;
            books = new Book[currentBooks];
        }
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length+1);
            books[books.Length-1] = book;
            currentBooks++;
        }
      
        public void RemoveBook(int _ID)
        {
            Book[] arr = new Book[books.Length - 1];
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Id == _ID)
                {
                    arr[i] = books[i];
                    continue;
                   
                }
                
                books = arr;
            }
        }
        public void Update(int _ID, Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Id == _ID)
                {
                    books[i].Name =book.Name;
                    books[i].AuthorName=book.AuthorName;
                    books[i].Price = book.Price;
                }
            }
        }
        public Book GetBook(string Name)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i].Name == Name)
                {
                    return books[i];
                }
            }
            return null;
        }
        public void GetAllBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
        public Book GetBookById(int id)
        {
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    return item;
                }


            }
            return null;

        }
    }
}

    
