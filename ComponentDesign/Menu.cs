using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ComponentDesign
{
    public class Menu
    {

        // name, address and phone number
        private List<Item> MenuList; // Households the carrier has on its route
        private int numOfItems;

        public Menu()
        {
            MenuList = new List<Item>();
            numOfItems = 0;
        }

        public int NumOfItems
        {
            get { return numOfItems; }
            set { numOfItems = value; }
        }



        //return menu items
        public List<Item> getMenu()
        {

            if (MenuList.Count > 0)
                return MenuList;

            return null;


        }

    }
}
