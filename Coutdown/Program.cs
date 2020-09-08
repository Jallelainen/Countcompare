using System;

namespace Coutdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CompereNumbers();// use method
        }

        static void CompereNumbers()
        {
            int numberOne;
            int numberTwo;

            Console.WriteLine("Please enter a number: ");
            numberOne = TextToNumber(Console.ReadLine());
            

            Console.WriteLine("Please enter a number: ");
            numberTwo = TextToNumber(Console.ReadLine());

            if(numberOne > numberTwo)
            {
                Console.WriteLine("First number was more than the Second");
            }
            else
            {
                Console.WriteLine("First number was less than the Second");
            }
        }

        static int TextToNumber(string textNumber)
        {
            int number = 0;

            int.TryParse(textNumber, out number);

            return number;
        }
    }
}
