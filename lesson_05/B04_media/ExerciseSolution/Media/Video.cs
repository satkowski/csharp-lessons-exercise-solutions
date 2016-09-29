
namespace ExerciseSolution.Media
{
    /// <summary>
    /// A representation of a video.
    /// </summary>
    public class Video : Medium
    {
        /// <summary>
        /// The Ean code of this video.
        /// </summary>
        public string EAN
        { get; private set; }


        /// <summary>
        /// Constructor. Creates a new video with the given parameters.
        /// </summary>
        /// <param name="title">the title</param>
        /// <param name="ean">the ean code</param>
        public Video(string title, string ean) 
            : base(title)
        {
            EAN = ean;
        }


        /// <summary>
        /// Check if this video matchs with the given search query. It will use all relevant informations of this video.
        /// </summary>
        /// <param name="searchQuery">the search query</param>
        /// <returns>true if this video matchs</returns>
        public override bool Search(string searchQuery)
        {
            if(base.Search(searchQuery) || EAN.Contains(searchQuery))
                return true;
            return false;
        }
    }
}
