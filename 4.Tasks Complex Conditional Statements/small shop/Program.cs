﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quantity * 0.45);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quantity * 0.70);
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quantity * 1.10);
                }
            }
            else if (product =="sweets")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }
            }
            else if (product== "peanuts")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(quantity * 1.60);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.50);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }


        }
    }
}
