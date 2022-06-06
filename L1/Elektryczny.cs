using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Elektryczny : Samochod
    {
        public String Rodzaj = "Elektryczny";
        public Elektryczny() : base(0)
        {
            this.Akumulator = "W pełni naładowany";                        
        }

        public override void UruchomSilnik()
        {
            base.UruchomSilnik();
            Console.WriteLine("Silnik jest uruchomiony");
        }

        public override void Jedz()
        {
            base.Jedz();
            Console.WriteLine("Auto jest w ruchu");
        }

        public override void Tankuj()
        {
            
            base.Tankuj();
            Console.WriteLine("Akumulator został rozładowany");
        }

        public override void ZatrzymajSilnik()
        {
            //wywołanie metody klasy bazowej
            base.ZatrzymajSilnik();
            Console.WriteLine("Auto nie jest w ruchu");
        }


    }
}
