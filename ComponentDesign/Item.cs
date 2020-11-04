using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ComponentDesign
{
    public class Item
    {

        // name, address and phone number
        private string name, description;
        private double price;
        private int quantity;

        //private List<Household> HouseholdsRoute = new List<Household>(); // Households the carrier has on its route
        // default constructor
        public Item()
        {
            name = "";
            description = "";
            quantity = 0;
            price = 0.00;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
