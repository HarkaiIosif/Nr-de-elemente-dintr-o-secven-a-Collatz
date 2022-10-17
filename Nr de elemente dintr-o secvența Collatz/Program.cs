using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr_de_elemente_dintr_o_secvența_Collatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nr = 1;
            while (n != 1)
            {
                nr = nr + 1;
                if (n % 2 == 0) n = n / 2;
                else n = 3 * n + 1;

            }
            Console.WriteLine(nr);
            Console.ReadKey();
        }
    }
}
