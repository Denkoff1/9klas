using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko choveka ste?:");
            int n=int.Parse(Console.ReadLine());
            string[] pitie=new string[n];
            double[]kolichestvo=new double[n];
            int[]broika=new int[n];
            Console.WriteLine("Vhod");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Kakvo shte piesh?:");
                pitie[i] = Console.ReadLine();
                Console.Write("Kolko litra shte piesh?:");
                kolichestvo[i]=double.Parse(Console.ReadLine());
                Console.Write("Kolko si izpil?:");
                broika[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ti piesh " + pitie[i] + " samo " + broika[i] + " broiki!");
            }
            Console.WriteLine("izhod 2");
           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tvoite "+kolichestvo[i]+" litra sa " + kolichestvo[i]*1000+" mililitra");
            }
            Console.WriteLine("izhod 3");
            for (int i = 0; i < n; i++)
            {
                if (broika[i] > 2)
                {
                  Console.WriteLine("Ti piesh " + pitie[i] + " samo " + broika[i] + " broiki!");
                }
              
            }
            Console.WriteLine("izhod 4");
            for(int i = 0; i<broika.Length-1; i++ )
            {
                for (int j = 0; j < broika.Length - 1; j++)
                {
                    if (broika[j] > broika[j + 1])
                    {
                        int swapVar = broika[j];
                        broika[j]= broika[j + 1];
                        broika[j+1]= swapVar;
                    }
                }
            }
            for (int i = 0;i < broika.Length;i++)
            {
                Console.WriteLine(broika[i]+"!");
            }
            Console.WriteLine("Shte Vuvejdash li oshte");
            string dailine = Console.ReadLine();
            if(dailine == "da")
            {
                Console.Write("Kolko choveka ste toq put?:");
                int k = int.Parse(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    Console.Write("Kakvo shte piesh?:");
                    pitie[i] = Console.ReadLine();
                    Console.Write("Kolko litra shte piesh?:");
                    kolichestvo[i] = double.Parse(Console.ReadLine());
                    Console.Write("Kolko si izpil?:");
                    broika[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("izhod 1");
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("Ti piesh " + pitie[i] + " samo " + broika[i] + " broiki!");
                }
            }
            else
            {
                Console.WriteLine("Krai!");
            }
        }
    }
}
