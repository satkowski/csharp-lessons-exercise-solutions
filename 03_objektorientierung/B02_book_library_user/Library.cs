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
        private Book[] books;


        /// <summary>
        /// Constructor. Creates a library with max 100 users ans 500 books.
        /// </summary>
        public Library()
        {
            users = new UserAccount[100];
            books = new Book[500];
        }


        /// <summary>
        /// Searches in the stock of this library for matching books.
        /// </summary>
        /// <param name="searchQuery">the search query.</param>
        /// <returns>the array of all found books. Empty if no books was found.</returns>
        public Book[] Search(string searchQuery)
        {
            // Only search if the search query hast more than 2 characters.
            if(searchQuery.Length < 3)
                return new Book[0];

            // Create a temporary books array to save all found books. We need a counter to do that.
            Book[] tempBooks = new Book[500];
            int tempBooksCounter = 0;
            for(int i = 0; i < books.Length; i++)
                if(books[i].Search(searchQuery))
                    tempBooks[tempBooksCounter++] = books[i];

            // Create a new array that is only as big as the number of results. Copy all results in it.
            Book[] outputBooks = new Book[tempBooksCounter];
            for(int i = 0; i < tempBooksCounter; i++)
                outputBooks[i] = tempBooks[i];

            return outputBooks;
        }
    }
}
