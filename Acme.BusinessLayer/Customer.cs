namespace Acme.BusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }

        public string FullName 
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName))
                    throw new ArgumentNullException("FirstName cannot be empty");
                if (string.IsNullOrWhiteSpace(LastName))
                    throw new ArgumentNullException("LastName cannot be empty");

                return $"{LastName}, {FirstName}";
            }
        }
        public string? EmailAddress { get; set; }

    }
}