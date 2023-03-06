using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // Class for validating user input
    internal class Validation
    {
        // Method to validate integer input within a given range
        public int IntValidation(string message, int minRange, int maxRange)
        {

            int validInput;
            // Loop until a valid input is entered
            while (true)
            {
                // Prompt user for input and read from console
                Console.WriteLine(message);
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out validInput))
                {
                 
                    if (validInput > minRange && validInput <= maxRange)
                    {
                        // Return valid input
                        return validInput;
                    }
                    // Display error message if input is out of range
                    else
                    {
                        Console.WriteLine("Out of boundaries");
                    }

                }
                // Display error message if input cannot be converted to an integer
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}
