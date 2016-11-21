using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw7
{
    class BiletK:Bilet
    {
        private int dlugoscTrasy;
        public override void ObliczCene(RodzajBiletu rodzaj)
        {
            double cenaN;
            if (dlugoscTrasy <= 100)
                cenaN = dlugoscTrasy * 1.04;
            else
                cenaN = dlugoscTrasy * 0.73;
            if (rodzaj == RodzajBiletu.N)
                base.cena = cenaN;
            else
                base.cena = cenaN / 2;
            Console.WriteLine(String.Format("{0:N2}", cena));
        }

        public BiletK(int odleglosc)
        {
            this.dlugoscTrasy = odleglosc;
        }
    }
}
