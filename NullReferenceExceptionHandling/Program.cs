using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = null;
                Console.WriteLine(a.Length);
            }


            //catch(NullReferenceException ex)
            //{
            //    Console.WriteLine("Null value cannot have length");
            //}


            catch(Exception e)                             //exception is the parent class of all exception if we don't know the name of exception we can also use this class
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
         
        }
    }
}
