using System;

namespace Coutdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
                
            
            // use method
            
            //CompereNumbers(); 

            Loops();

            //SymbolsEx();

            //NumbersEx();

        }

        static void Loops()
        {
            // init    compare increment
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            /*
             1:init will only run once
             2:compare will check every loop (even the first time before the code block as
             3:run code block 
             4:incriment after code block has been run
             5:compare if its still true = run step 3 once again
             */

            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Write("what's your age?\n Age:  ");
                //  \n = new row
                //int age = int.Parse(Console.ReadLine());
                int age = Convert.ToInt32(Console.ReadLine());

                /*
                 if (age < 0)
                 {
                    keepLooping = false;
                 }
                */

                keepLooping = false;

                if (age >= 18)
                {
                    Console.WriteLine("Beer time! Let's go nuttin' mental");
                }

                else if (age > 2)
                {
                    Console.WriteLine("No beer for you. Take a soda and go away you litle rascal");
                }

                else if (age > 0)
                {
                    Console.WriteLine("Baby formula for you.");
                }

                else
                {
                    Console.WriteLine("Must type in an age greater than 0");
                    keepLooping = true;
                }
              
            }
        }

        static void SymbolsEx()
        {
         
            char aChar = 'a'; // a symbol = processed as a number (ASCII table)
            string aString = "abc"; //string of symbols


            // char + int = int + int / char + string = text only
            Console.WriteLine(aChar + "just a symbol and some text added together");
            Console.WriteLine(aChar + 1); //98
            Console.WriteLine(aString + 1); //abc1

            // aString.Length = how long is the string
            for(int index = 0; index < aString.Length; index++)
            {
                /*
                 array [index] picks out single symbols from aString
                 aString "abc"
                 index "012"
                 */
                Console.WriteLine(aString[index]);
            }

        }


        static void NumbersEx()
        {
  
            byte aByte = byte.MinValue; // 0 - 255
            short aShort = short.MaxValue; // -32k - +32k
            int aInt = int.MinValue; //-2.1 billion - +2.1 billion
            long aLong = long.MaxValue; // 9.2 quintillion -||-

            float aFloat = float.MaxValue; // 3,4028235E+38 Power of 38
            double aDouble = double.MaxValue; // Power of 308
            decimal aDecimal = decimal.MaxValue; // 79228162514264337593543950335

            //byte/short/int/long = whole number math
            Console.WriteLine(1/3); // = 0

            //float/double/decimal = decimal number math
            Console.WriteLine(1.0/3.0); // = 0.3333333
        }





        // declare methods
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
