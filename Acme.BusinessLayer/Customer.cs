namespace Acme.BusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public string? FullName => $"{LastName}, {FirstName}";
        public string? EmailAddress { get; set; }

    }
}