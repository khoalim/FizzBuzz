using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
   public class FizzBuzz
    {
        public string Get(int num)
        {

            if (IsMultipleOf3AndIsMultipleOf5(num))
            {
                return "FizzBuzz";
            }
            if (IsMultipleOf3(num))
            {
                return "Fizz";
            }

            if (IsMultipleOf5(num))
            {
                return "Buzz";
            }


            return num.ToString();
        }

        private bool IsMultipleOf3(int numberToCheck)
        {
            return numberToCheck % 3 == 0;
        }

        private bool IsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 5 == 0;
        }

        private bool IsMultipleOf3AndIsMultipleOf5(int numberToCheck)
        {
            return numberToCheck % 3 == 0 && numberToCheck % 5 == 0;
        }
    }
}
