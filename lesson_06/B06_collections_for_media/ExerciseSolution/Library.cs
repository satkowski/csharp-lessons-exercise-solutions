using ExerciseSolution.Media;
using ExerciseSolution.Users;
using System.Collections.Generic;

namespace ExerciseSolution
{
    public class Library
    {
        /// <summary>
        /// All media that this library manages.
        /// </summary>
        private Dictionary<long, Medium> media;
        /// <summary>
        /// The number of that were already added to the stock of this library.
        /// </summary>
        private int mediumCount;
        /// <summary>
        /// All useraccount that this library has.
        /// </summary>
        private Dictionary<long, UserAccount> users;
        /// <summary>
        /// The number of users that are already registerd in this library.
        /// </summary>
        private int userCount;


        /// <summary>
        /// Constructor. Creates a library with max 100 users ans 500 books.
        /// </summary>
        public Library()
        {
            mediumCount = 0;
            media = new Dictionary<long, Medium>();
            userCount = 0;
            users = new Dictionary<long, UserAccount>();
        }


        /// <summary>
        /// Searches in the stock of this library for matching media.
        /// </summary>
        /// <param name="searchQuery">the search query.</param>
        /// <returns>the array of all found media. Empty if no media was found.</returns>
        public List<Medium> Search(string searchQuery)
        {
            // Only search if the search query hast more than 2 characters.
            if (searchQuery.Length < 3)
                return new List<Medium>();

            // Create a medium array to save all found media.
            List<Medium> outputMedia = new List<Medium>();
            foreach(Medium medium in media.Values)
                if(medium.Search(searchQuery))
                    outputMedia.Add(medium);

            return outputMedia;
        }

        /// <summary>
        /// Add a new media to the stock of the library.
        /// </summary>
        /// <param name="book"></param>
        public void AddNewMedium(Medium m)
        {
            media.Add(mediumCount, m);
            mediumCount++;
        }

        /// <summary>
        /// Add a new user to this library.
        /// </summary>
        /// <param name="name">the name of the user</param>
        /// <param name="email">the email of the user</param>
        public void RegisterUser(string name, string email)
        {
            UserAccount user = new UserAccount(name, email, userCount);
            users.Add(userCount, user);
            userCount++;
        }
    }
}
