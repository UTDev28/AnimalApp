using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    abstract class Animal 
    {
        private string _skinType;
        private string _foodType;

        //read/write access to skinType and foodType variables
        public string SkinType
        {
            get { return _skinType; }
            set { _skinType = value; }
        }

        public string FoodType
        {
            set { _foodType = value; }
            get { return _foodType; }
        }

        //create default output methods 
        public string Eat()
        {
            return "Needs food to survive";
        }

        public string Move()
        {
            return "Can move around";
        }

        //abstract methods
        public abstract string Pet();

        public virtual string Sound()
        {
            return "Makes a typical animal noise";
        }
        
        //parameterized constructor for the animal class
        public Animal (string paramFood, string paramSkin)
        {
            SkinType = paramSkin;
            FoodType = paramFood;
        }

        
    }
}
