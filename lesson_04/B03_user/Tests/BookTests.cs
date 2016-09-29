using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution.Media;

namespace Tests
{
    [TestClass]
    public class BookTests
    {
        Book SuT;

        [TestMethod]
        public void PropertiesShallBeCorrectReadable()
        {
            Assert.AreEqual(SuT.Title, "Hallo");
            Assert.AreEqual(SuT.Autor, "Welt");
            Assert.AreEqual(SuT.ISBN, "1");
        }

        [TestMethod]
        public void SearchShouldBeCorrect()
        {
            Assert.IsTrue(SuT.Search("Hallo"));
            Assert.IsTrue(SuT.Search("Welt"));
            Assert.IsTrue(SuT.Search("1"));
            Assert.IsTrue(SuT.Search("all"));
            Assert.IsTrue(SuT.Search("e"));
            Assert.IsFalse(SuT.Search("q"));
        }

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Book("Hallo", "Welt", "1");
            
        }
    }
}
