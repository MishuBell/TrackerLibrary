namespace TrackerLibrary
{
    /// <summary>
    /// Represents one Person, including their first name, last name, email address, and cell phone number.
    /// </summary>
    public class PersonModel
    {
        public int Id { get; set; }

        /// <summary>
        /// The first name of the Person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the Person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the Person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The cell phone number of the Person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        
    }
}
