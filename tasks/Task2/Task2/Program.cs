using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Beruf beruf = new Beruf("Mechaniker", 30000);

            Console.WriteLine("Beruf: {0} Jahresgehalt: {1} Ausgeschrieben: {2}", beruf.Bezeichnung, beruf.JahresGehalt, beruf.Ausgeschrieben);

            beruf.Ausschreiben(true);

            Console.WriteLine("Beruf: {0} Jahresgehalt: {1} Ausgeschrieben: {2}", beruf.Bezeichnung, beruf.JahresGehalt, beruf.Ausgeschrieben);

        }
    }
}
