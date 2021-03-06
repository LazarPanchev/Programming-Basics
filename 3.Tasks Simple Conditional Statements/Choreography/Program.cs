﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111111111
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            var stepsPerDay = steps / days;
            var percentPerDay = Math.Ceiling((stepsPerDay / steps) * 100);
            var stepsPerDancer = percentPerDay / dancers;

            if (percentPerDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", stepsPerDancer);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepsPerDancer);
            }

        }
    }
}
