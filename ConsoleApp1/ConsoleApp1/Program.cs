using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string totalWeightAsString, distanceAsString, hazardousMaterialsAsString;
            double totalWeight, distance; //don't need distance as string anymore 
            bool containsHazardous;

            Console.WriteLine("What is the weight of your shipment? >>");
            totalWeightAsString = Console.ReadLine();
            totalWeight = Convert.ToDouble(totalWeightAsString);

            Console.WriteLine("what is the distance of your shipment? >>");
            distance = Convert.ToDouble(Console.ReadLine()); //use this way to convert and readline

            Console.WriteLine("Does your shipment contain hazardous material? (Yes/No) >>");
            hazardousMaterialsAsString = Console.ReadLine();

            double quote = distance * .55 + totalWeight * .73;
            double hazardousCost = 0;


            if (hazardousMaterialsAsString == "Yes")
            {
                //this is the only place in our code that we know for sure that the user typed "yes" for their shipment containing hazard material
                containsHazardous = true;
                hazardousCost = .15 * totalWeight;
            }
            else if (hazardousMaterialsAsString == "no")
            {
                containsHazardous = false;
                hazardousCost = 0;
            }
            else
            {
                Console.WriteLine("Invalid input for hazardous material, please contact for help.");
                Environment.Exit(-1);
            }

            //adding more variable for the equation
            double netTotal = quote + hazardousCost;
            double discount = 0;

            if (distance < 150 && totalWeight > 500)
            {
                discount = netTotal * .10;
            }

            double total = netTotal + discount;
            Console.ForegroundColor = color

            Console.WriteLine($"Hazardous Cost:\t{hazardousCost.ToString("C2")}");
            Console.WriteLine($"Discount :\t{discount.ToString("C2")}");
            Console.WriteLine($"Total:\t\t{total.ToString("C2")}");
            Console.ReadLine();
        }
    }
}
