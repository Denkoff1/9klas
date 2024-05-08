using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int[] nomer = new int[5];
            string[] ime = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ime:");
                ime[i] = Console.ReadLine();
                Console.WriteLine("Nomer:");
                nomer[i] = int.Parse(Console.ReadLine());
            }
            //izhod 1
            Console.WriteLine("Izhod 1:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ime:" + ime[i]+" nomer:"+nomer[i]);

            }
            //izhod2
            Console.WriteLine("Izhod 2:");
            for (int i = 0; i < 5; i++)
            {
                if (nomer[i] > 3)
                {
                    Console.WriteLine("Ime:" + ime[i] + " nomer:" + nomer[i]);
                }
            }
                //izhod 3 
                Console.WriteLine("Izhod 3:");
            Console.WriteLine("Vuvedi kakvo ime da tursq:");
            string imena=Console.ReadLine();
            for (int i = 0; i < 5; i++)
                {
                if (ime[i]==imena)
                {
                 Console.WriteLine("Ime:" + ime[i] + " nomer:" + nomer[i]);
                }
                else
                {
                    Console.WriteLine("Nqma Takova ime");
                }   

                }
           
        }
    }
}
