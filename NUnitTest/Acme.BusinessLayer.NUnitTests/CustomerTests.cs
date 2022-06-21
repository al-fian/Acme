namespace Acme.BusinessLayer.NUnitTests
{
    [TestFixture]
    public class CustomerTests
    {

        [Test]
        public void FullName_GivenFirstNameAndLastName_ReturnFullName()
        {
            var customer = new Customer();
            customer.FirstName = "Frodo";
            customer.LastName = "Baggins";
            var expected = "Baggins, Frodo";

            var actual = customer.FullName;

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}