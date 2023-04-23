using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCaloric
{
    internal class Meals
    {
        public string type { get; set; }
        public double calories { get; set; }

        public Meals(string mealType, double mealCalories)
        {
            if (mealCalories < 1)
                throw new Exception("Numărul de calorii trebuie sa fie pozitiv.");

            type = mealType;
            calories = mealCalories;
        }
    }

}
