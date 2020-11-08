using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ComponentDesign
{
    public class Program
    {

        public static Menu menu = new Menu("menu_items.json");
        public static Menu cart = new Menu();
        public static string Name= " ";
        public static int count = 0; // TEMP
        public static double cartTotal = 0.00; // TEMP

        public static void Main(string[] args)
        {

            CreateWebHostBuilder(args).Build().Run(); 
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
