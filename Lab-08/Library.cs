using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    public  class Library : ILibrary
    {
        private Dictionary<string, Book> books;
        public int Count => books.Count;

        public Library()
        {
          books = new Dictionary<string, Book>();
        }



        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            string author =firstName + " " + lastName;

            var Book = new Book { Title = title, Author = author, Page=numberOfPages };

            books.Add(title, Book);

        }

        public Book Borrow(string title)
        {
            if (books.ContainsKey(title))
            {Book bookbroow = books[title];
               books.Remove(title);
                return bookbroow;
            }
            return null;
        }

        

        public void Return(Book book)
        {
            books.Add(book.Title, book);
            Console.WriteLine($"{book.Title}  is  return ");
        }
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in books.Values)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          
                yield return GetEnumerator;
            
        }
    }
}
