using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Elektryczny : Samochod
    {
        public int is_running = 0;      // Zmienna określająca czy silnik jest uruchomiony  
        public int is_moving = 0;       // Zmienna określająca czy auto jest w ruchu
        public int battery_level = 10;     // Zmienna określająca poziom paliwa w samochodzie

        public String Rodzaj = "Elektryczny";
        public Elektryczny() : base(0)
        {
            this.Akumulator = "W pełni naładowany";                        
        }

        public override void UruchomSilnik()
        {
            base.UruchomSilnik();

            if (is_running == 0)
            {
                Console.WriteLine("Silnik został uruchomiony");
                is_running = 1;
                return;
            }

            testuj_silnik();
            
            //return 1;
        }

        public override void Jedz()
        {
            base.Jedz();
            if (is_running == 0 || battery_level == 0)    //Jeśli silnik jest wyłączony, lub brak paliwa
            {
                testuj_jedz();
            }
            else
            {
                Console.WriteLine("Auto jest w ruchu");

                battery_level -= 1;   // Jazda powoduje zmniejszanie się poziomu paliwa
            }
        }

        public override void Tankuj()
        {            
            base.Tankuj();

            if (battery_level == 0 && is_running == 0)    // przed naładowaniem akumulatora należy wyłączyć silnik
            {
                Console.WriteLine("Akumulator został naładowany");
                battery_level = 10;
                return;
            }
            testuj_tankowanie();
        }

        public override void ZatrzymajSilnik()
        {
            //wywołanie metody klasy bazowej
            base.ZatrzymajSilnik();

            if (is_running == 1)
            {
                Console.WriteLine("Silnik został wyłączony");
                Console.WriteLine("Auto nie jest w ruchu");
                is_running = 0;
                return;
            }

            testuj_silnik_wyłączenie();           
        }

        public void testuj_silnik()
        {
            if (is_running == 1)
            {
                Console.WriteLine("Silnik został już wcześniej uruchomiony!");
            }
        }

        public void testuj_jedz()
        {
            if (is_running == 0)    //Jeśli silnik jest wyłączony
            {
                Console.WriteLine("Należy uruchomić silnik przed przystąpieniem do jazdy !");
                return;
            }
            if (battery_level == 0)
            {
                Console.WriteLine("Akumulator został rozładowany !");
            }
        }

        public void testuj_tankowanie()
        {
            if (battery_level != 0)      // jeśli akumulator nie jest pusty
            {
                Console.WriteLine("Akumulator jest jeszcze naładowany ! ");
            }

            if (is_running == 1)        // przed zatankowaniem należy wyłączyć silnik
            {
                Console.WriteLine("Należy wyłączyć silnik przed załadowaniem akumulatora!");
            }
        }

        public void testuj_silnik_wyłączenie()
        {
            if (is_running == 0)    //Jeśli silnik jest wyłączony
            {
                Console.WriteLine("Silnik został już wcześniej wyłączony !");
            }
        }


    }
}
