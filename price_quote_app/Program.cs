using System;

namespace price_quote_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weightOfPackage = Convert.ToDouble(Console.ReadLine());
            if (weightOfPackage > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double widthOfPackage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                double heightOfPackage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                double lengthOfPackage = Convert.ToDouble(Console.ReadLine());
                if (widthOfPackage + heightOfPackage + lengthOfPackage > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double dimensionOfProduct = (widthOfPackage * heightOfPackage * lengthOfPackage);
                    double productOutcome = (dimensionOfProduct * weightOfPackage);
                    double priceQuote = (productOutcome / 100);

                    Console.WriteLine("Your estimated total for shipping this package is: $" + priceQuote);
                    Console.WriteLine("Thank you");
                }
            }
        }
    }
}
