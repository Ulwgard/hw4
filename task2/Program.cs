using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

                if (x >= 0 && x <= 14)
                    Console.WriteLine("0...14");
   
                if (x >= 15 && x <= 35)
                    Console.WriteLine("15...35");
          
                if (x >= 36 && x <= 50)
                    Console.WriteLine("36...50");
          
                if (x >= 50 && x <= 100)
                    Console.WriteLine("50...100");
             
                if (x<0 && x > 100)
                    Console.WriteLine("incorrect number");
       
            Console.ReadKey();

        }
        
    }
}
