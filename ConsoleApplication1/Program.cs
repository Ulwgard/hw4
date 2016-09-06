using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0)
                if (x <= 14)
                    Console.WriteLine("GGWP, RABOTAET Syka");


            if (x >= 15)
                if (x <= 35)
                    Console.WriteLine("GGWP, RABOTAET 15-35");
            Console.ReadKey();

        }
    }
}
