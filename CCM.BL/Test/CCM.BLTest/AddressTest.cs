using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CCM.BL;

namespace CCM.BLTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void AddressStreet()
        {
            Address address = new Address();
            address.AddressStreet = "omega";
            string expected = "omega";
            string actuel = address.AddressStreet;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void AddressCity()
        {
            Address address = new Address();
            address.AddressCity = "Brossard";
            string expected = "Brossard";
            string actuel = address.AddressCity;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void AddressProvance()
        {
            Address address = new Address();
            address.AddressProvince = "Quebec";
            string expected = "Quebec";
            string actuel = address.AddressProvince;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void AddressPostalCode()
        {
            Address address = new Address();
            address.AddressPostalCode = "j8y";
            string expected = "j8y";
            string actuel = address.AddressPostalCode;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void AddressCountry()
        {
            Address address = new Address();
            address.AddressCountry = "Canada";
            string expected = "Canada";
            string actuel = address.AddressCountry;
            Assert.AreEqual(expected, actuel);
        }
        [TestMethod]
        public void ValidValidation()
        {
            Address address = new Address
            {
                AddressPostalCode = "j8y"
            };
            var expected = true;
            var actuel = address.ValidateAddress(); 
            Assert.AreEqual(expected, actuel);

        }
    }
}
