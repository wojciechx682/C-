using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Reflection.Emit;
using System.Collections.Specialized;

namespace L3_C_SHARP
{
    class Program
    {
        static void Main()
        {
            /*
                 !    Pliki file.csv oraz index.html zostana utworzone w folderze ..\bin\Debug   !
            */

            string file_path = "file.csv";
            //string fil_path = @"C:\Users\...\Desktop\file.csv";
            string html_path = "index.html";
            //string html_path = @"C:\Users\...\Desktop\index.html";

            string[] array = new string[20];       

            string[] separators = { ",", ".", "!", "?", ";", ":", " ", };            

            int count = 0;         

            int i = 0;

            if (!File.Exists(file_path))
            {
                //PLIK HTML ZOSTANIE UTWORZONY, JEZELI NIE MA TAKIEGO W FOLDERZE KTORY OKRESLA "html_path"                
                string createText = "Imie;Nazwisko;Wiek \n" +
                     "Jakub;Wojciechowski;21\n" +
                     "Jan;Kowalski;25\n" +
                     "Adam;Nowak;44\n";
                File.WriteAllText(file_path, createText);
            }

            Console.WriteLine("\nZawartość pliku file.csv:\n");
            string readText_file = File.ReadAllText(file_path);
            Console.WriteLine(readText_file);
            string[] readText = File.ReadAllLines(file_path);

            foreach (string s in readText)
            {
                count++;
                
                Console.WriteLine($"\nWiersz nr #{count}: {s}");
                
                string value = s;

                string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);              
                
                foreach (var word in words)
                {
                    array[i] = word;
                    
                    Console.WriteLine(word);
                    
                    i++;
                }              
            }

            int lKolumn=(i/count);
            Console.WriteLine($"\nLiczba wierszy w pliku csv: {count} \n");
            Console.WriteLine($"Liczba kolumn w pliku csv: {lKolumn} \n");

            if (!File.Exists(html_path))
            {
                //PLIK HTML ZOSTANIE UTWORZONY, JEZELI NIE MA TAKIEGO W FOLDERZE KTORY OKRESLA "html_path"                
                string createText = "<!DOCTYPE html><html><head><style>" +
                    "table {font-family: arial, sans-serif;" +
                    "border-collapse: collapse;" +
                    "width: 100%;" +
                    "}" +
                    "" +
                    "td, th {" +
                    "border: 1px solid #dddddd;" +
                    "text-align: left;" +
                    " padding: 8px;" +
                    "}" +
                    "" +
                    "tr:nth-child(even) {" +
                    "background-color: #dddddd;" +
                    "}" +
                    "</style></head><body>" +
                    "<h2>Zawartosc pliku CSV :</h2>" +
                    "<table>" +

                    "<tr><b>" +
                    "<td>" + array[0] + "</td>" +
                    "<td>" + array[1] + "</td>" +
                    "<td>" + array[2] + "</td>" +
                    "</b></tr>" +

                     "<tr>" +
                    "<td>" + array[3] + "</td>" +
                    "<td>" + array[4] + "</td>" +
                    "<td>" + array[5] + "</td>" +
                    "</tr>" +
                     "<tr>" +
                    "<td>" + array[6] + "</td>" +
                    "<td>" + array[7] + "</td>" +
                    "<td>" + array[8] + "</td>" +
                    "</tr>" +
                     "<tr>" +
                    "<td>" + array[9] + "</td>" +
                    "<td>" + array[10] + "</td>" +
                    "<td>" + array[11] + "</td>" +
                    "</tr>" +
                    "</table></body></html>" + Environment.NewLine;
                File.WriteAllText(html_path, createText);
            }
            Console.WriteLine("\nZawartość pliku index.html:\n");
            string readTexT = File.ReadAllText(html_path);
            Console.WriteLine(readTexT);
                
            Console.WriteLine("-----------------------------------------");            

            Console.WriteLine("\n");
        }
    }
}