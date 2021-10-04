using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCM.BL
{
   public class Address
    {
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressProvince { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }

        public bool ValidateAddress()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(AddressPostalCode)) isValid = false;
            return isValid;
        }

    }
}

