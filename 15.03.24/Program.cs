using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] klas = new int[n];
            int[] nomer= new int[n];
            string[]ime= new string[n];
            Console.WriteLine("Vhod:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Koi klas si?:");
                klas[i]=int.Parse(Console.ReadLine());
                Console.Write("Koi nomer si?:");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.Write("Kak se kazvash?:");
                ime[i]=Console.ReadLine();
            }
            for (int i = 0;i <klas.Length-1; i++)
            {
                for (int j = 0;j < klas.Length-1;j++)
                {
                    if (klas[j] > klas[j+1])
                    {
                        int swapVar = klas[j];
                        klas[j] = klas[j+1];
                        klas[j+1]=swapVar;
                    }
                }
            }
                for(int i = 0;i < klas.Length-1;i++)
            Console.WriteLine(string.Join("",klas));
            for (int i = 0; i < nomer.Length - 1; i++)
            {
                for (int j = 0; j > nomer.Length - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < nomer.Length - 1; i++)
                Console.WriteLine(string.Join("", nomer));
        }
    }
}
