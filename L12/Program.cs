using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;


namespace lab12_c_sharp
{    
    //  \bin\Debug  <- w tym katalogu następuje tworzenie folderu 'backup'

    public class Watcher
    {
        static int i = 0;
        public static void Main()
        {
            Console.WriteLine("If on any of the files in directory: \"bin\\Debug\\folder\" will change, a folder named \"backup\" will be created in \\bin\\Debug containing copies of the files\n");

            // Wskazanie backupowanego folderu
            var vi = @".\folder";
            Console.WriteLine(vi.ToString());

            DirectoryInfo di = new DirectoryInfo(vi);

            System.IO.DirectoryInfo dirInfo = di;

            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*", System.IO.SearchOption.AllDirectories);

            Console.WriteLine("\nFiles:");
            foreach (System.IO.FileInfo fi in fileNames)
            {               
                Console.WriteLine("Name: {0}", fi.Name);
            }         
            Run(".");
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private static void Run(string args) 
        {
            string args1 = @".\folder";         
       
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = args1;
                
                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;
                
                watcher.Filter = "*.*";
                
                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;
                
                watcher.EnableRaisingEvents = true;
                
                Console.WriteLine("Press 'q' to exit.");
                while (Console.Read() != 'q') ;
            }
        }
        
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            string targetPath = @".\backup"; 

            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
            Console.WriteLine("Directory: " + targetPath + " has been updated ");
           
            DirectoryInfo dir = new DirectoryInfo(@".\folder");

            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            
            foreach (System.IO.FileInfo fi in fileNames)
            {              
                string fileName_1 = fi.Name;
                
                string sourcePath = fi.DirectoryName;                

                string sourceFile = System.IO.Path.Combine(sourcePath, fileName_1);    
                
                string destFile = System.IO.Path.Combine(targetPath, fileName_1);
                
                if(!Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                
                File.Copy(sourceFile, destFile, true);
            }
            i++;
        }
    private static void OnRenamed(object source, RenamedEventArgs e) =>            
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
    }
}