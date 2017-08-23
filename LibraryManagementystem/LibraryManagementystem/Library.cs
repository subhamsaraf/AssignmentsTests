using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementystem
{
    public class Library
    {
        public List<Books> CollectionOfBooks = new List<Books>();
        Librarian librarian = new Librarian();


        public void Add(Books books)
        {
            CollectionOfBooks.Add(books);
        }


        public List<Books> Remove(Books books)
        {
            CollectionOfBooks.Remove(books);
            return CollectionOfBooks;
        }
    }
}
