using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Get(int input)
        {
            if (IsMultipleOf3(input) && IsMultipleOf5(input))
            {
                return "FizzBuzz";
            }

            if (IsMultipleOf3(input))
            {
                return "Fizz";
            }

            if(IsMultipleOf5(input))
            {
                return "Buzz";
            }
            
            return input.ToString();
        }

        private bool IsMultipleOf3(int input)
        {
            return input % 3 == 0;
        }

        private bool IsMultipleOf5(int input)
        {
            return input % 5 == 0;
        }
        
        private bool IsMultipleOf3And5(int input)
        {
            return IsMultipleOf3(input) && IsMultipleOf5(input);
        }
    }
}
