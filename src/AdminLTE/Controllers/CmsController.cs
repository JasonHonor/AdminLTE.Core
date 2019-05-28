using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLTE.Models.CmsViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Controllers
{
    public class CmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Test(CmsIndexViewModel model, string returnUrl = null)
        {
            return View();  //search for view: /View/Cms/Test.cshtml,/Views/Shared/Test.cshtml,/Pages/Shared/Test.cshtml
        }
        
    }
}