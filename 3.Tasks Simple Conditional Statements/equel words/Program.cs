﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equel_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOne = Console.ReadLine().ToLower();
            string wordTwo = Console.ReadLine().ToLower();
            if(wordOne == wordTwo)
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }

        }
    }
}
