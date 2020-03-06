using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LAB_4_ASP_FINAL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LAB_4_ASP_FINAL.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        
        
        public ActionResult OnPostTxt()
        {
            
            return File("/Data/Txt.txt", "application/octet-stream",
            "NewTxt.txt");
           
        }

        public ActionResult OnPostPdf()
        {
            return File("/Data/Pdf.pdf", "application/octet-stream",
            "NewPdf.pdf");
        }

        public ActionResult OnPostHtml()
        {
            return File("/Data/Html.html", "application/octet-stream",
            "NewHtml.html");
        }
    }
}
