﻿using ClassesExample.Animals;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza");
            var bob = new Chicken("Bob");
            
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");


            bob.Peck("watermelon");

            Console.WriteLine($"{chicken.Name} and {bob.Name} are chickens......" );


        }
    }
}
