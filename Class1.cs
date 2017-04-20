﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPlusUnitTest
{
    class FizzBuzzPlus
    {
        public static string GetFizzBuzzPlus(int x)
        {
            string output = "";

            if (x % 3 == 0 || x.ToString().IndexOf('3') != -1)
                output += "Fizz";
            if (x % 5 == 0 || x.ToString().IndexOf('5') != -1)
                output += "Buzz";
            if (output == "")
                output = x.ToString();
            return output;

            //if (x % 15 == 0 || (x.ToString().IndexOf('3') != -1 && x.ToString().IndexOf('5') != -1))
            //    return "FizzBuzz";
            //else if (x % 3 == 0 || x.ToString().IndexOf('3') != -1)
            //    return "Fizz";
            //else if (x % 5 == 0 || x.ToString().IndexOf('5') != -1)
            //    return "Buzz";
            //else
            //    return x.ToString();
        }
    }
}
