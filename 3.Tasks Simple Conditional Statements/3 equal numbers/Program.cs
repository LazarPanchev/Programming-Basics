﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_equal_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int nsum1 = 0;
            
            if (n1 == n2)
            { nsum1 += 2; }
            if (n2 == n3)
            { nsum1 += 3; }
            if (nsum1 > 4)
            { Console.WriteLine("yes"); }
            else
            { Console.WriteLine("no"); }
        }
    }
}
