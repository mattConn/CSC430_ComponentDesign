using System;
using System.IO;
using ComponentDesign;


namespace MenuTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Documents/CSI CSC Courses/CSC430 - Software Engineering/Labs/Midterm/CSC430_ComponentDesign/MenuMaker";
           
         
            Menu m = new Menu(path);
            Console.WriteLine(m.NumOfItems);

        }
    }
}
