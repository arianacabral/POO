using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i, j, k = 1;

            Console.Write("Número de linhas: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                for(j = 0; j <= i; j++)
                {

                    if(j == 0 | i == 0)
                    {
                        k = 1;
                    }
                    else
                    {
                        k = k * (i - j + 1) / j;
                    }

                    Console.Write(k + "\t");

                }

                Console.WriteLine();

            }

            Console.ReadLine();

        }
    }
}
