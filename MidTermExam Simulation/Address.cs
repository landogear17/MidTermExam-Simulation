using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam_Simulation
{
    public class Address
    {
        private int streetNumber;
        private string street;
        private string postalCode;
        private string city;
        private string province;

        public Address()
        {
        }

        public Address(int streetNumber, string street, string postalCode, string city, string province)
        {
            this.streetNumber = streetNumber;
            this.street = street;
            this.postalCode = postalCode;
            this.city = city;
            this.province = province;
        }

        public int StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string Street { get => street; set => street = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public string Province { get => province; set => province = value; }
    }
}
