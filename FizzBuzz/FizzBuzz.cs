using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
   public class FizzBuzz
    {
        public string Get(int num)
        {
            if (num == 3)
            {
                return "Fizz";
            }

            return num.ToString();
        }
    }
}
