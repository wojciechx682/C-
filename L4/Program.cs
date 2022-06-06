using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Liczymy pole miedzy x1 i x2

// Obszar dzielimy na prostokaty (na ile ????)
// różnica pomiędzy dwoma kolejnymi polami będzie mniejsza od 1/10
// a, b, c  <- parametry wejściowe

/*
Zadanie:
Napisać aplikacje obliczającą pole pod powierzchnią funkcji 
ax2 + bx +c = f(x) w obszarze od x1 do x2, za pomocą metody prostokątów.
Obszar między x1 a x2 dzielimy na coraz większą liczbę prostokątów, 
do chwili gdy różnica między kolejnymi polami nie będzie mniejsza od zadanej wartości d.
Przyjmijmy dla testów d = 0,1.
*/

namespace L4_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=1, b=1, c=1, S, dx;        // a,b,c -> to wspolczynniki liczbowe we wzorze funkcji kwadratowej f(x) = ax2 + bx +c 
            // S - to pole pod wykresem funkcji
            
            double function(double x)
            {
                return (a * x * x + b * x + c);
            }

            double N = 10; //liczba punktów / prostokątów podziałowych
            
            int i=1;
            Console.WriteLine("f(x) = ax^2 + b^x +c \n");
            Console.WriteLine("Podaj wartosc 'a': ");
            string input1 = Console.ReadLine();            
            Double.TryParse(input1, out a);

            Console.WriteLine("Podaj wartosc 'b': ");
            string input2 = Console.ReadLine();
            Double.TryParse(input2, out b);

            Console.WriteLine("Podaj wartosc 'c': ");
            string input3 = Console.ReadLine();
            Double.TryParse(input3, out c);          

            Console.WriteLine("Podaj poczatek przedzialu: ");
            string input4 = Console.ReadLine();
            double xp;
            Double.TryParse(input4, out xp);

            Console.WriteLine("Podaj koniec przedzialu: ");
            string input5 = Console.ReadLine();
            double xk;
            double.TryParse(input5, out xk);

            // format stałoprzecinkowy

            //Console.WriteLine(xp);
            //Console.WriteLine(xk);

            dx = (xk - xp) / N;

            Console.WriteLine("\nwartosc roznicy pola drugiego prostokota i pierwszego wynosi (przed wyrownaniem): ");
            Console.WriteLine(Math.Abs(function(xp + 2 * dx) - function(xp + 1 * dx)));

            // Jako warunek podalem mniejsza roznice tych pol, aby ostatecznie uzyskac bardziej precyzyjny wynik pola
            // nie d=0.1  ---- > lecz d=0.01
            while (Math.Abs(function(xp + 2 * dx) - function(xp + 1 * dx))>0.01)
            {
                N = N + 1;
                Math.Abs(dx = (xk - xp) / N);
                if(Math.Abs(function(xp + 2 * dx) - function(xp + 1 * dx)) <= 0.01)
                {
                    break;
                }
            }            
            Console.WriteLine("\nwartosc roznicy pola drugiego prostokota i pierwszego wynosi (po wyrownaniu): ");
            Console.WriteLine(Math.Abs(function(xp + 2 * dx) - function(xp + 1 * dx)));      

            S = 0;
            for (i = 1; i <= N; i++)
            {                
                S += function(xp + i * dx);
            }

            S *= dx;
            Console.WriteLine("\nPole pod powierzchnia funkcji wynosi: ",S);
            double Abs_value = Math.Abs(S);
            Console.WriteLine(Abs_value+"\n");   
        }

        private static double Abs(double v)
        {
            throw new NotImplementedException();
        }
    }
}
