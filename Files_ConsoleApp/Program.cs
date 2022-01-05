using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;


namespace Files_ConsoleApp
{
    class Program
    {
        [Serializable]
        private class FileItems
        {
            public int FileID { get; set; }
            public string FileName { get; set; }
            public DateTime FileLastAccessTime { get; set; }
            public string FileSize { get; set; }

        }
        static void Main(string[] args)
        {

            // string rootPath = @"C:\Users\CW2_Rosado\Documents\Repos\OEWIO2021\Content\OEWIO_PDFs\";
<<<<<<< HEAD

            // Dell
            // string rootPath = @"C:\Users\CW2_Rosado\Documents\Repos\OEWIO2021\Content\OEWIO_PDFs\TestDir\";
            string rootPath = @"C:\Users\hommy\Documents\Repos\OEWIO2021\Content\OEWIO_PDFs\TestDir\";
=======
            //string rootPath = @"C:\Users\CW2_Rosado\Documents\Repos\OEWIO2021\Content\OEWIO_PDFs\TestDir\";
            string rootPath = @"\\hqcuilms.area52.afnoapps.usaf.mil\E\DLL_Reengineering\Dependencies_x64_Release\";

>>>>>>> b35cb0d98f156b1bdedd11968891a56a8e8b9db7
            bool directoryExists = Directory.Exists(rootPath);

            if (directoryExists)
            {
                Console.WriteLine("The directory exists.");
                string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
                List<string> fileItems = new List<string>();
                foreach (var file in files)
                {
                    var info = new FileInfo(file);
                    //fileItems.Add(file);
                    fileItems.Add(($"{ Path.GetFileName(file) },{ info.LastWriteTime },{info.Length } bytes"));

                }

                var list = new List<FileItems>();
                int count = 0;
                foreach (var line in fileItems)
                {
                    string[] entries = line.Split(',');
                    FileItems newFileItem = new FileItems();

                    count++;

                    newFileItem.FileID = count;
                    newFileItem.FileName = entries[0];
                    newFileItem.FileLastAccessTime = Convert.ToDateTime(entries[1]);
                    newFileItem.FileSize = entries[2];

                    list.Add(newFileItem);

                }
                foreach (var li in list)
                {
                    Console.WriteLine($"{ li.FileID},{  li.FileName },{ li.FileLastAccessTime },{ li.FileSize } ");
                }
                string strResultJson = JsonConvert.SerializeObject(list, Formatting.Indented);
<<<<<<< HEAD
                File.WriteAllText(@"C:\Users\hommy\Documents\Repos\FilesProject\Files_ConsoleApp\data\files.json", strResultJson);

                // Dell
                //File.WriteAllText(@"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\Files_ConsoleApp\data\files.json", strResultJson);
=======
                File.WriteAllText(@"C:\Users\1260021520E\Documents\09_APL\FilesProject\Files_ConsoleApp\data\files.json", strResultJson);
>>>>>>> b35cb0d98f156b1bdedd11968891a56a8e8b9db7

            }
            else
            {
                // Provide warning
                // Remote folder not accesible and dir cannot be updated.
                Console.WriteLine("The directory DOES NOT exist.");
            }

        }

    }
}
