using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            try
            {
                Console.WriteLine("Enter number = ");   //right click => snippet => sorround with => try(try-catch block)
                i = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)//System Exception = base class of all the exception h 
            //exception has 2 subclasses => application exception and format exception
            {

                Console.WriteLine("Specific " + e.Message);
                //scenario 1 = recovered
                //scenario 2 = not recovered Forward exception => throw
                //secnario 3 = report current failure along with received exception
                throw new ArgumentException("argument invalid", e.Message);

                throw;//when handled the exception 
            }
            //so that we can recover from an error, 
            //purpose for catch => terminate application and resourse management
            catch (Exception e)
            {
                Console.WriteLine("General" + e.Message);
            }
            //catch (OverflowException e)
            //{
            //    Console.WriteLine("Specific",e.Message);
            //}
            catch
            {
                Console.WriteLine("General :error occured");
            }
            //when thre is try eithre catch or finally is mandatory
            finally // method level : recovering from the failure  for object level we call destructor
            {
                Console.WriteLine("inner : finally called");
            }
            
            Console.WriteLine("you entered "+i);//if entered abc it will show exception
            Console.ReadKey();                   
        }
    }
}
//entity class = has information regarding the particular data
//in  exception handling = contains information regarding the exception or the error