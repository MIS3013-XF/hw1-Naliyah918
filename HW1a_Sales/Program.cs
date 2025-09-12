// HW1a Sales Total

// Your Name: Naliyah Jenkins
// Did you seek help ? If yes, specify the helper or web link here: Copilot

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double salestaxrate = .085;
            string productname;
            int productquantity;
            double productprice;
            double subtotal, salestax, total; 

            Console.WriteLine("What is the product name of the item you are purchasing?");
            productname = Console.ReadLine();

            Console.WriteLine("How much are you needing of said product?");
            productquantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your desired price?");
            productprice = Convert.ToDouble(Console.ReadLine());

            subtotal = productquantity * productprice;
            salestax = subtotal * salestaxrate;
            total = subtotal + salestax;

            Console.WriteLine($"Your subtotal for your bill is ${subtotal:F2}");
            Console.WriteLine($"Your sales tax for your bill is Sales Tax (8.5%): ${salestax:F2}");
            Console.WriteLine($"Your total for your bill is ${total:F2}");


        }
    }
}

