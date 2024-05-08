using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko chisla shte vuvejdash?");
            int n=int.Parse(Console.ReadLine());
            List<int> a = new List<int>();
            Console.WriteLine("Vhod:");
            for (int i = 0; i < n; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Izhod");
            for (int i = 0;i < a.Count; i++)
            {
                Console.WriteLine("a[{0}]={1}", i+1, a[i]);
            }
            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n-1; i++)
            {
                if (a[i] != a[n - 1])
                {                 
                 Console.WriteLine(a[i]);
                }
                
            }
            Console.WriteLine("Izhod 3");
              a.Insert(3,2);
            for (int i = 0; i < a.Count; i++)
            {
              
                Console.WriteLine("a[{0}]={1}", i + 1, a[i]);
            }
            Console.WriteLine("Ïzhod 4");
            a.Remove(2);
            for (int i = 0; i < a.Count; i++)
            {

                Console.WriteLine("a[{0}]={1}", i + 1, a[i]);
            }
            Console.WriteLine("Ïzhod 5");
            for(int i = 0;i<a.Count; i++)
            {
                for (int j = 0;j<a.Count-1;j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int swapVar = a[j];
                        a[j] = a[j + 1];
                        a[j+1] = swapVar ;
                    }
                }
            }
            for (int i = 0; i < a.Count; i++)
                Console.WriteLine(a[i]);
            Console.WriteLine("Ïzhod 6");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("a[{0}]={1}", i + 1, a[i]);
            }
            Console.WriteLine("Ïzhod 7");
        }
    }
}
