using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> output = Console.ReadLine().
                Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(s => s.ToLower()).
                Where(x => x.Length < 5).
                OrderBy(x => x).
                Distinct().
                ToList();


            Console.WriteLine(string.Join(", ",output));


          

        }
    }
}
