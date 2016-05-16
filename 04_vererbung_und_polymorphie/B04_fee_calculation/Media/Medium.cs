using ExerciseSolution.Users;
using System;

namespace ExerciseSolution.Media
{
    /// <summary>
    /// Abstract. Represent all kind of media.
    /// </summary>
    public abstract class Medium
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
        /// After how many days need this medium to be turned back before it will charged with fees.
        /// </summary>
        public int Period
        { get; protected set; }
        /// <summary>
        /// The amount of fees that will be paid per day after this medium rechead their max time of rental.
        /// </summary>
        public float FeePerDay
        { get; protected set; }
        /// <summary>
        /// The date when this medium should be returned.
        /// </summary>
        public DateTime ReturnDate
        { get; protected set; }


        /// <summary>
        /// Constructor. Creates a new medium with the given parameters.
        /// </summary>
        /// <param name="title">the title</param>
        /// <param name="period">the period time</param>
        /// <param name="feePerDay">the fee paid per day</param>
        public Medium(string title, int period, float feePerDay)
        {
            Title = title;
            Period = period;
            FeePerDay = feePerDay;
            ReturnDate = DateTime.Now;
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

        /// <summary>
        /// Calculates the fee that is need to be paid.
        /// </summary>
        /// <returns>the fee</returns>
        public float CalculateFee()
        {
            DateTime yet = DateTime.Now;
            // Today is earlier or on the same day as ReturnDate.
            if(ReturnDate.CompareTo(yet) <= 0)
                return 0;
            // The difference in internal time save property (it represend 100 nano seconds).
            long ticksDifference = yet.Ticks - ReturnDate.Ticks;
            DateTime timeDifference = new DateTime(ticksDifference);

            // Calculate the total fee to pay.
            return FeePerDay * (timeDifference.Day + 1);
        }
    }
}
