using System;

namespace Day4Assignment
{
    internal class Program
    {
        public static void Question1()
        {
            Console.Write("Input an integer : ");
            int InputNum = Convert.ToInt32(Console.ReadLine());

            bool even = InputNum % 2 == 0 ? true : false;
            if (even)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public static void Question2()
        {
            Console.Write("Input an integer : ");
            int InputNum = Convert.ToInt32(Console.ReadLine());
            bool result = (InputNum % 5 == 0 && InputNum % 7 == 0);
            Console.WriteLine(result);
        }
        public static void Question3()
        {
            int height = 5;
            int width = 7;
            int area = height*width;
            Console.WriteLine($"area if rectangle is {area}");
        }
        public static void Question4()
        {
            int number = 1732;
            bool result = (number / 100) % 10 == 7;
            Console.WriteLine(result);

        }
        public static void Question5()
        {
            int number = 8;
            Console.WriteLine("The third bit of {0} is 1: {1}", number, ((number >> 3) & 1) == 1);
        }
        public static void Question6()
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool isInside = (x * x + y * y <= 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K(0,5): {2}", x, y, isInside);
        }
        public static void Question7()
        {
            uint n;
            Console.Write("Enter the unsigned integer number n:");
            bool isnInt = uint.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                //Swap bits 3,4,5 with 24,26,26
                n = ((~(7u << 24 | 7u << 3)) & n) | (((n & (7u << 3)) << 21) | ((n & (7u << 24)) >> 21));
                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }

            static void Main(string[] args)
        {
            //Q1.Write an expression that checks if given integer is odd or even
            //Question1();

            //Q2.Write a boolean expression that checks for given integer if it can be divided 
            //(without remainder) by 7 and 5 in the same time.
            //Question2();

            //Q3.Write an expression that calculates rectangle’s area by given width and height.
            //Question3();

            //Q4.Write an expression that checks for given integer if its third digit (right-to-left)
            //is 7. E.g. 1732 à true.
            //Question4();

            //Q5.Write a boolean expression for finding if the bit 3(counting from 0) of a given
            //integer is 1 or 0.
            //Question5();

            //Q6.Write an expression that checks if given point (x, y) is within a circle K(O, 5)
            //Question6();

            //Q7.Write a program that exchanges bits 3, 4 and 5 with bits 24,25 and 26 of given 32 - bit
            //unsigned integer.
            //Question7();


        }
    }
}
