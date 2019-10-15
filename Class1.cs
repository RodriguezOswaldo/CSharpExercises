using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises
{
    public class Exercises
    {
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
        public static void Exercise1()
        {
            Console.Write("Enter a number between 1 to 10:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if(number >= 1 && number <= 10 )
                Console.WriteLine("Valid number!");
            else
            {
                Console.WriteLine("invalid number");
            }
        }

        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        public static void printMaximum()
        {
            Console.Write("Please type 2 numbers separated by a space");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please type 2 numbers separated by a space");
            var number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
                Console.WriteLine(number1);
            else
            {
                Console.WriteLine(number2);
            }
        }

        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        public static void tellTheImage()
        {
            Console.Write("type image width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("type image height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            var orientation =  height < width ?
                ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        #region checkSpeedLimit
        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </summary>
        static public void speedLimitCheck()
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }

        #endregion


    }
}
