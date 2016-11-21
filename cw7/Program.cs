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
            BiletK bilet2 = new BiletK(100);
            BiletK bilet3 = new BiletK(10);
            BiletK bilet4 = new BiletK(200);
            bilet1.ObliczCene(RodzajBiletu.N);
            bilet1.ObliczCene(RodzajBiletu.U);
            Console.WriteLine("-------------");
            bilet2.ObliczCene(RodzajBiletu.N);
            bilet2.ObliczCene(RodzajBiletu.U);
            Console.WriteLine("-------------");
            bilet3.ObliczCene(RodzajBiletu.N);
            bilet3.ObliczCene(RodzajBiletu.U);
            Console.WriteLine("-------------");
            bilet4.ObliczCene(RodzajBiletu.N);
            bilet4.ObliczCene(RodzajBiletu.U);
            Console.ReadKey();
        }
    }
}
