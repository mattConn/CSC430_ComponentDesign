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

        //regular constructor
        public Item(string _name, string _description, double _price, int _quantity)
        {
            name = _name;
            description = _description;
            quantity = _quantity;
            price = _price;
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
        public void print()
        {
            System.Console.WriteLine("Price: " + price + ", Description: " + description + ", Price: " + price + ", Quantity: " + quantity);
        }

    }


}
