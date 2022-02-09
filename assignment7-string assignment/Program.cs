using System;
using System.Text;
namespace String_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Robert ";
            string middleName = "Downey ";
            string lastName = "Junior ";
            StringBuilder fullName = new StringBuilder();
            fullName.Append(string.Concat(firstName.ToUpper(), middleName.ToUpper(), lastName.ToUpper()));
            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}
