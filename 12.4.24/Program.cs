using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            grupa Grupa = new grupa();
            Grupa.Ime = "Ivan";
             Grupa.Ocenka = 5.25;
            Grupa.Adres = "Elena Snejina 5";

            grupa Grupa1 = new grupa();
            
            Console.Write("Vuvedi ime:");
            Grupa1.Ime=Console.ReadLine();
            Console.Write("Vuvedi adres:");
            Grupa1.Adres = Console.ReadLine();
            Console.Write("Vuvedi Ocenka:");
            Grupa1.Ocenka = double.Parse(Console.ReadLine());
            Grupa.Zdravei();
            Grupa1.Zdravei();

           //Console.WriteLine("Здравейте!Аз съм {0} и съм от {1} и имам оценка:{2}.", ime, adres, ocenka);
           
        }
    }
}
