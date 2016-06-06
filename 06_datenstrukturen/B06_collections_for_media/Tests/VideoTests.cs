using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution.Media;

namespace Tests
{
    [TestClass]
    public class VideoTests
    {
        Video SuT;

        [TestMethod]
        public void PropertiesShallBeCorrectReadable()
        {
            Assert.AreEqual(SuT.Title, "Hallo");
            Assert.AreEqual(SuT.EAN, "1");

            Assert.AreEqual(SuT.Period, 1);
            Assert.AreEqual(SuT.FeePerDay, 3f);
        }

        [TestMethod]
        public void SearchShouldBeCorrect()
        {
            Assert.IsTrue(SuT.Search("Hallo"));
            Assert.IsFalse(SuT.Search("Welt"));
            Assert.IsTrue(SuT.Search("1"));
            Assert.IsTrue(SuT.Search("all"));
            Assert.IsFalse(SuT.Search("e"));
            Assert.IsFalse(SuT.Search("q"));
        }

        [TestMethod]
        public void CalculateFeeShouldBeCorrect()
        {
            Assert.AreEqual(0f, SuT.CalculateFee());
            Medium SuT2 = new Video("A", -3, 3f, "2");
            Assert.AreEqual(9f, SuT2.CalculateFee());
        }

        [TestMethod]
        public void ReturnDateShallBeCorrect()
        {
            DateTime returnDate = DateTime.Now.AddDays(SuT.Period);

            Assert.AreEqual(SuT.ReturnDate.Day, returnDate.Day);
            Assert.AreEqual(SuT.ReturnDate.Month, returnDate.Month);
            Assert.AreEqual(SuT.ReturnDate.Year, returnDate.Year);
        }

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Video("Hallo", 1, 3f, "1");
            
        }
    }
}
