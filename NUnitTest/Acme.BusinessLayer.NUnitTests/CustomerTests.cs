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

        [Test]
        public void FullName_GivenFirstNameNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();
            customer.FirstName = null;
            customer.LastName = "Baggins";

            Assert.That(() => customer.FullName, Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FullName_GivenLastNameNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();
            customer.FirstName = "Frodo";
            customer.LastName = null;

            Assert.That(() => customer.FullName, Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FullName_GivenFirstNameEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();
            customer.FirstName = "";
            customer.LastName = "Baggins";

            Assert.That(() => customer.FullName, Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FullName_GivenLastNameEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();
            customer.FirstName = "Frodo";
            customer.LastName = "";

            Assert.That(() => customer.FullName, Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FullName_GivenFirstNameEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();
            customer.FirstName = " ";
            customer.LastName = "Baggins";

            Assert.That(() => customer.FullName, Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FullName_GivenLastNameEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();
            customer.FirstName = "Frodo";
            customer.LastName = " ";

            Assert.That(() => customer.FullName, Throws.Exception.TypeOf<ArgumentNullException>());
        }


    }
}