using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementystem;

namespace LibraryManagementSystem_Fixtures
{
    [TestClass]
    public class LibraryFixtures
    {
        [TestMethod]
        public void Bokks_get_added_to_the_library()
        {
            Library library = new Library();
            Books book1 = new Books()
            {
                Name = "Ranbanor",
                Category = Genres.Fictional
            };
            library.Add(book1);
            Books book2 = new Books()
            {
                Name = "Myth",
                Category = Genres.Horror

            };
            library.Add(book2);
            Assert.AreEqual(2, library.CollectionOfBooks.Count());
        }
        [TestMethod]
        public void Books_to_be_deleted_from_library()
        {
            Library library = new Library();
            Books book1 = new Books()
            {
                Name = "Ranbanor",
                Category = Genres.Fictional
            };
            library.Add(book1);
            Books book2 = new Books()
            {
                Name = "Myth",
                Category = Genres.Horror

            };
            library.Add(book2);
            library.Remove(book2);

            Assert.AreEqual(1, library.CollectionOfBooks.Count());
        }
    }
}

