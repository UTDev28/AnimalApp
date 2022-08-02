using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Cat : Animal
    {
        //overwride the pet() and sound() methods from the animal class for cats
        public override string Pet()
        {
            return "Pet with caution";
        }

        public override string Sound()
        {
            return "Meow! Give me food!";
        }

        //constructor for dog class that implements the base class constructor
        public Cat(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {
            SkinType = paramSkin;
            FoodType = paramFood;
        }
    }
}
