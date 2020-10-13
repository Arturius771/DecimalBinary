using System;

namespace DecimalBinary
{
    class Program
    {
        static int input;
        static string answer;
        

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int choice;

            answer = "";
            Console.WriteLine(" ");
            Console.WriteLine("Enter a number to select your choice:");
            Console.WriteLine("1. Convert to Binary");
            Console.WriteLine("2. Convert to Decimal");
            Console.WriteLine("3. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                DecimalToBinary();

                choice = 0;
            }
            if (choice == 2)
            {
                BinaryToDecimal();
                choice = 0;
            }
            if (choice == 3)
            {
                return;
            }
        }

        private static void DecimalToBinary()
        {
            //string answer = Convert.ToString(input, 2);
            int n;

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
            //https://dotnettutorials.net/lesson/binary-to-decimal-conversion-in-csharp/
            int n = 0;
            int base1 = 1;

            Console.WriteLine("Enter a binary number to convert:");
            input = int.Parse(Console.ReadLine());
            while (input > 0)
            {
                int remainder = input % 10;
                input = input / 10;
                n += remainder * base1;
                base1 = base1 * 2;
            }
            answer = n.ToString();
            Console.WriteLine("Answer: " + answer);
            Menu();
        }
    }
}
