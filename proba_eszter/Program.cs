using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //névtér
using System.IO;

namespace proba_eszter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helló Világ!");
            Console.Write("Ez egy másik sor!");

            //Egysoros megjegyzés
            /*
             * 
             * string típusok
             * 
             * 
             * 
             */
            string nev = "alma";
            string nev2 = "fa";
            //Feladat: szeretném összefűzni a két sztringet!
            string nev3 = nev + nev2;
            Console.WriteLine("\n" + nev3);
            Console.WriteLine("Hajrá!!!\n" + nev + nev2);
            string nev4 = nev.Replace('a', 'e');
            Console.WriteLine(nev4);
            string nev5 = nev3.ToUpper();
            Console.WriteLine(nev5);
            string nev6 = nev5.Substring(4, 2);
            Console.WriteLine(nev6);

            Console.ReadKey();
        }
    }
}
