using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4._24
{
    internal class grupa
    {
        private string ime;
        private string adres;
        private double ocenka;
        public String Ime {
            get { return ime; }
            set { ime = value; }
        }
        public String Adres { get { return adres; } set { adres = value; } }
        public double Ocenka { get { return ocenka; } set { ocenka = value; } }
        public void Zdravei()
        {
            Console.WriteLine("Здравейте!Аз съм "+ime+" и съм от "+adres+" и имам оценка:"+ocenka+".");
        }
    }
}
