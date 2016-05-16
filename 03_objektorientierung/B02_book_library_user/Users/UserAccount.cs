using ExerciseSolution.Media;

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
        private Medium[] borrowedMedia;

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
        /// Constructor. Creates a new useraccount with the given parameters.
        /// </summary>
        /// <param name="name">the name of the user</param>
        /// <param name="email">the email of the user</param>
        /// <param name="id">the id of this account</param>
        public UserAccount(string name, string email, long id)
        {
            borrowedMedia = new Book[5];
            Name = name;
            EMail = email;
            ID = id;
        }
    }
}
