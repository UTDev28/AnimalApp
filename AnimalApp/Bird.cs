using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Bird : Animal 
    {
        //overwride the pet() and sound() methods from the animal class for birds
        public override string Pet()
        {
            return "Only if you can catch it!";
        }

        public override string Sound()
        {
            return "Tweet Tweet";
        }

        //constructor for dog class that implements the base class constructor
        public Bird(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {
            SkinType = paramSkin;
            FoodType = paramFood;
        }

    }
}
