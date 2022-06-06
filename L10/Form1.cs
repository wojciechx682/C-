using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        /*
         W katalogu \bin\Debug tego projektu znajdują się 3 pliki png
         Do pierwszego pola tekstowego formularza należy wprowadzić nazwę zbioru wejściowego
         kolejne 3 pola tekstowe to podfoldery
         naciśnięcie przycisku button1 powoduje akcję skopiowania 3 plików graficznych z \bin\Debug
         do odpowiednich podfolderów zbioru wejściowego, oraz do albumu wyjściowego */

        private string folder_wejsciowy;  // @"ZBIOR_WEJSCIOWY";
        private string folder_wyjsciowy;  // @"ALBUM_WYJSCIOWY'';
        private string subfolder1;        // "OD_ANI"
        private string subfolder2;        // "OD_BARTKA"
        private string subfolder3;        // "OD_KOGOS"
        private string podkatalog_nr_1;   // @"ZBIOR_WEJSCIOWY\OD_ANI"
        private string podkatalog_nr_2;   // @"ZBIOR_WEJSCIOWY\OD_BARTKA"
        private string podkatalog_nr_3;   // @"ZBIOR_WEJSCIOWY\OD_KOGOS"

        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {            
            folder_wejsciowy = textBox1.Text;  // "ZBIOR_WEJSCIOWY"
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {            
            subfolder1 = textBox2.Text;                              // "OD_ANI"
            podkatalog_nr_1 = folder_wejsciowy + "\\" + subfolder1;  // <-- ZBIOR_WEJSCIOWY\OD_ANI
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {            
            subfolder2 = textBox3.Text;                              // "OD_BARTKA"
            podkatalog_nr_2 = folder_wejsciowy + "\\" + subfolder2;  // <-- ZBIOR_WEJSCIOWY\OD_BARTKA

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            subfolder3 = textBox4.Text;                              // "OD_KOGOS"
            podkatalog_nr_3 = folder_wejsciowy + "\\" + subfolder3;  // <-- ZBIOR_WEJSCIOWY\OD_KOGOS

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {            
            folder_wyjsciowy = textBox5.Text; //"ALBUM_WYJŚCIOWY"            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String katalog1 = folder_wejsciowy;
            String katalog2 = podkatalog_nr_1;
            String katalog3 = podkatalog_nr_2;
            String katalog4 = podkatalog_nr_3;
            String katalog5 = folder_wyjsciowy;

            DirectoryInfo di1 = new DirectoryInfo(katalog1);
            DirectoryInfo di2 = new DirectoryInfo(katalog2);
            DirectoryInfo di3 = new DirectoryInfo(katalog3);
            DirectoryInfo di4 = new DirectoryInfo(katalog4);
            DirectoryInfo di5 = new DirectoryInfo(katalog5);          

            try
            {
                di1.Create();
                di2.Create();
                di3.Create();
                di4.Create();
                di5.Create();                
            }
            catch (IOException)
            {
            }

            string fileName1 = "1.png";
            string sourcePath1 = ".";
            string targetPath1 = podkatalog_nr_1;
            string sourceFile1 = System.IO.Path.Combine(sourcePath1, fileName1);
            string destFile1 = System.IO.Path.Combine(targetPath1, fileName1);
            System.IO.File.Copy(sourceFile1, destFile1, true);

            string fileName2 = "2.png";
            string sourcePath2 = ".";
            string targetPath2 = podkatalog_nr_2;
            string sourceFile2 = System.IO.Path.Combine(sourcePath2, fileName2);
            string destFile2 = System.IO.Path.Combine(targetPath2, fileName2);
            System.IO.File.Copy(sourceFile2, destFile2, true);

            string fileName3 = "3.png";
            string sourcePath3 = ".";
            string targetPath3 = podkatalog_nr_3;
            string sourceFile3 = System.IO.Path.Combine(sourcePath3, fileName3);
            string destFile3 = System.IO.Path.Combine(targetPath3, fileName3);
            System.IO.File.Copy(sourceFile3, destFile3, true);

            //DirectoryInfo di11 = new DirectoryInfo(folder_wejsciowy);

            DirectoryInfo di = new DirectoryInfo(folder_wejsciowy);
            System.IO.DirectoryInfo dirInfo = di;
            System.IO.FileInfo[] fileNames1 = dirInfo.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            DirectoryInfo dir = new DirectoryInfo(folder_wejsciowy);
            DirectoryInfo dir1 = new DirectoryInfo(folder_wyjsciowy);

            DirectoryInfo[] katalogi = dir.GetDirectories();
            FileInfo[] pliki = dir.GetFiles();

            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
                        

            foreach (System.IO.FileInfo fi in fileNames)
            {
                string fileName_1 = fi.Name;                

                string new_fileName1 = fi.CreationTime.ToString();
                string new_fileName2 = fi.DirectoryName;
                string sourcePath = fi.DirectoryName;
                string newName = new_fileName1 + " " + new_fileName2;

                

                string targetPath = folder_wyjsciowy;

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName_1);
                string destFile = System.IO.Path.Combine(targetPath, fileName_1);
                string destFilee = System.IO.Path.Combine(targetPath, fileName_1);

                System.IO.Directory.CreateDirectory(targetPath);


                if (!File.Exists(destFilee))
                {
                    File.Copy(sourceFile, destFilee);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
