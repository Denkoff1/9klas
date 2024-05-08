using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] predmet = new string[3];
            int[] chas = new int[3];
            Console.WriteLine("Vhod:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi predmet:");
                predmet[i] = Console.ReadLine();
                Console.Write("Vuvedi chas:");
                chas[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Izhod 1:");
            for (int i = 0; i < n; i++)
            { Console.WriteLine("Chas:" + chas[i] + " Predmet:" + predmet[i]); }
            Console.WriteLine("Izhod 2:");
            for (int i = 0; i < n; i++)
            {
                if (chas[i] >= 4)
                {
                    Console.WriteLine("Chas:" + chas[i] + " Predmet:" + predmet[i]);
                }

            }
            Console.WriteLine("izhod 3:");
            Array.Sort(chas);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chas:" + chas[i] + " Predmet:" + predmet[i]);
            }
            Console.WriteLine("izhod 4:");
            Array.Sort(predmet);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chas:" + chas[i] + " Predmet:" + predmet[i]);
            }
            Console.WriteLine("izhod 5:");
            Array.Reverse(predmet);
            Array.Sort(predmet);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Chas:" + chas[i] + " Predmet:" + predmet[i]);
            }
            Console.WriteLine("Izhod 6");
            string nov_predmet ="matematika";
            for (int i = 0; i < n; i++)
            {
                if (predmet[i] == nov_predmet)
                {
                 Console.WriteLine("Chas:" + chas[i] + " Predmet:" + predmet[i]);
                }
               
            }
            Console.WriteLine("izhod 7");                                                 
                    Console.WriteLine("Chas:" + chas[1] + " Predmet:" + predmet[1]);            
        }
    }
}
