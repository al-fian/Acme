namespace Acme.BusinessLayer.XUnitTests
{
    public class CustomerTest
    {
        [Fact]
        public void FullName_GivenFirstNameAndLastName_ReturnFullName()
        {
            var customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            var expected = "Baggins, Bilbo";

            var actual = customer.FullName;

            Assert.Equal(expected, actual);

        }
    }
}