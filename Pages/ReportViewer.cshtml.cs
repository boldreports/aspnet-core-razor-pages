﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspCoreRazorPages.Pages
{
    public class ReportViewerModel : PageModel
    {
        public string reportPath = "sales-order-detail.rdl";
        public string serviceUrl = "/api/ReportViewer";

        public void OnGet()
        {

        }
    }
}