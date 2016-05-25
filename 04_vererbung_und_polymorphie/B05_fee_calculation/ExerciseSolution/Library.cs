using ExerciseSolution.Media;
using ExerciseSolution.Users;

namespace ExerciseSolution
{
    public class Library
    {
        /// <summary>
        /// All books that this library manages.
        /// </summary>
        private Medium[] medien;
        /// <summary>
        /// The number of that were already added to the stock of this library.
        /// </summary>
        private int medienCount;
        /// <summary>
        /// All useraccount that this library has.
        /// </summary>
        private UserAccount[] users;
        /// <summary>
        /// The number of users that are already registerd in this library.
        /// </summary>
        private int userCount;


        /// <summary>
        /// Constructor. Creates a library with max 100 users ans 500 books.
        /// </summary>
        public Library()
        {
            medienCount = 0;
            medien = new Medium[500];
            userCount = 0;
            users = new UserAccount[100];
        }


        /// <summary>
        /// Searches in the stock of this library for matching books.
        /// </summary>
        /// <param name="searchQuery">the search query.</param>
        /// <returns>the array of all found books. Empty if no books was found.</returns>
        public Medium[] Search(string searchQuery)
        {
            // Only search if the search query hast more than 2 characters.
            if (searchQuery.Length < 3)
                return new Medium[0];

            // Create a temporary books array to save all found books. We need a counter to do that.
            Medium[] tempMedien = new Medium[500];
            int tempMedienCounter = 0;
            for (int i = 0; i < medien.Length; i++)
            {
                if (medien[i] == null)
                    continue;
                if (medien[i].Search(searchQuery))
                    tempMedien[tempMedienCounter++] = medien[i];
            }
            // Create a new array that is only as big as the number of results. Copy all results in it.
            Medium[] outputMedien = new Medium[tempMedienCounter];
            for (int i = 0; i < tempMedienCounter; i++)
                outputMedien[i] = tempMedien[i];

            return outputMedien;
        }

        /// <summary>
        /// Add a new book to the stock of the library.
        /// </summary>
        /// <param name="book"></param>
        public void AddNewMedium(Medium m)
        {
            medien[medienCount] = m;
            medienCount++;
        }

        /// <summary>
        /// Add a new user to this library.
        /// </summary>
        /// <param name="name">the name of the user</param>
        /// <param name="email">the email of the user</param>
        public void RegisterUser(string name, string email)
        {
            UserAccount user = new UserAccount(name, email, userCount);
            users[userCount] = user;
            userCount++;
        }
    }
}
