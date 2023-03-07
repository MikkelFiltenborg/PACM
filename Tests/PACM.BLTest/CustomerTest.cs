using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bildo",
                LastName = "Baggins"
            };

            // Variable to hold the expected result when actually running the FullName Property
            string expected = "Baggins, Bilbo";

            //--Act
            // Actually persorming the operation we are testing
            string actual = customer.FullName;

            //--Assert
            // Verrifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }
    }
}