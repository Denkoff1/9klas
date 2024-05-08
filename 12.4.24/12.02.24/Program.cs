using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko dushi shte vuvezdash?");
            int n=int.Parse(Console.ReadLine());
            string[] imena =new string[n];
            double[] pari = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi ime i familiq:");
                imena[i]=Console.ReadLine();
                Console.WriteLine("Kolko pari ima tozi chowek:");
                pari[i] =double.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(imena[i] + " ima " + pari[i] + " lv.");
            }
            Console.WriteLine("izhod 2:");
            for (int i = 0; i < n; i++)
            {
               if (pari[i] >= 7)
                {
                    Console.WriteLine(imena[i] + " ima " + pari[i] + " lv.");
                }
            }
            Console.WriteLine("izhod 3");
            for (int i = 0; i < n; i++)
            {
                    Console.WriteLine(imena[i] + " ima " + (pari[i]-2)  + " lv.");
            }
        }
    }
}
