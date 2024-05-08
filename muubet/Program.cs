using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muubet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko choveka ste?:");
            int n=int.Parse(Console.ReadLine());
            string[]ime=new string[n];
            double[]cena=new double[n];
            int[]broiPiine=new int[n];
            Console.WriteLine("Vhod:");
            for (int i=0; i<n; i++)
            {
                Console.Write("Vuvedi pitie:");
                ime[i] =Console.ReadLine();
                Console.Write("Vuvedi cenata:");
                cena[i]=double.Parse(Console.ReadLine());
                Console.Write("Vuvedi broi:");
                broiPiine[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Izhod 1:");
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine(ime[i] + " / " + cena[i] + " / " + broiPiine[i]);
            }
            Console.WriteLine("Izhod 2:");
            for (int i = 0; i < n; i++)
            {
                if (cena[i]>2.50)
                {
                    Console.WriteLine(ime[i] + " / " + cena[i] + " / " + broiPiine[i]);
                }               
            }
           Console.WriteLine("Izhod 3:");
            for (int i = 0; i < n; i++)
            {
                if (cena[i] == 2 && ime[i]=="kafe")
                {
                    Console.WriteLine(broiPiine[i]);
                }
            }
            Console.WriteLine("Izhod 4:");
            Array.Sort(ime);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ime[i] + " / " + cena[i] + " / " + broiPiine[i]);
            }
            Console.WriteLine("Izhod 5:");
            Console.WriteLine("Izhod 6:");
            int firstValue = 0;
            int lastValue = ime.Length-1;
            int midValue = ime.Length / 2;
            Console.WriteLine(ime[firstValue] + "/" + ime[midValue] + "/" + ime[lastValue]);
            Console.WriteLine("izhod 7:");           
            for (int i = 0; i < n; i++)
            {
                if (ime[i]=="kafe")
                {
                    Console.WriteLine("Chai");
                }
            }

        }
    }
}
