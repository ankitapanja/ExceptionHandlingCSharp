using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCSharp
{
    internal class EH_practice
    {
        static void Main(string[] args)
        {
            var x = 0;
            var y = 0;

            int result;

            try
            {
                Console.WriteLine("Enter 1st number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2nd number: ");
                y = Convert.ToInt32(Console.ReadLine());


                result = x / y;


                Console.WriteLine("result:  " + result);
            }
            catch (FormatException e)//for  format exceptions
            {
                Console.WriteLine("enter only numbers");
            }
            catch (DivideByZeroException e) //specific exception handling
            {
                Console.WriteLine("you cannot divide by zero");
            }
            catch (Exception e) //casual exception handling
            { Console.WriteLine("something wrong"); }
            finally // this block will be compiled regardless of there being an exception or not
            {
                Console.WriteLine("thank you for visiting");
            }
        }
    }
}
