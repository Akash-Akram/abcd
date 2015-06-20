using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Or5MultipleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%5 == 0 || i%5 == 0)
                {
                     sum  += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
