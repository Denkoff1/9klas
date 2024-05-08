using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04_24
{
    internal class Danni
    {
        private string ime;
        private string pitie;
        private int broika;

        public String Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int Broika
        {
            get { return broika; }
            set { broika = value; }
        }
        public string Pitie
        {
            get { return pitie; }
            set { pitie = value; }
        }
        public void Izhod()
        {
            Console.WriteLine("Ti dnes si ql "+broika+" puti i si ql "+ime);
        }
        public void Izhod1()
        {

        }
    }
}
