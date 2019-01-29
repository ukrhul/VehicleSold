/************************************************************************
 * Program:     Vehicles Sold                                           *
 *                                                                      *
 * Author:      Rahul, Bhrigu Sidiora                                   *
 * Date:        March 12th, 2017                                        *
 *                                                                      *
 * Description:   This program allows the user to enter the amount of   *
 *                vehicles sold in one week, one entry per day of the   *
 *                week. Once entered, the program will then display the *
 *                minimum, maximum, and average sales for that week.    *
 *                                                                      *
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesSold
{
    class Program
    {
        static void Main(string[] args)
        {

            //DECLARATIONS
            string userInput;
            string cont;
            double averageSales = 0;
            double highestSales = 0;
            double lowestSales = 0;
            int n = 0;

            //CONSTANTS
            const double maximumVehicles = 50;
            const double minimumVehicles = 0;
            const int totalNumberOfSales = 7;

            //Declaration of array
            double[] numberOfSales = new double[totalNumberOfSales];

            //INPUT
            do
            {

                for (int dayCount = 1; dayCount < totalNumberOfSales + 1; dayCount++)
                {

                    // Prompt the user to enter the sales for the day
                    Console.Write("Please enter your sales for the day " + dayCount + ": ");
                    userInput = Console.ReadLine();


                    if (Double.TryParse(userInput, out numberOfSales[dayCount - 1]) == false)
                    {
                        // If the input is non-numeric, it will prompt for input again
                        Console.WriteLine("\n\"" + userInput + "\" is not a valid entry.");
                        Console.WriteLine("The amount must numeric. Please try again.");
                        dayCount--;
                    }
                    else if ((numberOfSales[dayCount - 1] < minimumVehicles) || (numberOfSales[dayCount - 1] > maximumVehicles))
                    {
                        // If the input is out-of-range, it will prompt for input again
                        Console.WriteLine("\n\"" + userInput + "\" is not a valid entry.");
                        Console.WriteLine("The amount must be between "+minimumVehicles+" and "+maximumVehicles+". Please try again later." );
                        dayCount--;
                    }
                }
                
                //PROCESSING

                averageSales = numberOfSales.Average();

                highestSales = numberOfSales.Max();


                //for(int i = 0; i < numberOfSales.Length; i++)
                //{
                //    if (numberOfSales[i] > numberOfSales[0])
                //        highestSales = numberOfSales[i];

                //}

                lowestSales = numberOfSales.Min();

                Console.Clear();

                //OUTPUT

                Console.WriteLine("======================================================================");
                Console.WriteLine("                \tVEHICLES SOLD                      ");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine(" | D1: " + numberOfSales[0] + " | D2: " + numberOfSales[1] + " | D3: " + numberOfSales[2] + " | D4: " + numberOfSales[3] + " | D5: " + numberOfSales[4] + " | D6: " + numberOfSales[5] + " | D7: " + numberOfSales[6]+ " |");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("\nThe average number of vehicles sold per day was " + Math.Round(averageSales, 0) + " vehicles.");
                Console.WriteLine("The highest number of vehicles was "+ highestSales);
                Console.WriteLine("The lowest number of vehicles was " + lowestSales);
                Console.WriteLine("=======================================================================");

                //Display message: "Would you like to process the number of vehicles sold for another 7 days?"
                Console.WriteLine("\nWould you like to process the number of vehicles sold for another 7 days?");

                Console.Write("Please enter 'Y' to continue or 'N' to exit: ");

                // Accept input as y and restart program or accept input as n and exit program

                cont = Console.ReadLine();

                if (cont == "y" || cont == "Y")
                {

                    Console.Clear();
                    continue;
                }

                else if (cont == "n" || cont == "N")

                {
                    break;
                }
                else
                {

                    Console.Write("\nEnter y/n or Y/N ");

                }

            } while (n == 0);

        }

    }
}


