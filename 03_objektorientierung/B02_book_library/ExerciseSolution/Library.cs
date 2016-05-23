using ExerciseSolution.Media;

namespace ExerciseSolution
{
    public class Library
    {
        /// <summary>
        /// All books that this library manages.
        /// </summary>
        private Book[] books;
        /// <summary>
        /// The number of that were already added to the stock of this library.
        /// </summary>
        private int bookCount;


        /// <summary>
        /// Constructor. Creates a library with max 100 users ans 500 books.
        /// </summary>
        public Library()
        {
            bookCount = 0;
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

        /// <summary>
        /// Add a new book to the stock of the library.
        /// </summary>
        /// <param name="book"></param>
        public void AddNewBook(Book book)
        {
            books[bookCount] = book;
            bookCount++;
        }
    }
}
