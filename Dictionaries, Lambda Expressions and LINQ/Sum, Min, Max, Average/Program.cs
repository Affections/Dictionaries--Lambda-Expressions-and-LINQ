using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();
            int count = int.Parse(Console.ReadLine()) ;
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
