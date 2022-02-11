using System;

namespace income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int person1HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1WorkingHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int person2HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2WorkingHours = Convert.ToInt32(Console.ReadLine());
            int person1AnnualSalary = person1HourlyRate * 52 * person1WorkingHours;
            int person2AnnualSalary = person2HourlyRate * 52 * person2WorkingHours;
            Console.WriteLine("Annual Salary of person 1:");
            Console.WriteLine(person1AnnualSalary);
            Console.WriteLine("Annual Salary of person 2:");
            Console.WriteLine(person2AnnualSalary);
            Console.WriteLine("Person 1 makes more money than Person 2:");
            bool person1IsRicher = (person1AnnualSalary > person2AnnualSalary);
            Console.WriteLine(Convert.ToString(person1IsRicher));
        }
    }
}
