namespace Acme.BusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; }

        private string? _firstName;
        public string? FirstName 
        { 
            get => _firstName; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("FirstName cannot be empty");

                _firstName = value;
            } 
        } 

        private string? _lastName;   
        public string? LastName 
        { 
            get => _lastName; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("LastName cannot be empty");
                
                _lastName = value;  
            }
        }

        public string FullName => $"{LastName}, {FirstName}";
        public string? EmailAddress { get; set; }

    }
}