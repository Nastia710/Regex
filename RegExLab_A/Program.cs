﻿using System;
using System.IO;
namespace RegExLab_A
{
    internal class Program
    {
        static String searchPatt = "a+b{2,}c+"; // modify regex here...
        static String replacePatt = "QQQ"; // ...and here
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