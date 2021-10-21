using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int highNumber = 0;
            int i = 0;
            while (i <3)
            {

                i++;
                Console.WriteLine($"write getal {i}");
                number = int.Parse(Console.ReadLine());
                if (number>highNumber)
                {
                    highNumber = number;
                }
            }
            Console.WriteLine($"the new highest number is {highNumber}");
        }
    }
}
