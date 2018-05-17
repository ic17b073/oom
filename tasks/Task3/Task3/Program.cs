using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            IBeruf[] iberuf = new IBeruf[] { new Techniker("Kommunikationstechniker", "Roland"),
                                             new Beruf("Kellner", 10000),
                                             new Techniker("Netzwerktechniker", "Leo"),
                                             new Beruf("Mechaniker", 30000),
                                             new Techniker("ITtechniker", "Rainy"),
                                             new Beruf("Bauarbeiter", 20000)};



            for (int i = 0; i < iberuf.Length; i++)
            {
                Console.WriteLine("Beruf: {0} Jahresgehalt: {1}", iberuf[i].Bezeichnung, iberuf[i].JahresGehalt);

                iberuf[i].JahresGehalt = (UInt32)rnd.Next(5000, 200000);
            }

            Console.WriteLine();

            for (int i = 0; i < iberuf.Length; i++)
            {
                Console.WriteLine("Beruf: {0} Jahresgehalt: {1}", iberuf[i].Bezeichnung, iberuf[i].JahresGehalt);
            }
        }
    }
}
