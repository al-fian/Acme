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
    }
}