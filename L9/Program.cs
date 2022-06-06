using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L9_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            String katalog1 = @"ZBIOR_WEJSCIOWY";
            string katalog2 = @"ZBIOR_WEJSCIOWY\OD_ANI";
            string katalog3 = @"ZBIOR_WEJSCIOWY\OD_BARTKA";
            string katalog4 = @"ZBIOR_WEJSCIOWY\OD_KOGOS";
                     

            DirectoryInfo di1 = new DirectoryInfo(katalog1);
            DirectoryInfo di2 = new DirectoryInfo(katalog2);
            DirectoryInfo di3 = new DirectoryInfo(katalog3);
            DirectoryInfo di4 = new DirectoryInfo(katalog4);       
          
                try
                {
                    di1.Create();
                    Console.WriteLine("Katalog {0} zostal utworzony.", katalog1);

                    di2.Create();
                    Console.WriteLine("Katalog {0} zostal utworzony.", katalog2);

                    di3.Create();
                    Console.WriteLine("Katalog {0} zostal utworzony.", katalog3);

                    di4.Create();
                    Console.WriteLine("Katalog {0} zostal utworzony.", katalog4);                   
                }
                catch (IOException)
                {
                }

            string fileName1 = "1.png";
            string sourcePath1 = ".";
            string targetPath1 = @"ZBIOR_WEJSCIOWY\OD_ANI";
            string sourceFile1 = System.IO.Path.Combine(sourcePath1, fileName1);
            string destFile1 = System.IO.Path.Combine(targetPath1, fileName1);
            System.IO.File.Copy(sourceFile1, destFile1, true);

            string fileName2 = "2.png";
            string sourcePath2 = ".";
            string targetPath2 = @"ZBIOR_WEJSCIOWY\OD_BARTKA";
            string sourceFile2 = System.IO.Path.Combine(sourcePath2, fileName2);
            string destFile2 = System.IO.Path.Combine(targetPath2, fileName2);
            System.IO.File.Copy(sourceFile2, destFile2, true);


            string fileName3 = "3.png";
            string sourcePath3 = ".";
            string targetPath3 = @"ZBIOR_WEJSCIOWY\OD_KOGOS";
            string sourceFile3 = System.IO.Path.Combine(sourcePath3, fileName3);
            string destFile3 = System.IO.Path.Combine(targetPath3, fileName3);
            System.IO.File.Copy(sourceFile3, destFile3, true);

            DirectoryInfo di11 = new DirectoryInfo("ZBIOR_WEJSCIOWY"); 

            DirectoryInfo di = new DirectoryInfo("ZBIOR_WEJSCIOWY");
            System.IO.DirectoryInfo dirInfo = di;
            System.IO.FileInfo[] fileNames1 = dirInfo.GetFiles("*.*", System.IO.SearchOption.AllDirectories);


            Console.WriteLine("\nZawartość katalogu ZBIOR_WEJSCIOWY:");
            DirectoryInfo dir = new DirectoryInfo("ZBIOR_WEJSCIOWY");
            DirectoryInfo dir1 = new DirectoryInfo(@".\ALBUM_WYJSCIOWY"); 

            DirectoryInfo[] katalogi = dir.GetDirectories();
            FileInfo[] pliki = dir.GetFiles();

            Console.WriteLine("\n--PODKATALOGI--");
            foreach (DirectoryInfo katalog in katalogi)
            {
                Console.WriteLine(katalog.Name);
            }

            //System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*", System.IO.SearchOption.AllDirectories);
            Console.WriteLine("\n--PLIKI--");
            foreach (System.IO.FileInfo fi in fileNames1)
            {
                Console.WriteLine("{0} (katalog: {1})", fi.Name, fi.Directory);
            }

            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            Console.WriteLine("\nZawartość katalogu ALBUM_WYJSCIOWY:");

            string[] stringArray = new string[3];
            foreach (System.IO.FileInfo fi in fileNames)
            {
                Console.WriteLine("Nazwa: {0}, Czas utworzenia: {1}, Nazwa katalogu: {2}", fi.Name, fi.CreationTime, fi.DirectoryName);               

                string fileName_1 = fi.Name;
                    stringArray[0] = fi.CreationTime.ToString();
               
                    //string fileName_2 = fi.CreationTime.ToString(); 
                    string new_fileName1 = fi.CreationTime.ToString();
                    string new_fileName2 = fi.DirectoryName;
                string sourcePath = fi.DirectoryName;
                    string newName = new_fileName1 + " " + new_fileName2;

                int i = 1;

                string targetPath = @".\ALBUM_WYJSCIOWY";
                //string sourcePath1 = ".";

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName_1);
                string destFile = System.IO.Path.Combine(targetPath, fileName_1);
                string destFilee = System.IO.Path.Combine(targetPath, fileName_1);
                //i++;
                System.IO.Directory.CreateDirectory(targetPath);
                //System.IO.File.Copy(sourceFile, destFile, true);

                //File.Copy(sourceFile, destFile);
                if(!File.Exists(destFilee))
                {
                    File.Copy(sourceFile, destFilee);
                }                   
                   
                //string sourceFile = System.IO.Path.Combine(sourcePath, fileName_1);
                //string destFile = System.IO.Path.Combine(targetPath, fileName_1);
                //System.IO.File.Move("C:\Users\Jakub\source\repos\L9_CSHARP\bin\Debug\ALBUM_WYJSCIOWY\1.png", "asd.png");
                // string destFile = System.IO.Path.Combine(targetPath1, fileName_1);
                //System.IO.File.Copy(fileName_1, destFile, true);
                //string sourcePath_1 = ".";
            }            
            //System.IO.File.Copy(sourceFile1, destFile1, true);
            //System.IO.File.Move(@"C:\Users\Jakub\source\repos\L9_CSHARP\bin\Debug\ALBUM_WYJSCIOWY\1.png");
            

        }
    }
}
