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

        public async Task OnPostItemHandler(string myVar)
        {
            Program.count++;
            Program.cart.insertItem(Program.menu.findItem(myVar));

        }

    }
}
