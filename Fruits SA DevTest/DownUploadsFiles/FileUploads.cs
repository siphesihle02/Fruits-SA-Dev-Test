﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DownUploadsFiles
{
    public class FileUpload
    {
         [Key]
        public string FileId { get; set; }
        
        public string FileName { get; set; }
        public long Size { get; set; }
        
        public IEnumerable<HttpPostedFileBase> files { get; set; }
    }
}

