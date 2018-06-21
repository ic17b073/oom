using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var beruf = new Subject<Beruf>();

            beruf.Subscribe(x => Console.WriteLine($"Bezeichnung: {x.Bezeichnung}; Jahresgehalt: {x.JahresGehalt}"));

            beruf.Where(x => x.JahresGehalt >= 10000)
                .Where(x => x.JahresGehalt <= 100000)
                .Subscribe(x => Console.WriteLine($"Bezeichnung: {x.Bezeichnung}; Jahresgehalt zwischen 10000 und 100000: {x.JahresGehalt}"));

            //Console.WriteLine("------------- Ohne Filter -------------");
            for (var i = 1; i <= 50; i++)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(.5));
                beruf.OnNext(new Beruf(String.Format("Beruf {0}", i.ToString()), (UInt32)rnd.Next(20000, 20000 * i)));
            }
        
            Console.ReadLine();
        }        
    }
}
