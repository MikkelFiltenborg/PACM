namespace PACM.BL
{
    public class Customer
    {

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        // Auto-implemented property - when you don't need to check on set and get.
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        // Private backing field for the public property, LastName.
        // Use this when you want to validate or authenticate.
        private string _lastName;
        public string LastName 
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

    }
}