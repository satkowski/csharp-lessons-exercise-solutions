using ExerciseSolution.Users;

namespace ExerciseSolution.Media
{
    /// <summary>
    /// Represent all kind of media.
    /// </summary>
    public class Medium
    {
        /// <summary>
        /// The user that has borrowed this book.
        /// </summary>
        protected UserAccount borrowedTo;

        /// <summary>
        /// The Title of this book.
        /// </summary>
        public string Title
        { get; protected set; }


        /// <summary>
        /// Constructor. Creates a new medium with the given parameters.
        /// </summary>
        /// <param name="title">the title</param>
        public Medium(string title)
        {
            Title = title;
        }


        /// <summary>
        /// Check if this medium matchs with the given search query. It will use all relevant informations of this medium.
        /// </summary>
        /// <param name="searchQuery">the search query</param>
        /// <returns>true if this medium matchs</returns>
        public virtual bool Search(string searchQuery)
        {
            if(Title.Contains(searchQuery))
                return true;
            return false;
        }
    }
}
