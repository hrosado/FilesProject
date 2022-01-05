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


            // string consolePath = @"C:\Users\CW2_Rosado\Documents\Repos\FilesProject\Files_ConsoleApp\data\";
            string consolePath = @"C:\Users\1260021520E\Documents\09_APL\FilesProject\Files_ConsoleApp\data\";

            // string path = @"C:\Users\CW2_Rosado\Documents\Repos\FilesProject\FilesProject_MVC\data\";
            string path = @"C:\Users\1260021520E\Documents\09_APL\FilesProject\FilesProject_MVC\data\";
            string fileName = "files.json";
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(consolePath, fileName);
            string destFile = System.IO.Path.Combine(path, fileName);




            // Check if file exists
            if (System.IO.File.Exists(path + fileName))
            {
                //// Open the two files.
                //fs1 = new FileStream(sourceFile, FileMode.Open);
                //fs2 = new FileStream(destFile, FileMode.Open);
                //// Check if the file is empty
                //if ((fs1.Length > fs2.Length))
                //{
                //    // Close the file
                //    fs1.Close();
                //    fs2.Close();
                //    System.IO.File.Copy(sourceFile, destFile, true);
                //}

                try
                {
<<<<<<< HEAD
<<<<<<< HEAD
                    // Dell
                    //string jsonString = System.IO.File.ReadAllText(@"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\FilesProject_MVC\wwwroot\data\files.json");
                    string jsonString = System.IO.File.ReadAllText(@"C:\Users\CW2_Rosado\OneDrive\Documents\Repos\FilesProject\FilesProject_MVC\wwwroot\data\files.json");
=======
=======
                    // string jsonString = System.IO.File.ReadAllText(@"C:\Users\CW2_Rosado\Documents\Repos\FilesProject\FilesProject_MVC\data\files.json");
>>>>>>> Hyperlinks

                    string jsonString = System.IO.File.ReadAllText(@"C:\Users\1260021520E\Documents\09_APL\FilesProject\FilesProject_MVC\data\files.json");
>>>>>>> b35cb0d98f156b1bdedd11968891a56a8e8b9db7



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
