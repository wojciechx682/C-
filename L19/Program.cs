using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyklad1
{
    class Program
    {
        static void Main(string[] args)
        {       
            var Audi = new ClassLibrary.Benzynowy();
            var Ford = new ClassLibrary.Elektryczny();
            
            Console.WriteLine("Silnik: " + Audi.Rodzaj);
            Console.WriteLine("\n------------------------\n");

            Console.WriteLine("(Uruchomienie silnika) ->");
            Audi.UruchomSilnik();
            Console.WriteLine("(Uruchomienie silnika) ->");
            Audi.UruchomSilnik();
            Console.WriteLine("(Jazda) ->");
            Audi.Jedz();
            Console.WriteLine("\n------------------------\n");
            
            Console.WriteLine("Silnik: " + Audi.Rodzaj);
            Console.WriteLine("(Wyłączenie silnika) ->");
            Audi.ZatrzymajSilnik();
            Console.WriteLine("(Wyłączenie silnika) ->");
            Audi.ZatrzymajSilnik();
            Console.WriteLine("(Uruchomienie silnika) ->");
            Audi.UruchomSilnik();
            //Audi.UruchomSilnik();   // ponowne uruchomienie silnika skutkuje komunikatem informującym, że "Silnik został już wcześniej uruchomiony"                
            //Console.WriteLine("\n");
            //Console.WriteLine(Audi.is_running);
            //Audi.is_moving.ToString();s       
            Console.WriteLine("(Jazda) ->");
            Audi.Jedz();              // jeżeli silnik nie jest uruchomiony, nie można jechać autem - nastąpi wyświetlenie odpowiedniego komunikatu                            
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            //Audi.Jedz();
            //Audi.Jedz();
            //Audi.Jedz();
            //Audi.Jedz();               
            //Audi.Jedz();              // Po dłuższej jeździe skończy się paliwo, i nastąpi wyświetlenie komunikatu "brak paliwa"                           
            Console.WriteLine("(Wyłączenie silnika) ->");
            Audi.ZatrzymajSilnik();
            Console.WriteLine("(Tankowanie) ->");
            Audi.Tankuj();
            //Audi.ZatrzymajSilnik();                        

            Console.WriteLine("(Uruchomienie silnika) ->");
            Audi.UruchomSilnik();
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            Audi.Jedz();
            Console.WriteLine("(Wyłączenie silnika) ->");
            Audi.ZatrzymajSilnik();
            Console.WriteLine("(Tankowanie) ->");
            Audi.Tankuj();
            Console.WriteLine("(Wyłączenie silnika) ->");
            Audi.ZatrzymajSilnik();
            Console.WriteLine("Bak: " + Audi.Bak);


            Console.WriteLine("\n------------------------");
            Console.WriteLine("\nSilnik: " + Ford.Rodzaj);
            Console.WriteLine("(Uruchomienie silnika) ->");
            Ford.UruchomSilnik();
            Console.WriteLine("(Uruchomienie silnika) ->");
            Ford.UruchomSilnik();
            Console.WriteLine("(Jazda) ->");
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Ford.Jedz();
            Console.WriteLine("(Ładowanie akumulatora) ->");
            Ford.Tankuj();
            Console.WriteLine("(Wyłączenie silnika) ->");
            Ford.ZatrzymajSilnik();
            Console.WriteLine("(Ładowanie akumulatora) ->");
            Ford.Tankuj();
        }       
    }
}
