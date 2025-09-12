// HW1b Grade

// Your Name: Naliyah Jenkins
// Did you seek help ? If yes, specify the helper or web link here: copilot

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double homeworkweight = .20;
            const double participationweight = .15;
            const double quizweight = .15;
            const double midtermweight = .25;
            const double finalweight = .25;

            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string studentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homework?");
            double homeworkgrade = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            double participationgrade = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizgrade = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midtermgrade = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double finalgrade = Convert.ToDouble (Console.ReadLine());

            finalgrade = (homeworkgrade * homeworkweight)+
                                (participationgrade * participationweight) +
                                (quizgrade * quizweight) +
                                (midtermgrade * midtermweight)+
                                (finalgrade * finalweight);

            Console.WriteLine($"\n{firstname} {lastname} ({studentID}), your final grade is {finalgrade:F2}%");
            Console.ReadKey();




        }
    }
}




