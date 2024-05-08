using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _27._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вход:");
            string duma=Console.ReadLine();
            Console.Write("Изход:");
            Console.WriteLine(duma.Length);
            Console.WriteLine("Зад.2");
            Console.Write("1:");
            string str = Console.ReadLine();
            Console.Write("2:");
            string str1 = Console.ReadLine();
            Console.WriteLine(str+" "+str1);
            Console.Write("Въведи нещо:");
            string naobratno=Console.ReadLine();
          for(int i = naobratno.Length - 1; i >=0; i--)
            {
                Console.Write(naobratno[i]);
            }
            Console.Write("Вход:");
            string dumi = Console.ReadLine();
            string[]k=dumi.Split(" ");
            Console.Write("Изход:");
            Console.WriteLine(dumi.Length);
        }
    }
}
