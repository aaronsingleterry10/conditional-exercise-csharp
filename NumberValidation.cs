using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise
{
    class NumberValidation
    {
        public static string validation(int num)
        {
            if (num >= 1 && num <=10)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
