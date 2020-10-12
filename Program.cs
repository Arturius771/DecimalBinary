using System;

namespace DecimalBinary
{
    class Program
    {
        static int input;
        static int n;
        static string answer;
        

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int prompt;
            answer = "";
            Console.WriteLine(" ");
            Console.WriteLine("Enter a number to select your choice:");
            Console.WriteLine("1. Convert to Binary");
            Console.WriteLine("2. Convert to Decimal");
            Console.WriteLine("3. Quit");
            prompt = int.Parse(Console.ReadLine());
            if (prompt == 1)
            {
                DecimalToBinary();
                prompt = 0;
            }
            if (prompt == 2)
            {
                BinaryToDecimal();
                prompt = 0;
            }
            if (prompt == 3)
            {
                return;
            }
        }

        private static void DecimalToBinary()
        {
            //string answer = Convert.ToString(input, 2);
            
            Console.WriteLine("Enter a decimal number to convert:");
            input = int.Parse(Console.ReadLine());
            while(input != 0)
            {
                n = input % 2;
                input /= 2;
                answer = Convert.ToString(n) + answer;                
            }
            Console.WriteLine("Answer: " + answer);
            Menu();
        }
        private static void BinaryToDecimal()
        {
            //Convert.ToInt32("1001101", 2).ToString();

            Console.WriteLine("Enter a binary number to convert:");
            answer = Convert.ToInt32(Console.ReadLine(), 2).ToString();

            Console.WriteLine("Answer: " + answer);
            Menu();
        }
    }
}
