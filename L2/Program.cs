using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Osoba o1 = new Osoba("Jakub ", "Wojciechowski", 1999);
            
            Osoba o2 = new Osoba("Linus", "Torvalds", 1969);
            
            Osoba o3 = new Osoba("Elon", "Musk", 1971);

            o1.ShowData();
            o1.ShowAge();

            o2.ShowData();
            o2.ShowAge();

            o3.ShowData();
            o3.ShowAge();

            Prostokat prostokat = new Prostokat();
            prostokat.SetWidth(3);
            prostokat.SetHeight(9);

            Console.WriteLine("Powierzchnia prostokąta o boku 3 i 9 wynosi: {0}", prostokat.CalculateField());
            //Console.ReadKey();     
        }
    }
    //Tworzenie interfejsu "Iosoba"
    public interface Iosoba
    {
        // Metody interfejsu
        void ShowData();       
    }

    //Interfejs "Iwiek" dziedziczy metody z interfejsu "Iosoba"
    public interface Iwiek : Iosoba
    {
        // Metody interfejsu
        void ShowAge();
    }

    // Klasa "Osoba" dziedziczy z interfejsu "Iwiek", zawiera implementację odziedziczonych metod z interfejsów
    class Osoba : Iwiek
    {
        private int valuee = 2020;
        //Zmienne (prywatne) nalezace do klasy Osoba
        private string Name;
        private string Surname;
        private int BirthdayYear;
        private int value = 10;

        //Konstruktor inicjujący dane
        public Osoba(string n, string s, int y)
        {
            Name = n;
            Surname = s;
            BirthdayYear = y;            
        }

        //Metoda "ShowData" z interfejsu "Iosoba"
        public void ShowData()
        {
            Console.WriteLine("Imie: {0}", Name);
            Console.WriteLine("Nazwisko: {0}", Surname);
            Console.WriteLine("Rok urodzenia: {0}", BirthdayYear);                   
        }

        //Metoda "ShowAge" z interfejsu "Iwiek"
        public void ShowAge()
        {
            Console.WriteLine("Wiek: {0}", (2020 - BirthdayYear));
            Console.WriteLine(" ");
        }        
    }

    // Dziedziczenie klas
    // Klasa bazowa "Shape"
    class Shape
    {        
        // Pola typu "protected" sa dostepne dla klas dziedziczacych z tej klasy
       
        protected int Width;
        protected int Height;

        public void SetHeight(int w)
        {
            Height = w;
        }
        public void SetWidth(int s)
        {
            Width = s;
        }     
    }

    class Prostokat : Shape
    {
        public int CalculateField()
        {
            // mamy dostęp do pól z klasy bazowej
            return Height * Width;
        }
    }
}


