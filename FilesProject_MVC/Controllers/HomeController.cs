using FilesProject_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FilesProject_MVC.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult GetData()
        {
            FileStream fs1;
            FileStream fs2;


            string consolePath = @"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\Files_ConsoleApp\data\";

            string path = @"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\FilesProject_MVC\wwwroot\data\";
            string fileName = "files.json";
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(consolePath, fileName);
            string destFile = System.IO.Path.Combine(path, fileName);

            // Open the two files.
            fs1 = new FileStream(sourceFile, FileMode.Open);
            fs2 = new FileStream(destFile, FileMode.Open);


            // Check if file exists
            if (System.IO.File.Exists(path + fileName))
            {
                // Check if the file is empty
                if((fs1.Length > fs2.Length))
                {
                    // Close the file
                    fs1.Close();
                    fs2.Close();
                    System.IO.File.Copy(sourceFile, destFile, true);
                }

                try
                {

                    string jsonString = System.IO.File.ReadAllText(@"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\FilesProject_MVC\wwwroot\data\files.json");

                    var fileItem = JsonConvert.DeserializeObject<List<FileItem>>(jsonString);

                    return Json(new { data = fileItem });
                }
                catch (Exception ex)
                {

                    return Json(ex.Message.ToString());
                }
            } else
            {
                FileStream fs = System.IO.File.Create(path + fileName);
                GetData();
                return Json("");
            }

        }
        public ActionResult Index()
        {
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
