using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution;
using ExerciseSolution.Media;

namespace Tests
{
    [TestClass]
    public class LibraryTests
    {
        Library SuT;

        Book b1;
        Book b2;
            

        [TestMethod]
        public void AddingBooksShouldWork()
        {
            SuT.AddNewBook(b1);
            SuT.AddNewBook(b2);

        }

        [TestMethod]
        public void SearchShouldBeCorrect()
        {
            AddingBooksShouldWork();
            Assert.AreEqual(SuT.Search("Hello")[0],b1);
            Assert.AreEqual(SuT.Search("ello")[0], b1);
            Assert.AreEqual(SuT.Search("Marc")[0], b2);
            Assert.AreEqual(SuT.Search("lo").Length,0);
        }

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Library();
            b1 = new Book("Hello", "World", "1");
            b2 = new Book("Marcs Colors", "Sascha", "2");

        }
    }
}
