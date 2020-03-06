using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LAB_4_ASP_FINAL.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace LAB_4_ASP_FINAL.Services
{
    public class Html : IFileService
    { 
       public ActionResult Download()
        {
            return File("/Data/Txt.txt", "application/octet-stream",
            "NewTxt.txt");
        }

       
    }
}

