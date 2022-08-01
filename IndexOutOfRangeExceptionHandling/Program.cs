using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRangeExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] MyArray = new int[4];

            try 
            {
               
                MyArray[0] = 11;
                MyArray[1] = 22;
                MyArray[2] = 33;
                MyArray[3] = 44;
                MyArray[4] = 55;

                foreach (int item in MyArray)
                {
                    Console.WriteLine(item);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index range exceeded....");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Done!!!");

            Console.ReadLine();
        }
    }
}
