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
            
            int sumThreeAndFive = 0;
            for (int i = 0; i <= 999; i++){
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumThreeAndFive += i;
                }
            }
            
            
            Console.WriteLine("Total = " + sumThreeAndFive);
            Console.ReadKey();

        }
    }
}
