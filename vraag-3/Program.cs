using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 20;
            
            for (int i = 0; i <= range; i++)
            {
                if (i % 2 ==0)
                {
                    Console.WriteLine($"{i} is deelbaar door 2");
                }
            }
        }
    } 
}
