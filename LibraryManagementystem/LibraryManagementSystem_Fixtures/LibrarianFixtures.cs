using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementystem;

namespace LibraryManagementSystem_Fixtures
{
    [TestClass]
    public class LibrarianFixtures
    {
        [TestMethod]
        public void Librarian_isuues_the_book_returns_token()
        {
            Books books = new Books()
            {
                Name = "Ranbanor",
                Category = Genres.Fictional
            };
            Books book1 = new Books()
            {
                Name = "Myth",
                Category = Genres.Horror

            };
            Librarian librarian = new Librarian();
            int tokenNumber = librarian.Issue(books);
            Assert.AreEqual(25, tokenNumber);
        }
        [TestMethod]
        public void Librarian_isuues_the_book_and_updates_the_library_list()
        {
            Library library = new Library();
            Books books = new Books()
            {
                Name = "Ranbanor",
                Category = Genres.Fictional
            };
            library.Add(books);
            Books book1 = new Books()
            {
                Name = "Myth",
                Category = Genres.Horror

            };
            library.Add(book1);
            Books book2 = new Books()
            {
                Name = "Subham",
                Category = Genres.Technology
            };
            library.Add(book2);
            Librarian librarian = new Librarian();
            librarian.Issue(book1);
            Assert.AreEqual(2,library.CollectionOfBooks.Count);
            Assert.AreEqual(1, librarian.IssuedBooks.Count);
        }
    }
}
