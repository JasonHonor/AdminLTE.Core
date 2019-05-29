using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.ViewComponents
{
    public class CmsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string filter)
        {
            /*search view path:
                /Views/Cms/Components/Cms/header.cshtml
                /Views/Shared/Components/Cms/header.cshtml
                /Pages/Shared/Components/Cms/header.cshtml
            */
            return View("header");
        }
    }
}
