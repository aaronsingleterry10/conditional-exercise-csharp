using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise
{
    class SpeedLimit
    {
        public static string speedCamera(int speedLimit, int carSpeed)
        {
            int howMuchOverLimit = (carSpeed - speedLimit);
            int demerit = (howMuchOverLimit / 5);
            if (howMuchOverLimit <= 0)
            {
                return "Ok";
            }
            else if (howMuchOverLimit > 60)
            {
                return "License Suspended";
            }
            else
            {
                return "You have " + demerit + " demerits.";
            }
        }
    }
}
