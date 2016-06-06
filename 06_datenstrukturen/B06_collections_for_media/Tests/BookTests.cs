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
            
            Assert.AreEqual(SuT.Period, 1);
            Assert.AreEqual(SuT.FeePerDay, 3f);
        }

        [TestMethod]
        public void ReturnDateShallBeCorrect()
        {            
            DateTime returnDate = DateTime.Now.AddDays(SuT.Period);

            Assert.AreEqual(SuT.ReturnDate.Day,returnDate.Day);
            Assert.AreEqual(SuT.ReturnDate.Month,returnDate.Month);
            Assert.AreEqual(SuT.ReturnDate.Year,returnDate.Year);
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

        [TestMethod]
        public void CalculateFeeShouldBeCorrect()
        {
            Assert.AreEqual(0f,SuT.CalculateFee());
            Medium SuT2 = new Book("A", -3, 3f, "B", "2");
            Assert.AreEqual(9f, SuT2.CalculateFee());
        }

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Book("Hallo",1 ,3f, "Welt", "1");
            
        }
    }
}
