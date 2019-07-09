using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sumthreeandfive = 0;
            for (int i = 0; i <= 999; i++){
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumthreeandfive += i;
                }
            }
            
            
            Console.WriteLine("Total = " + sumthreeandfive);
            Console.ReadKey();

        }
    }
}
