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

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Video("Hallo", "1");
            
        }
    }
}
