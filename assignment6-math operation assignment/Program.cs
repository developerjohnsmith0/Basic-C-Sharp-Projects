using System;

namespace Math_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply it by 50");
            int numberToMultiply = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberToMultiply * 50);

            Console.WriteLine("Enter a number to add it by 25");
            int numberToAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberToAdd + 25);

            Console.WriteLine("Enter a number to divide it by 12.5");
            float numberToDivide = float.Parse(Console.ReadLine());
            Console.WriteLine(numberToDivide / 12.5);

            Console.WriteLine("Enter a number to check whether it is greater than 50");
            int isNumberGreater = Convert.ToInt32(Console.ReadLine());
            bool isNumberGreaterBool = isNumberGreater > 50;
            Console.WriteLine(isNumberGreaterBool);

            Console.WriteLine("Enter a number to check its remainder");
            int remainderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(remainderNumber % 7);
        }
    }
}
