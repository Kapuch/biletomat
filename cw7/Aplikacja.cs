using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw7
{
    class Aplikacja
    {
        List<Bilet> mojeBilety = new List<Bilet>();
        private char rodzaj;
        public void WczytajKlawisz()
        {
            Console.WriteLine("Rodzaje biletów:");
            Console.WriteLine("A-Autobusowe\nK-Kolejowe");
            
            while(rodzaj!='A' || rodzaj!='K')
            {
                rodzaj = Console.ReadKey().KeyChar;
            }
        }
        public void WykonajDzialanie()
        {
        }
    }
}
