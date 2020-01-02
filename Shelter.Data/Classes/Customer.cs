using System;
namespace Shelter.Data.Classes
{
    public class Customer
    {
        /// <summary>
        /// ID prop. Can't be empty
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// First name Prop. Can't be empty
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Last name Prop. Can't be empty
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Email Prop. Can't be empty
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password Prop. Can't be empty
        /// </summary>
        public string Password { get; set; }

    }
}
