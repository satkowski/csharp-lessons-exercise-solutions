using ExerciseSolution.Media;
using System.Collections.Generic;

namespace ExerciseSolution.Users
{
    /// <summary>
    /// Represent a account of an user.
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// All books that this user borrowed.
        /// </summary>
        private List<Medium> borrowedMedia;

        public static readonly int MAX_MEDIA_COUNT = 10;
        /// <summary>
        /// Gives the current count of all borrowed media
        /// </summary>
        public int BorrowedCount
        {
            get
            {
                return borrowedMedia.Count;
            }
        }

        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name
        { get; private set; }
        /// <summary>
        /// The e-mail address of the user.
        /// </summary>
        public string EMail
        { get; private set; }
        /// <summary>
        /// The id of this account.
        /// </summary>
        public long ID
        { get; private set; }
        /// <summary>
        /// The accumulated fee that this user need to pay.
        /// </summary>
        public float FeeToPay
        { get; private set; }


        /// <summary>
        /// Constructor. Creates a new useraccount with the given parameters.
        /// </summary>
        /// <param name="name">the name of the user</param>
        /// <param name="email">the email of the user</param>
        /// <param name="id">the id of this account</param>
        public UserAccount(string name, string email, long id)
        {
            borrowedMedia = new List<Medium>();
            FeeToPay = 0;
            Name = name;
            EMail = email;
            ID = id;
        }

        /// <summary>
        /// Method for borrowing media. Adds the media to the borrowedMedia-list if limit is not reached
        /// </summary>
        /// <param name="m">the media to be borrowed</param>
        /// <returns>true if the limit is not reached, false if it is reached </returns>
        public bool borrow(Medium m)
        {
            if (BorrowedCount >= MAX_MEDIA_COUNT)
                return false;
            borrowedMedia.Add(m);
            m.borrow(this);
            return true;
        }

        /// <summary>
        /// Returns the medium. Updates the FeeToPay
        /// </summary>
        /// <param name="m">the medium to be returned</param>
        /// <returns>true if m is a borrowed medium of this account</returns>
        public bool returnMedium(Medium m)
        {
            if (borrowedMedia.Remove(m))
            {
                this.FeeToPay+= m.returnMe();
                return true;
            }
            return false;
        }
    }
}
