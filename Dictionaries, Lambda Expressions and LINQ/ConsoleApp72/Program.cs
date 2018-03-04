using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if(!counts.ContainsKey(num))
                {
                    counts[num] = 1;
                }
                else
                {
                    counts[num]++;
                }

            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
            
        }
    }
}
