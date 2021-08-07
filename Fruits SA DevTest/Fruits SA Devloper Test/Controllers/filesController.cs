﻿using DownUploadsFiles;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace Fruits_SA_Devloper_Test.Controllers
{
    public class filesController : Controller
    {
        private Db.productsDatabase db = new Db.productsDatabase();
        // GET: files
        public ActionResult Index()
        {
            List<FileUpload> files = new List<FileUpload>();
            foreach (string strfile in Directory.GetFiles(Server.MapPath("~/Files")))
            {
                FileInfo fi = new FileInfo(strfile);
                FileUpload obj = new FileUpload();

                obj.FileName = fi.Name;
                obj.Size = fi.Length;
                files.Add(obj);

                
            }
            return View(files);
        }
        public ActionResult Download(string fileName)
        {
            string fullPath = Path.Combine(Server.MapPath("~/Files"), fileName);
            byte[] fileBytes = System.IO.File.ReadAllBytes(fullPath);
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        [HttpPost]
        public ActionResult Index(FileUpload doc)
        {
            foreach (var file in doc.files)
            {

                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(Server.MapPath("~/Files"), fileName);
                    file.SaveAs(filePath);
                }
            }
            TempData["Message"] = "files uploaded successfully";
            return RedirectToAction("Index");
        }
    }
    }
