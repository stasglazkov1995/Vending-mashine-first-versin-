using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] getChange(double M, double P)
            {
                int cent1 = 0, cent5 = 0, cent10 = 0, cent25 = 0, cent50 = 0, dolar1 = 0;
                if (M > P)
                {
                    double remainder = M - P;
                    while (remainder > 0)
                    {
                        if (remainder >= 1)
                        {
                            dolar1++;
                            remainder -= 1;
                        }
                        
                        else if (remainder >= 0.5)
                        {
                            cent50++;
                            remainder -= 0.5;
                        }
                        else if (remainder >=0.25)
                        {
                            cent25++;
                            remainder -= 0.25;
                        }
                        else if (remainder >= 0.1)
                        {
                            cent10++;
                            remainder -= 0.1;
                        }
                        else if (remainder >= 0.05)
                        {
                            cent5++;
                            remainder -= 0.05;
                        }
                        else if (remainder > 0.01)
                        {
                            cent1++;
                            remainder -= 0.01;
                        }
                        else
                        {
                            remainder = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You don't enter enough money!");
                }
                int[] denomination = { cent1, cent5, cent10, cent25, cent50, dolar1 };
                return denomination;
            }
            ///////////////////////////////////////////////////////////////////////////
            //if you want see answerd
            int[] Zdacha = getChange(2, 3.01);
            foreach (int key in Zdacha)
            {
                Console.Write($"| {key} |");
            }
            Console.ReadLine();
        }
    }
}
