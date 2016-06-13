using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseSolution;
using ExerciseSolution.Media;
using ExerciseSolution.Users;

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
            SuT.AddNewMedium(b1);
            SuT.AddNewMedium(b2);
           
        }

        [TestMethod]
        public void SearchingTheLibraryShouldBeCorrect()
        {
            AddingBooksShouldWork();
            Assert.AreEqual(SuT.Search("Hello")[0], b1);
            Assert.AreEqual(SuT.Search("ello")[0], b1);
            Assert.AreEqual(SuT.Search("Marc")[0], b2);
            Assert.AreEqual(SuT.Search("lo").Count, 0);
        }

        public void BorrowedItemsShouldWorkAsIntended()
        {

        }

        [TestMethod]
        public void RegisterUserShallNotCrash()
        {
            //TODO: Change exercise to make it more test-friendly
            SuT.RegisterUser("Foo", "Bar@Foo.org");
        }

        [TestMethod]
        public void AuthentificateUserShallWorkProperly()
        {
            Assert.IsNull(SuT.Authentificate(0));
            SuT.RegisterUser("Hans", "Hans@test.org");
            UserAccount ua = SuT.Authentificate(0);
            Assert.IsNotNull(ua);
            Assert.IsNull(SuT.Authentificate(1));
        }

        [TestInitialize]
        public void SetUp()
        {
            SuT = new Library();
            b1 = new Book("Hello", 1, 3f, "World", "1");
            b2 = new Book("Marcs Colors", 1, 3f, "Sascha", "2");

        }
    }
}
