using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComponentDesign.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public async Task OnPostCartAppend(string myVar)
        {
            Program.count++;
            var addItem = Program.menu.findItem(myVar);
            Program.cart.insertItem(addItem);
            Program.cartTotal += addItem.Price;
        }


        public async Task OnPostCartRemove(string myVar)
        {
            Program.count--;
            var addItem = Program.menu.findItem(myVar);
            Program.cart.removeItem(addItem);
            Program.cartTotal -= addItem.Price;
            if (Program.cartTotal < 0)
                Program.cartTotal = 0;
        }

    }
}
