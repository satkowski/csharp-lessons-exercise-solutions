using ExerciseSolution.Media;
using ExerciseSolution.Users;

namespace ExerciseSolution
{
    public class Library
    {
        /// <summary>
        /// All useraccount that this library has.
        /// </summary>
        private UserAccount[] users;
        /// <summary>
        /// All books that this library manages.
        /// </summary>
        private Medium[] media;


        /// <summary>
        /// Constructor. Creates a library with max 100 users ans 500 books.
        /// </summary>
        public Library()
        {
            users = new UserAccount[100];
            media = new Medium[500];
        }


        public Medium[] Search(string searchQuery)
        {
            // Only search if the search query hast more than 2 characters.
            if(searchQuery.Length < 3)
                return new Medium[0];

            // Create a temporary books array to save all found books. We need a counter to do that.
            Medium[] tempBooks = new Medium[500];
            int tempBooksCounter = 0;
            for(int i = 0; i < media.Length; i++)
                if(media[i].Search(searchQuery))
                    tempBooks[tempBooksCounter++] = media[i];

            // Create a new array that is only as big as the number of results. Copy all results in it.
            Medium[] outputBooks = new Medium[tempBooksCounter];
            for(int i = 0; i < tempBooksCounter; i++)
                outputBooks[i] = tempBooks[i];

            return outputBooks;
        }
    }
}
