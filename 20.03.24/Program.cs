using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> a =Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("izhod 1");
            for (int i = 0; i < a.Count; i++)
            {             
                if (a[i] % 2 == 0)
                {
                 Console.WriteLine("a=" + a[i]);
                }              
            }
            //List<int> List = new List<int>();
            //int Start = 0;
            //int Lenght = 0;
            //int bestStart = 0;
            //int bestLenght = 0;
            //for (int i = 0; i < List.Count; i++)
            //{
            //    if (a[i]==Start)
            //    {
            //        Lenght++;
            //        Console.WriteLine("a=" + a[i]);
            //    }
            //    else
            //    {
            //        Console.Write("Vuvedi nova stinost za start:");
            //        Start=int.Parse(Console.ReadLine());
            //        Console.Write("Vuvedi nova stinost za lenght:");
            //        Lenght = int.Parse(Console.ReadLine());
            //    }
            //    if(Lenght < bestLenght)
            //    {
            //        Console.Write("Vuvedi nova stinost za beststart:");
            //        bestStart = int.Parse(Console.ReadLine());
            //        Console.Write("Vuvedi nova stinost za bestlenght:");
            //        bestLenght = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("a=" + bestLenght);
            //}
            Console.WriteLine("Izhod 2");
            for (int i = 0;i < a.Count; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine("a=" + a[i]);
                }
            }
            Console.WriteLine("izhod 3");
           
            for (int i = 0; i < a.Count-1; i++)
            {
                 int naiMalko = a[0];
                if (naiMalko < a[i])
                {
                    naiMalko = a[0];
                    
                }
                else
                {
                    naiMalko = a[i];
                    
                }
                 Console.WriteLine(naiMalko);
            }
              
        }
    }
}
