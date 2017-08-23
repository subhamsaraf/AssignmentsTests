using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementystem
{
    public class Librarian
    {
        List<Books> IssuedBooks = new List<Books>();
        Library library = new Library();


        public int Issue(Books books)
        {
            IssuedBooks.Add(books);
            library.Remove(books);
            return 25;
        }


        public List<Books> LibraryBooksRecord()
        {
            return library.CollectionOfBooks;
        }
        //public override string ToString()
        //{
        //    return $"{}"
        //}
    }
}
