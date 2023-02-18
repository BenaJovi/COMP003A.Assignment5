// Author: Jovani Benavides 
// Course: Comp-003A
// Purpose: Outputs an Isosceles triangle with a desired character and length of triangle. 

namespace COMP003A.Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
                PrintSeparator("\tTriangle");

                Console.Write("Enter a Character:");
                char inputCharacter = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter a positive number:");
                int Size = Convert.ToInt32(Console.ReadLine());
                IsoscelesTriangleBuilder(inputCharacter, Size);

                PrintSeparator("\tCharacter list");


                Console.Write("\n");
                CharacterInfo(1984, "Naruto");
                CharacterInfo(1987, "Lionel Messi");
                CharacterInfo(1928, "Mickey Mouse");
                CharacterInfo(1974, "Goku");
                CharacterInfo(1978, "Kobe Bryant");
                Console.Write("\n");
        }

        /// <summary>
        /// Method to Print Line of Characters for Format
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine("".PadRight(50, '~'));

        }
        
        /// <summary>
        /// Method to Change the Title Name
        /// </summary>
        /// <param name="Section">String Input</param>
        static void PrintSeparator(string Section)
            {
                PrintSeparator();
                Console.WriteLine($"\t{Section} Section");
                PrintSeparator();
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

                for (i = Size - 1; i >= 1; i--)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(inputCharacter);
                    }
                    Console.WriteLine(" ");
                }
            }
        /// <summary>
        /// Method to that will subtract DOB minus Current Year
        /// </summary>
        /// <param name="birthYear">Input integer</param>
        static int AgeCalculator(int birthYear)
        {
            int age = (2023- birthYear);
            return age;
        }
        /// <summary>
        /// Method that outputs how old character is turnning this year.
        /// </summary>
        /// <param name="birthYear">integer input</param>
        /// <param name="name">string input</param>
        static void CharacterInfo(int birthYear, string name)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
        }

    }
}
