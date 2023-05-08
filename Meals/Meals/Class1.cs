using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meals
{
    public class Meals
    {
        //tipul mesei
        public string type { get; set; }

        //calorii masă
        public double calories { get; set; }

        //constructor pentru masă
        public Meals(string mealType, double mealCalories)
        {
            //se asigură că au foste numere date pozitive
            if (mealCalories < 1)
                throw new Exception("Numărul de calorii trebuie sa fie pozitiv.");

            type = mealType;
            calories = mealCalories;
        }
    }
}
