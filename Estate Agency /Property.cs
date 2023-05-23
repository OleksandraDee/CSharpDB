using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.Bussines_Layer
{
    public class Property
    {
        string refNb;
        string address;
        string centralHeating;
        bool doubleGlazing;
        bool garage;
        int nbOfBedroooms;
        double price;
        string propertyType;

        public string RefNb { get => refNb; set => refNb = value; }
        public string Address { get => address; set => address = value; }
        public string CentralHeating { get => centralHeating; set => centralHeating = value; }
        public bool DoubleGlazing { get => doubleGlazing; set => doubleGlazing = value; }
        public bool Garage { get => garage; set => garage = value; }
        public int NbOfBedroooms { get => nbOfBedroooms; set => nbOfBedroooms = value; }
        public double Price { get => price; set => price = value; }
        public string PropertyType { get => propertyType; set => propertyType = value; }
    }
}
