using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Benzynowy: Samochod
    {
        public String Rodzaj = "Benzynowy" ;
        public Benzynowy() : base(0)
        {
            this.Bak = "Pusty";
            this.Silnik = "Uruchomiony";           
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
            Console.WriteLine("Skończyło się paliwo");
        }

        public override void ZatrzymajSilnik()
        {
            base.ZatrzymajSilnik();
            Console.WriteLine("Auto nie jest w ruchu");
        }


    }
}
