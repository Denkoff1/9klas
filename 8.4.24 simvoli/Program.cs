using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _8._4._24_simvoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string str = "Hello,Ivan Denkov v C#";
            Console.WriteLine("Vuvedi purvo ime");
            string name=Console.ReadLine();
            Console.WriteLine("Hi,"+name);
            Console.WriteLine("Vuvedi vtoro ime");
            string LastName = Console.ReadLine();
            Console.WriteLine("Hi,{0} {1}" , name," ",LastName);
            Console.WriteLine("Vuvedi familiq");
            string FamiliName = Console.ReadLine();
            Console.WriteLine($"Hi,{name} {LastName} {FamiliName}!");
            int result=string.Compare(name, LastName, true);
            Console.WriteLine(result);
            string str1=string.Concat(name, FamiliName);
            Console.WriteLine(str1);
            int firstIndex = str.IndexOf(",");
            Console.WriteLine(firstIndex);
            int secondIndex = str.IndexOf("I",1);
            Console.WriteLine(secondIndex);
            int notFound=str.IndexOf("/");
            Console.WriteLine(notFound);
            string name1=str.Substring(6,4);
            Console.WriteLine(name1);
            string Hello = str.Substring(0, 5);
            Console.WriteLine(Hello);
            string replace=str.Replace("v C#","Si otiva");
            Console.WriteLine(replace);
        }
    }
}
