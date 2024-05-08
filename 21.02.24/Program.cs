using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko chisla shte vuvejdash");
            int n = int.Parse(Console.ReadLine());
            int[] Chisla = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi chislo:");
                Chisla[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Chisla[i]);
            }
            Console.WriteLine("izhod bez posleden element:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(Chisla[i]);
            }
            Console.WriteLine("Izhod 3:");
            for (int i = 0; i < n; i++)
            {
             Console.WriteLine(" "+Chisla[i]);                
            }
             
            //for (int i = n-1; i >= 0; i--)
            //{

            //    Console.WriteLine(Chisla[i]);
            //}
            //  Console.WriteLine("Izhod 2");


            //  Console.WriteLine(Chisla[1]);
        }
    }
}
