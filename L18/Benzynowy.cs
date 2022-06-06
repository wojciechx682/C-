using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    

    public class Benzynowy: Samochod
    {
        public int is_running = 0;      // Zmienna określająca czy silnik jest uruchomiony  
        public int is_moving = 0;       // Zmienna określająca czy auto jest w ruchu
        public int fuel_level = 10;     // Zmienna określająca poziom paliwa w samochodzie


        public String Rodzaj = "Benzynowy" ;
        public Benzynowy() : base(0)
        {
            if(fuel_level==0)
            {
                this.Bak = "Pusty";
            }
            else
            {
                this.Bak = "nie pusty";
            }

            if(is_running == 0)
            {
                this.Silnik = "Wyłączony";
            }
            else
            {
                this.Silnik = "Uruchomiony";
            }                         
        }

        public override void UruchomSilnik()
        {
            base.UruchomSilnik();

            if(is_running == 0)
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

            if(is_running == 0 || fuel_level == 0)    //Jeśli silnik jest wyłączony
            {               
                testuj_jedz();
            }
            else
            {
                Console.WriteLine("Auto jest w ruchu");

                fuel_level -= 1;   // Jazda powoduje zmniejszanie się poziomu paliwa
            }               
        }

        public override void Tankuj()
        {
            base.Tankuj();
            if (fuel_level == 0 && is_running == 0)    // przed zatankowaniem należy wyłączyć silnik
            {
                Console.WriteLine("Paliwo zostało uzupełnione");
                fuel_level = 10;
                return;
            }
            testuj_tankowanie();
            
        }

        public override void ZatrzymajSilnik()
        {
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
            }
            if(fuel_level == 0)
            {
                Console.WriteLine("Brak paliwa!");
            }                    
        }

        public void testuj_silnik_wyłączenie()
        {
            if (is_running == 0)    //Jeśli silnik jest wyłączony
            {
                Console.WriteLine("Silnik został już wcześniej wyłączony !");
            }      
        }

        public void testuj_tankowanie()
        {
            if (fuel_level != 0 )      // jeśli bak nie jest pusty
            {
                Console.WriteLine("W baku jest jeszcze paliwo!");              
            }

            if(is_running == 1)        // przed zatankowaniem należy wyłączyć silnik
            {
                Console.WriteLine("Należy wyłączyć silnik przed zatankowaniem!");
            }           
        }

    }
}
