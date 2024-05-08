using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Danni a = new Danni();
            Console.Write("Kakva zakuska qde dnes?:");
            a.Ime=Console.ReadLine();
            Console.Write("Kolko qde?:");
            a.Broika=int.Parse(Console.ReadLine());
            a.Izhod();
            Console.WriteLine("Izhod 1:");
            if (a.Broika > 5)
            {
                Console.WriteLine(5 * a.Broika); 
            }
            else
            {
                Console.WriteLine("Broikata e po-malko ot 5!" );
            }
            string[] piene = { " ","Vodka", "Voda", "Martini", "Wiski" };
            Console.WriteLine("Pititeta");
            Console.Write("Pil li si neshto dnes?:");
            string dailine=Console.ReadLine();
            if (dailine == "da")
            {
                Console.Write("Kakvo si pil izberi cifra ot 1 do 4:");
                int Cifra=int.Parse(Console.ReadLine()) ;
                if (Cifra == 1)
                {
                    Console.WriteLine("Ti si pil " + piene[1]);
                }else
                if (Cifra == 2)
                {
                    Console.WriteLine("Ti si pil "+ piene[2]);
                }else
                if (Cifra ==3)
                {
                    Console.WriteLine("Ti si pil " + piene[3]);
                }
                else
                if (Cifra == 4)
                {
                    Console.WriteLine("Ti si pil " + piene[4]);
                }
            }
            else
            {
                Console.WriteLine("Lek den!");
            }
           
        }
    }
}
