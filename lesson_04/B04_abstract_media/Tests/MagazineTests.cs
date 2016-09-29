using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution.Media;

namespace Tests
{
    [TestClass]
    public class MagazineTests
    {
        Magazine SuT;

        [TestMethod]
        public void PropertiesShallBeCorrectReadable()
        {
            Assert.AreEqual(SuT.Title, "Hallo");
            Assert.AreEqual(SuT.ISSN, "1");
            Assert.AreEqual(SuT.Issuing, 2);
            Assert.AreEqual(SuT.Year, 2016);
        }

        [TestMethod]
        public void SearchShouldBeCorrect()
        {
            // no search in year and issuing possible
            Assert.IsTrue(SuT.Search("Hallo"));
            Assert.IsFalse(SuT.Search("Welt"));
            Assert.IsTrue(SuT.Search("1"));
            Assert.IsTrue(SuT.Search("all"));
            Assert.IsFalse(SuT.Search("q"));
        }

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Magazine("Hallo","1",2,2016); 
        }
    }
}
