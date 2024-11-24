using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingCSharp
{
    internal class Destructor
    {
        static void Main()
        {
          //  dpt obj = new dpt();
          //  obj = null;


            //default behavior for GC = check for required method => moved to freachable queue => rest are deleted
            //garbage collector will be called when the application is ongoing runtime 
            GC.WaitForPendingFinalizers();
            GC.Collect();


          //  obj = new dpt();
            Console.ReadKey();

        }
    }
    class dpt : IDisposable {
        public bool disposedValue;
       

        public int Id { get; set; }

        dpt()
        {  //destructor  = part of the garbage collector concept 
           //last method that will get called before the object gets deleted or destroyed = destructor
            Console.WriteLine("Destructor called");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~emp()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        //value types are general but rreference type is managed by garbage collector
        //finalizer = last metod to be called
        //it is not avalable during the code designing time 
        //object is stored in heap in generation zero , and the garbage collector is activated when there is no space 
        //generation 1 = after the generation 0 gets full, it gets moved to generation zero
        //genration zero = after all of the method survived gen 0 and gen 1



        //protected override void Finalize()
        //{
        //    //not supposed to do


        //} 
    }

}
