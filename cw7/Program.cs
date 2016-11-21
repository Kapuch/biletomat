using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw7
{
    enum RodzajBiletu { N, U };
    class Program
    {
        static void Main(string[] args)
        {
            BiletA bilet1 = new BiletA();
            bilet1.ObliczCene(RodzajBiletu.N);
            bilet1.ObliczCene(RodzajBiletu.U);
            Console.ReadKey();
        }
    }
}
