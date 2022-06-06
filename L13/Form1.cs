using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wyklad5
{    
    public partial class Form1 : Form
    {
        private string file_name;  // @"ZBIOR_WEJSCIOWY";

        System.IO.FileSystemWatcher watcher;
        public Form1()
        {
            InitializeComponent();

            watcher = null;
        }
        /*Zaimplementować aplikację zapisującą dane z FileSystemWatcher do pliku txt       //bub do bazy danych sql (dla chętnych)

        1) plik tekstowy może być w dowolnym formacie np csv.
        2) aplikacja powinna umożliwiać filtrowanie zapisanych danych w/g wybranych kryteriów.
        3) aplikacja powinna wyświetlać listę wyszukanych elementów.

        Na zaimplementowanie aplikacji są przeznaczone 4h laboratoryjne.*/

        private void button4_Click(object sender, EventArgs e)
        {
            if (watcher == null)
            {
                watcher = new System.IO.FileSystemWatcher();
                //string path = Directory.GetCurrentDirectory();
                watcher.Path = @"C:\Users\Jakub\Desktop\lab13_c#\wyklad5\wyklad5\bin\Debug\watcher";
                watcher.NotifyFilter = System.IO.NotifyFilters.LastAccess
                                 | System.IO.NotifyFilters.LastWrite
                                 | System.IO.NotifyFilters.FileName
                                 | System.IO.NotifyFilters.DirectoryName;
                //watcher.Changed += OnChanged1;
                //watcher.Created += OnChanged1;
                //watcher.Deleted += OnChanged1;

                watcher.EnableRaisingEvents = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                watcher.Changed += OnChanged1;
            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                watcher.Created += OnChanged1;
            }
            catch (Exception ex)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                watcher.Deleted += OnChanged1;
            }
            catch (Exception ex)
            {
            }
        }

        private void OnChanged1(object source, System.IO.FileSystemEventArgs e)
        {
            string text = $"File: {e.FullPath} {e.ChangeType}";

            string[] lines = { text };

            this.Invoke(new Action<string>(LogWriter), new object[] { text });

            string path_current = Directory.GetCurrentDirectory();
            string path = @"C:\Users\Jakub\Desktop\lab13_c#\wyklad5\wyklad5\bin\Debug\watcher.txt";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
            {
                file.WriteLine(text);
            }
        }
       
        private void LogWriter(string text)
        { 
            textBox1.Text += text + Environment.NewLine;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            file_name = textBox3.Text;  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string partialName = file_name;

            //string path_current = Directory.GetCurrentDirectory();
            string path = @"C:\Users\Jakub\Desktop\lab13_c#\wyklad5\wyklad5\bin\Debug\watcher";

            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(path);

            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");
            DirectoryInfo[] dirInDir = hdDirectoryInWhichToSearch.GetDirectories(partialName);

            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                this.Invoke(new Action<string>(LogWriter1), new object[] {fullName});
            }

            foreach (DirectoryInfo foundFile in dirInDir)
            {
                string fullName1 = foundFile.FullName;
                this.Invoke(new Action<string>(LogWriter1), new object[] { fullName1 });
            }
        }

        private void LogWriter1(string text)
        { //2)
            textBox2.Text += text + Environment.NewLine;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
