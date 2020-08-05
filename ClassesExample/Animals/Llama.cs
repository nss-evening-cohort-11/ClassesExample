using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Llama
    {
        //auto-property
        public int Age { get; set; }

        //old and busted property
        //private int _age;
        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //    set
        //    {
        //        if (value > 100)
        //        {
        //            _age = 100;
        //        }
        //        else
        //        { 
        //        _age = value;
        //        }
        //    }
        //}

        //readonly property -- Set only in the constructor
        //public string Color {get;}

        //public property with a private setter -- can be set whenever, but only by the class that owns the property
        public string Color { get; private set; }

        public bool Spits { get; set; }

        public Llama(int age, string color)
        {
            Age = age;
            Color = color;
        }

        public void Dye(string color)
        {
            if (Age > 3)
            {
                Color = color;
            }

            DressUp("pajamas", "leopard");
        }

        private void DressUp(string clothing, string style)
        {
            Console.WriteLine($"The {Color} llama is wearing {style} {clothing}");
        }


    }
}
