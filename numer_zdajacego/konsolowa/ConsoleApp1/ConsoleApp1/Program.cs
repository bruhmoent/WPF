using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /*
    **********************************************
    nazwa funkcji: NWD
    opis funkcji: Funckja wyliczajaca najwiekszy wspolny dzielnik z 2 parametrow
    parametry: <a – pierwsza liczba do obliczania nwd
    b – druga liczba do obliczania nwd
    zwracany typ i opis: int, wzracany jest nwd w postaci zmienionego parametru a
    autor: #
    ***********************************************
    */

    internal class Program
    {
        static int NWD(int a, int b)
        {
            if (!(a != b))
            {
                return a;
            }
            else
            {
            while (a != b)
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
                return a;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz a,b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
                
            int nwd = NWD(a, b);
            Console.WriteLine(nwd);

            Console.ReadLine();
            return;
        }
    }
}