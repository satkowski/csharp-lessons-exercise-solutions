using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution.Users;

namespace Tests
{
    [TestClass]
    public class UserAccountTests
    {
        UserAccount SuT;

        [TestMethod]
        public void PropertiesShallBeCorrectReadable()
        {
            Assert.AreEqual(SuT.ID, 1L);
            Assert.AreEqual(SuT.Name, "Foo");
            Assert.AreEqual(SuT.EMail, "Bar@Foo.org");
            Assert.AreEqual(SuT.FeeToPay, 0f);
        }

        // Implementation for FeeToPay is missing?

        // TODO: Make design more test-friendy to test more things like borrowdBooks

        [TestInitialize]
        public void SetUp()
        {
            SuT = new UserAccount("Foo", "Bar@Foo.org", 1L);

        }
    }
}
