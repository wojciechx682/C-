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
            Audi.UruchomSilnik();
            Audi.Jedz();
            Audi.Tankuj();
            Audi.ZatrzymajSilnik();                        
            
            Console.WriteLine("Bak: " + Audi.Bak);

            Console.WriteLine("\nSilnik: " + Ford.Rodzaj);
            Ford.UruchomSilnik();
            Ford.Jedz();
            Ford.Tankuj();
            Ford.ZatrzymajSilnik();           
        }

       
    }
}
