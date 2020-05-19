using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspCoreRazorPages.Pages
{
    public class ReportDesignerModel : PageModel
    {
        public string serviceUrl = "/api/ReportDesigner";
        public void OnGet()
        {

        }
    }
}