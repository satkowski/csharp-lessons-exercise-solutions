using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution.Users;
using ExerciseSolution.Media;

namespace Tests
{
    [TestClass]
    public class UserAccountTests
    {
        UserAccount SuT;
        Medium M;

        [TestMethod]
        public void PropertiesShallBeCorrectReadable()
        {
            Assert.AreEqual(SuT.ID, 1L);
            Assert.AreEqual(SuT.Name, "Foo");
            Assert.AreEqual(SuT.EMail, "Bar@Foo.org");
            Assert.AreEqual(SuT.FeeToPay, 0f);
        }
        
        [TestMethod]
        public void BorrowedItemsCountShouldWorkProperly()
        {
            Assert.AreEqual(SuT.BorrowedCount, 0);
            SuT.borrow(M);
            Assert.AreEqual(SuT.BorrowedCount, 1);
            SuT.returnMedium(M);
            Assert.AreEqual(SuT.BorrowedCount, 0);
        }

        [TestMethod]
        public void BorrowShouldWorkProperly()
        {
            while (SuT.BorrowedCount < UserAccount.MAX_MEDIA_COUNT)
            {
                Assert.AreEqual(SuT.borrow(M), true);
            }
            Assert.AreEqual(SuT.borrow(M), false);  
        }

        [TestMethod]
        public void ReturnMediumShouldWorkProperly()
        {
            Assert.AreEqual(SuT.returnMedium(M), false);
            SuT.borrow(M);
            Assert.AreEqual(SuT.returnMedium(M), true);
        }

        [TestMethod]
        public void FeesShouldBeCalculatedProperly()
        {
            Assert.AreEqual(SuT.FeeToPay, 0f);
            ReturnMediumShouldWorkProperly();
            Assert.AreEqual(SuT.FeeToPay, 9f);
        }

        // Implementation for FeeToPay is missing?
           


        [TestInitialize]
        public void SetUp()
        {
            SuT = new UserAccount("Foo", "Bar@Foo.org", 1L);
            M = new Book("A", -3, 3f, "B", "2");
        }
    }
}
