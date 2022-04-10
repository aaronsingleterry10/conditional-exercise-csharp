﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            UserNumber user1 = new UserNumber() { userNumber = 8 };
            UserNumber user2 = new UserNumber() { userNumber = 2 };
            UserNumber user3 = new UserNumber() { userNumber = 0 };
            UserNumber user4 = new UserNumber() { userNumber = 10 };
            UserNumber user5 = new UserNumber() { userNumber = -3 };
            UserNumber user6 = new UserNumber() { userNumber = 23 };

            var response1 = NumberValidation.validation(user1.userNumber);
            var response2 = NumberValidation.validation(user2.userNumber);
            var response3 = NumberValidation.validation(user3.userNumber);
            var response4 = NumberValidation.validation(user4.userNumber);
            var response5 = NumberValidation.validation(user5.userNumber);
            var response6 = NumberValidation.validation(user6.userNumber);

            Console.WriteLine("Response 1: " + response1);
            Console.WriteLine("Response 2: " + response2);
            Console.WriteLine("Response 3: " + response3);
            Console.WriteLine("Response 4: " + response4);
            Console.WriteLine("Response 5: " + response5);
            Console.WriteLine("Response 6: " + response6);
        }
    }
}
