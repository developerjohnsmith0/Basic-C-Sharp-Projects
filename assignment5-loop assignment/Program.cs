using System;

namespace loop_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedNumber = number == 0;

            while (number >= 0)
            {
                do
                {
                    switch (number)
                    {
                        case 10:
                            Console.WriteLine("You entered 10.Try again");
                            Console.WriteLine("Guess the number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 20:
                            Console.WriteLine("You entered 20.Try again");
                            Console.WriteLine("Guess the number?");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("You neither entered 10 nor 20");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                while (!guessedNumber);
            }
            Console.Read();
        }
    }
}
