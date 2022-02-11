using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College.");
            Console.WriteLine("Student Daily Report:");
            Console.WriteLine("What course are you in?");
            string appliedCourseOfStudent = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool isAnyHelpNeeded = bool.Parse(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics.");
            string ecperienceOfStudent = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string feedbackOfStudent = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int studyHoursOfStudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
        }
    }
}
