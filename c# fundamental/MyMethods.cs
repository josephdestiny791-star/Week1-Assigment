using System;
using System.Collections.Generic;
using System.Text;

namespace c__fundamental
{
    public class MyMethods
    {
        public static bool IsEven(int number)
        {
            if (number > 0 && number < 21)//0 - 20
            {
                if (number % 2 == 0)
                {
                    //even number   
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                return false;
            }

        }

        public static bool IsOdd(int number)
        {
            bool checkIsEven = IsEven(number);

            if (checkIsEven == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        //for rectangle
        static double CalculateArea(double lenght, double width)
        {
            return lenght * width;
        }

        //for circle
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
