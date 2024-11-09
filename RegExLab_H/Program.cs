using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExLab_H
{
    internal class Program
    {

        static String searchPatt = @"\\circle{\(([0-9]*),([0-9]*)\)(,*[0-9]*)\}"; // modify regex here...
        static String replacePatt = @"\circle{($2,$1)$3}"; // ...and here
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