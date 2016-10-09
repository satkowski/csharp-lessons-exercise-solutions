
namespace ExerciseSolution.Media
{
    /// <summary>
    /// A representation of a book.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// The Title of this book.
        /// </summary>
        public string Title
        { get; private set; }
        /// <summary>
        /// The autor of this book.
        /// </summary>
        public string Autor
        { get; private set; }
        /// <summary>
        /// The ISBN number of this book.
        /// </summary>
        public string ISBN
        { get; private set; }


        /// <summary>
        /// Constructor. Creates a new book with the given parameters.
        /// </summary>
        /// <param name="title">the title</param>
        /// <param name="autor">the autor</param>
        /// <param name="isbn">the isbn</param>
        public Book(string title, string autor, string isbn)
        {
            Title = title;
            Autor = autor;
            ISBN = isbn;
        }


        /// <summary>
        /// Check if this books matchs with the given search query. It will use all relevant informations of this book.
        /// </summary>
        /// <param name="searchQuery">the search query</param>
        /// <returns>true if this book matchs</returns>
        public bool Search(string searchQuery)
        {
            if(Title.Contains(searchQuery) || Autor.Contains(searchQuery) || ISBN.Contains(searchQuery))
                return true;
            return false;
        }
    }
}
