using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace İkiSayiTopla
{
    class Program
    {
        static void Main(string[] args)
        {
            // We will make the program that adds the two numbers entered from the keyboard... But we will check it with the Try Catch Block...
            int number1 = 0, number2 = 0;

        again: // Will come back here again if an error is encountered...
            Console.WriteLine("Enter the numbers:");
            try //Checking for errors... If it works correctly, the codes in the try block will be processed...
            {
                number1 = Convert.ToInt16(Console.ReadLine());
                number2 = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception) // If there is an error, the parts in the Catch block will work...
            {
                Console.Clear();
                Console.WriteLine("Error... It is useful to re-enter the values... ");
                goto again;
            }

            Console.WriteLine("Sum = " + Convert.ToString(number1 + number2));
            Console.ReadLine();
        }
    }
}
