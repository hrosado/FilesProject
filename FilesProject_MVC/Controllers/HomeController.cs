using FilesProject_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using System.Linq;
using System.Threading.Tasks;

namespace FilesProject_MVC.Controllers
{
    public class HomeController : Controller
    {
        [Serializable]
        private class FileItems
        {
            public int FileID { get; set; }
            public string FileName { get; set; }
            public DateTime FileLastAccessTime { get; set; }
            public string FileSize { get; set; }

        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
  
        public ActionResult Index()
        {

            //string rootPath = @"C:\Users\CW2_Rosado\Documents\Repos\OEWIO2021\Content\OEWIO_PDFs\";
            //bool directoryExists = Directory.Exists(rootPath);

            //Console.WriteLine("The directory exists.");
            //string[] files = Directory.GetFiles(rootPath, "*.pdf", SearchOption.TopDirectoryOnly);
            //List<string> fileItems = new List<string>();
            //foreach (var file in files)
            //{
            //    var info = new FileInfo(file);
            //    //fileItems.Add(file);
            //    fileItems.Add(($"{ Path.GetFileName(file) },{ info.LastWriteTime },{info.Length } bytes"));

            //}

            //var list = new List<FileItems>();
            //int count = 0;
            //foreach (var line in fileItems)
            //{
            //    string[] entries = line.Split(',');
            //    FileItems newFileItem = new FileItems();

            //    count++;

            //    newFileItem.FileID = count;
            //    newFileItem.FileName = entries[0];
            //    newFileItem.FileLastAccessTime = Convert.ToDateTime(entries[1]);
            //    newFileItem.FileSize = entries[2];

            //    list.Add(newFileItem);

            //}
            //foreach (var li in list)
            //{
            //    Console.WriteLine($"{ li.FileID},{  li.FileName },{ li.FileLastAccessTime },{ li.FileSize } ");
            //}
            //string strResultJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            ////File.WriteAllText(@"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\Files_ConsoleApp\data\files.json", strResultJson);
            //return Json(strResultJson);

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
