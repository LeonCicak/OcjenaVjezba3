using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbaOcjena3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rečenicu: ");
            string recenica = Console.ReadLine();


            string[] rijec = recenica.Split(' ');


            if (rijec.Length > 0)
            {

                string prvaRijec = rijec[0];

                string zadnjaRijec = rijec[rijec.Length - 1];


                Console.WriteLine("Prva riječ: " + prvaRijec);
                Console.WriteLine("Zadnja riječ: " + zadnjaRijec);
            }
            else
            {
                Console.WriteLine("Niste unijeli točnu rečenicu");
            }
            Console.ReadKey();
        }
    }
}
