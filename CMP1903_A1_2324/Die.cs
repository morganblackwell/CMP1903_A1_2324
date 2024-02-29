using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        // Private variable
        private int _currentValue;

        // Property
        public int currentValue
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }

        private static Random _random = new Random(); // Using static stops duplicate values

        // Method
        // Returns a random integer between 1 and 6
        public int Roll()
        {
            currentValue = _random.Next(1, 7); // 1 to 7 where 7 is not included
            return currentValue;
        }
    }
}
