using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Validation
    {
        public int IntValidation(int maxRange) 
        {
            
            int validInput;
            while (true) 
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out validInput))
                {

                    if (validInput > 0 && validInput <= maxRange)
                    {
                        return validInput;
                    }
                    else 
                    {
                        Console.WriteLine("Out of boundaries");
                    }
                    
                }
                else
                {
                    
                    Console.WriteLine("Invalid input.");
                }

            }

            
        } 
    }
}
