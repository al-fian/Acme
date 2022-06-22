namespace Acme.BusinessLayer.NUnitTests
{
    [TestFixture]
    public class CustomerTests
    {

        [Test]
        public void FirstName_GivenFirstNameNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.That(() => customer.FirstName = null, Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FirstName_GivenFirstNameEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.That(() => customer.FirstName = "", Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void FirstName_GivenFirstNameEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.That(() => customer.FirstName = " ", Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void LastName_GivenLastNameNull_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.That(() => customer.LastName = null, Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void LastName_GivenLastNameEmptyString_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.That(() => customer.LastName = "", Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void LastName_GivenLastNameEmptySpace_ThrowsArgumentNullException()
        {
            var customer = new Customer();

            Assert.That(() => customer.LastName = " ", Throws.Exception.TypeOf<ArgumentNullException>());
        }

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