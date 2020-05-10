using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Animal_Interface_Edible
{
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }


}
