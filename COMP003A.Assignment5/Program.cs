// Author:
// Course:
// Purpose: 


using System.Collections.Generic;
using System.Drawing;

namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator();
            Console.WriteLine("\t Triangle Section");
            PrintSeparator();

            Console.Write("Enter a Character:");
            char inputCharacter = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a positive number:");
            int Size = Convert.ToInt32(Console.ReadLine());
            IsoscelesTriangleBuilder(inputCharacter, Size);

            PrintSeparator();
            Console.WriteLine("\t Favorite Character Section");
            PrintSeparator();

         
            Console.Write("Enter Character Name:");
            string inputName = Convert.ToString(Console.ReadLine());
            Console.Write(" Enter their Birth Year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            AgeCalculator(birthYear);
           int age= AgeCalculator(birthYear);
            Console.WriteLine($"{inputName} turns {age} this year!");
            




        }
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '~'));

        }
        /// <summary>
        /// Method to a enter a string with no return 
        /// </summary>
        /// <param name="parameter">String Input</param>
        static void PrintSeparator(string parameter)
        {

        }

        /// <summary>
        /// Method that prints an Isosceles triangle with desired character.
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="Size"></param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int Size)
        {
            int i;
            int j;
            Console.WriteLine(" ");

            for (i = 1; i <= Size; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(inputCharacter);
                }
                Console.WriteLine(" ");
            }

            for (i = Size-1; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(inputCharacter);
                }
                Console.WriteLine(" ");
            }
        }
        static int AgeCalculator(int birthYear)
        {
            int age;
             age = 2023 - Convert.ToInt32(birthYear);
            return age;
        }
    }
}