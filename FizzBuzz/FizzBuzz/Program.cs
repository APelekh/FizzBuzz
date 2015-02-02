using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0 ){

                return "FizzBuzz";
            }
            
            else if (number % 3 == 0){

                return "Buzz";
            }

            else if (number % 5 == 0)
            {
                return "Fizz";
            }
            else
            {
                return Convert.ToString(number);
            }

        }

        public static string Buzz(int number)
        {
            if (number % 3 == 0){
                return "Buzz";
            }
            return Convert.ToString(number);
            
        }

        public static string Fizz(int number)
        {
            if (number % 5 == 0)
            {
                return "Fizz";
            }
            return Convert.ToString(number);
        }
    }
}
