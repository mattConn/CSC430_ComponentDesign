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
        public static string test = "HELLO WORLD";
        public void OnGet()
        {

        }
    }
}
