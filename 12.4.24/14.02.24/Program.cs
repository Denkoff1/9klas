using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _14._02._24
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Vuvedi kolko hora:");
            int n = int.Parse(Console.ReadLine());
            string[] imena = new string[n];
            string[] edno;
            //izhod 1
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi 3 imena:");
                imena[i] = Console.ReadLine();
              edno = imena[i].Split(' ');
                //string[] imena = Console.ReadLine().Split(' ').ToArray();
                Console.WriteLine("izhod 1 :");
                Console.WriteLine(imena[i]);
                Console.WriteLine("Purvo={1}", i, edno[i]);
                Console.WriteLine("Vtoro={1}", i + 1, edno[i + 1]);
                Console.WriteLine("treto={1}", i + 2, edno[i + 2]);
            }
            //izhod 2:Izvejadane na elementi ot posledniq do purviq
            for (int i = n-1; i >=0; i--)
            {
                edno = imena[i].Split(' ');
                Console.WriteLine("izhod 2 :");
                Console.WriteLine("Treto={1}", i + 2, edno [i + 2]);                             
                Console.WriteLine("Vtoro 2={1}", i + 1, edno[i + 1]);                
                Console.WriteLine("Purvo 3={1}", i, edno[i]);   
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("izhod 3");
                edno = imena[i].Split(' ');
                Console.WriteLine("Purvo={1}", i, edno[i]);
               
                Console.WriteLine("treto={1}", i + 2, edno[i + 2]);
            }
        }
    }
}
