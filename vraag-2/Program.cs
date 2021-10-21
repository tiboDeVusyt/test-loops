using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int punten = 0;
            int sum = 0;
            int gem = 0;
            Console.WriteLine("whats your name");
            string name = Console.ReadLine();
            do
            {
                i++;
                Console.WriteLine($"what are your points for vak {i} ");
                punten =int.Parse(Console.ReadLine());
                sum += punten;
                gem = sum / i;
                Console.Clear();
            } while (i<3);
            Console.WriteLine($"points of: {name}");
            Console.WriteLine($"your total is {sum}");
            Console.WriteLine($"your average is {gem}");
        }
    }
}
