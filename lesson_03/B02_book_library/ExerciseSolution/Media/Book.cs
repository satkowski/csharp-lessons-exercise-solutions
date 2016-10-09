
namespace ExerciseSolution.Media
{
    public class Book
    {
        public string Title
        { get; private set; }
        public string Autor
        { get; private set; }
        public string ISBN
        { get; private set; }

        
        public Book(string title, string autor, string isbn)
        {
            Title = title;
            Autor = autor;
            ISBN = isbn;
        }

        
        public bool Search(string searchQuery)
        {
            if(Title.Contains(searchQuery) || Autor.Contains(searchQuery) || ISBN.Contains(searchQuery))
                return true;
            return false;
        }
    }
}
