using ClassesExample.Animals;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza",false);
            var bob = new Chicken("Bob",true);
            
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


            bob.Peck();

            Console.WriteLine($"{chicken.Name} and {bob.Name} are chickens......" );


            var llama = new Llama(3,"brown") 
            {
                Spits = true
            };

            llama.Dye("Blue");


            //object initializer
            var cat = new Cat()
            {
                IsFeral = true,
                Color = CatColor.Tabby,
                BestFriend = bob
            };
            
            cat.Color = CatColor.Tabby;
            cat.BestFriend = bob;

            cat.HaveASnack();

            Console.WriteLine($"the cat is {cat.Color}");
    

        }
    }
}
