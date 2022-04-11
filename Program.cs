using System;
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
            //Console.Write("Type a number between 1-10: ");
            //int userInput1 = Int32.Parse(Console.ReadLine());
            //UserNumber user1 = new UserNumber() { userNumber = userInput1 };
            UserNumber user2 = new UserNumber() { userNumber = 2 };
            UserNumber user3 = new UserNumber() { userNumber = 0 };
            UserNumber user4 = new UserNumber() { userNumber = 10 };
            UserNumber user5 = new UserNumber() { userNumber = -3 };
            UserNumber user6 = new UserNumber() { userNumber = 23 };

            //var response1 = NumberValidation.validation(user1.userNumber);
            var response2 = NumberValidation.validation(user2.userNumber);
            var response3 = NumberValidation.validation(user3.userNumber);
            var response4 = NumberValidation.validation(user4.userNumber);
            var response5 = NumberValidation.validation(user5.userNumber);
            var response6 = NumberValidation.validation(user6.userNumber);

            //Console.WriteLine("Response 1: " + response1);
            //Console.WriteLine("Response 2: " + response2);
            //Console.WriteLine("Response 3: " + response3);
            //Console.WriteLine("Response 4: " + response4);
            //Console.WriteLine("Response 5: " + response5);
            //Console.WriteLine("Response 6: " + response6);

            //Console.WriteLine("Enter two different numbers");
            //Console.Write("First number: ");
            //var num1 = Int32.Parse(Console.ReadLine());
            //Console.Write("Second number: ");
            //var num2 = Int32.Parse(Console.ReadLine());

            //var maxNumber1 = MaxNumber.maxNumber(num1, num2);
            var maxNumber2 = MaxNumber.maxNumber(user3.userNumber, user4.userNumber);
            var maxNumber3 = MaxNumber.maxNumber(user5.userNumber, user6.userNumber);

            //Console.WriteLine("The winner is: " + maxNumber1);
            //Console.WriteLine("The winner is: " + maxNumber2);
            //Console.WriteLine("The winner is: " + maxNumber3);
            //Console.Write("Enter image width: ");
            //var imgWidth = Int32.Parse(Console.ReadLine());
            //Console.Write("Enter image height: ");
            //var imgHeight = Int32.Parse(Console.ReadLine());
            //var img1 = new ImageDimension() { width = imgWidth, height = imgHeight };
            var img2 = new ImageDimension() { width = 210, height = 100 };
            var img3 = new ImageDimension() { width = 500, height = 500 };

            //var imgOrientation1 = img1.pageOrientation();
            var imgOrientation2 = img2.pageOrientation();
            var imgOrientation3 = img3.pageOrientation();

            //Console.WriteLine(imgOrientation1);
            //Console.WriteLine(imgOrientation2);
            //Console.WriteLine(imgOrientation3);
            Console.Write("Enter speed limit: ");
            int speedLimitSign = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the speed of the car: ");
            var speed = Int32.Parse(Console.ReadLine());
            Car mustang = new Car() { carSpeed = 45 };
            Car challenger = new Car() { carSpeed = 50 };
            Car charger = new Car() { carSpeed = 55 };
            Car viper = new Car() { carSpeed = 60 };
            Car corvette = new Car() { carSpeed = 75 };
            Car focus = new Car() { carSpeed = 90 };
            Car neon = new Car() { carSpeed = 107 };
            Car jeep = new Car() { carSpeed = 112 };

            string speedCheck = SpeedLimit.speedCamera(speedLimitSign, speed);
            Console.WriteLine(speedCheck);
            string speedCheck2 = SpeedLimit.speedCamera(speedLimitSign, challenger.carSpeed);
            //Console.WriteLine(speedCheck2);
            string speedCheck3 = SpeedLimit.speedCamera(speedLimitSign, charger.carSpeed);
            //Console.WriteLine(speedCheck3);
            string speedCheck4 = SpeedLimit.speedCamera(speedLimitSign, corvette.carSpeed);
            //Console.WriteLine(speedCheck4);
            string speedCheck5 = SpeedLimit.speedCamera(speedLimitSign, neon.carSpeed);
            string speedCheck6 = SpeedLimit.speedCamera(speedLimitSign, jeep.carSpeed);
            //Console.WriteLine(speedCheck5);
            //Console.WriteLine(speedCheck6);

            //Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            //Console.WriteLine("you typed: " + input);

        }
    }
}
