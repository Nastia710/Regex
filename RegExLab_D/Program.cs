using System;
using System.IO;
namespace RegExLab_D
{
    internal class Program
    {

        static String searchPatt = "\\$v_{([a-zA-Z0-9]*)}\\$"; // modify regex here...
        static String replacePatt = "v[$1]"; // ...and here
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            while (str != null)
            {
                String newStr = System.Text.RegularExpressions.Regex.Replace(str, searchPatt, replacePatt);
                Console.WriteLine(newStr);
                str = Console.ReadLine();
            }
        }

        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }*/
    }
}