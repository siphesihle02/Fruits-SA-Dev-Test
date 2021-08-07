using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fruits_SA_Devloper_Test.Controllers
{
    public class downloadController : Controller
    {
        private object _FileName;

        // GET: download
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult downlaod()
        {
            var dir = new System.IO.DirectoryInfo(Server.MapPath("~/UploadedFiles"), _FileName);
            System.IO.FileInfo[] fileNames = dir.GetFiles("*.*"); List<string> items = new List<string>();
            foreach (var file in fileNames)
            {
                items.Add(file.Name);
            }
            return View(items);
        }

        public FileResult Download(string ImageName)
        {
            var FileVirtualPath = "~/App_Data/uploads/" + ImageName;
            return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath));
            return View();
        }
    }
}