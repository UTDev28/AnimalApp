using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Dog : Animal
    {
        //overwride the pet() and sound() methods from the animal class for dogs
        public override string Pet()
        {
            return "Dogs love tummy rubs!";
        }

        public override string Sound()
        {
            return "Woof! Woof!";
        }

        //constructor for dog class that implements the base class constructor
        public Dog(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {
            SkinType = paramSkin;
            FoodType = paramFood;   
        }
    }
}
