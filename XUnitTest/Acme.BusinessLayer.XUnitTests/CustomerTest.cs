using System.ComponentModel.DataAnnotations;

namespace Acme.BusinessLayer.XUnitTests
{
    public class CustomerTest
    {

        [Fact]
        public void FirstName_GivenFirstNameNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.FirstName = null);  
        }

        [Fact]
        public void FirstName_GivenFirstNameEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.FirstName = "");
        }

        [Fact]
        public void FirstName_GivenFirstNameEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.FirstName = " ");
        }

        [Fact]
        public void LastName_GivenLastNameNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.LastName = null);
        }

        [Fact]
        public void LastName_GivenLastNameEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.LastName = "");
        }

        [Fact]
        public void LastName_GivenLastNameEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.LastName = " ");
        }

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

        [Fact]
        public void EmailAddress_GivenCorrectEmail_ReturnEmailAddress()
        {
            var customer = new Customer();
            customer.EmailAddress = "a@example.com";

            var actual = customer.EmailAddress;

            Assert.Equal("a@example.com", actual);
        }

        [Fact]
        public void EmailAddress_GivenEmailAddressNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.EmailAddress = null);
        }

        [Fact]
        public void EmailAddress_GivenEmailAddressEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.EmailAddress = "");
        }

        [Fact]
        public void EmailAddress_GivenEmailAddressEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentNullException>(() => customer.EmailAddress = " ");
        }

        [Fact]
        public void EmailAddress_GivenIncorrectEmail_ThrowArgumentException()
        {
            var customer = new Customer();

            Assert.Throws<ArgumentException>(() => customer.EmailAddress = "abc");
        }

        [Fact]
        public void EmailAddress2_GivenIncorrectEmail_ReturnFalse()
        {
            var customer = new Customer();
            customer.Email2 = "abc";
            var emailAttribute = new EmailAddressAttribute();

            var actual = emailAttribute.IsValid(customer.Email2);

            Assert.False(actual);
        }

    }
}