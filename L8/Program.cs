using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Przedstawić pełną informację na temat systemu plików począwszy od katalogu bieżącego 
    (wskazanego jako parametr aplikacji - jeśli brak katalog bieżący) z uwzględnieniem podfolderów.
    Implementacji dokonujemy w klasie. 
    O sposobie wyświetlania informacji decyduje metoda (delegat lub interfejs) przekazany w konstruktorze klasy. 
    (teraz możemy wybrać plik lub konsole w przyszłości inne miejsca)

    Wyciągamy maksymalną informację o plikach, i folderach
    (atrybuty, czy jest do odczytu/zapisu)
    uprawnienia
    wszysko co jest w danym FOLDERZE i PODFOLDERACH

    decydujemy się na INTERFEJS LUB DELEGAT:
        DELEGAT LUB INTERFEJS <- określają sposób zapisu do PLIKU lub KONSOLI

    KONSTRUKTOR - dostaje INTERFEJS lub DELEGAT

    Delegat -> Do pliku / i na konsole    (2 delegaty)
    Interfejs -> Do pliku / i na konsole  (2 interfejsy)    
*/

using System;
using System.IO;

namespace ConsoleApplication1
{
    class FileSysInfro
    {
        static void Main(string[] args)
        {
            var vi = Directory.GetCurrentDirectory();
            Console.WriteLine(vi.ToString());

            DirectoryInfo di = new DirectoryInfo(vi);

            System.IO.DirectoryInfo dirInfo = di;

            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*", System.IO.SearchOption.AllDirectories);

            Console.WriteLine("\nPliki:");    
            foreach (System.IO.FileInfo fi in fileNames)
            {
                Console.WriteLine("Nazwa: {0}, Czas utworzenia: {1}, Ostatni czas dostępu: {2}, Atrybuty: {3}, Rozmiar w bajtach: {4}", fi.Name, fi.CreationTime, fi.LastAccessTime, fi.Attributes, fi.Length);
            }

            Console.WriteLine("\nKatalogi i podkatalogi:");
            foreach (System.IO.DirectoryInfo d in dirInfos)
            {
                Console.WriteLine("Nazwa: {0}, Ostatni czas dostępu: {1}, Atrybuty: {2}, Czas utworzenia: {3}", d.Name, d.LastAccessTime, di.Attributes, di.CreationTime);
            }
        }
    }
 }

