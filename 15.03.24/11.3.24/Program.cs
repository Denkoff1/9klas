using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко човека ще въведеш?:");
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            int[] nomer = new int[n];
            Console.WriteLine("вход:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи име:");
                ime[i] = Console.ReadLine();
                Console.Write("Въведи номер:");
                nomer[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Нормален Изход:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Номер:" + nomer[i] + " Име:" + ime[i]);
            }
            Console.WriteLine("Сортиране по номер:");
            for (int i = 0; i < nomer.Length - 1; i++)
            {
                for (int j = 0; j < nomer.Length - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < nomer.Length; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }
            Console.WriteLine("Сортиране в низходящ ред:");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (nomer[j] < nomer[j + 1])
                    {
                        int swapVar = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }
            Console.WriteLine("Сортиране по име:");
            for (int i = 1; i < nomer.Length; i++)
            {

                int k = i;
                for (int j = 0; j < nomer.Length; j++)
                {
                    if (nomer[j] < nomer[k])
                        k = j;
                    {
                        int swapVar1 = nomer[i];
                        nomer[i] = nomer[k];
                        nomer[k] = swapVar1;
                    }
                }
                
            }
            Console.Write(string.Join(" ", nomer)+"/");
            Console.WriteLine(string.Join(" ", ime));
            Console.WriteLine("Izhod po ime");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (StringComparer(ime[j],ime[j + 1])<0)
                    {
                        string swapVar2 = ime[j];
                        ime[j] = ime[j + 1];
                        ime[j + 1] = swapVar2;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }
        }

        private static int StringComparer(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
    }

