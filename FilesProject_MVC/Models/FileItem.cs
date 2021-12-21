using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilesProject_MVC.Models
{
    public class FileItem
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public DateTime FileLastAccessTime { get; set; }
        public string FileSize { get; set; }


    }
}
