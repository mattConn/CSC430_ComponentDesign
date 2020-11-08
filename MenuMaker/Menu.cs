﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ComponentDesign
{
    public class Menu
    {

        // name, address and phone number
        private List<Item> MenuList; // Households the carrier has on its route
        private int numOfItems;

        // default constructor
        public Menu()
        {
            MenuList = new List<Item>();
            numOfItems = 0;
        }
        

        // json parser constructor
        public Menu(string path)
        {

                string jsonParse = File.ReadAllText(path);
                MenuList = JsonConvert.DeserializeObject<List<Item>>(jsonParse);
                numOfItems = this.MenuList.Count();
                
          
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

        public void insertItem(Item newItem)
        {
            MenuList.Add(newItem);
            numOfItems++;
        }

        public void removeItem(Item item)
        {
            MenuList.Remove(item);
            numOfItems--;
        }

        public Item findItem(string name)
        {
            return MenuList.Find(x => x.Name == name);
        }


    }
}
