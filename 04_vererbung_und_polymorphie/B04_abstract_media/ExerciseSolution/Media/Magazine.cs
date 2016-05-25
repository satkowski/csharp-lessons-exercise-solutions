
namespace ExerciseSolution.Media
{
    /// <summary>
    /// A representation of a magazine.
    /// </summary>
    public class Magazine : Medium
    {
        /// <summary>
        /// The ISSN number of this magazine.
        /// </summary>
        public string ISSN
        { get; private set; }
        /// <summary>
        /// The issuing number in a year of this magazine.
        /// </summary>
        public int Issuing
        { get; private set; }
        /// <summary>
        /// The release year of this magazine.
        /// </summary>
        public int Year
        { get; private set; }


        /// <summary>
        /// Constructor. Creates a new magazine with the given parameters
        /// </summary>
        /// <param name="title">the title</param>
        /// <param name="issn">the issn number</param>
        /// <param name="issuing">the issuing number</param>
        /// <param name="year">the year</param>
        public Magazine(string title, string issn, int issuing, int year) 
            : base(title)
        {
            this.ISSN = issn;
            this.Issuing = issuing;
            this.Year = year;
        }


        /// <summary>
        /// Check if this magazine matchs with the given search query. It will use all relevant informations of this magazine.
        /// </summary>
        /// <param name="searchQuery">the search query</param>
        /// <returns>true if this magazine matchs</returns>
        public override bool Search(string searchQuery)
        {
            if(base.Search(searchQuery) || ISSN.Contains(searchQuery))
                return true;
            return false;
        }
    }
}
