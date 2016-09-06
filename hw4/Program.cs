using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
          int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите африфметический знак ");
            string sign = Console.ReadLine();
   
            switch (sign)
                {
                case "+":
                    {
                        Console.WriteLine(x + y);
                        break;
                            }

                case "-":
                    {
                        Console.WriteLine(x - y);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(x * y);
                        break;
                    }
                case "/":
                    {
                        if (y == 0)
                            Console.WriteLine("деление на ноль не возможно !");
                              Console.WriteLine(x / y);

                          

                        break;
                }
                default:
                    {
                        Console.WriteLine("вы ввели не правильный знак");
                            break;

                    }
                    }

            Console.ReadKey();
        }
    }
}
