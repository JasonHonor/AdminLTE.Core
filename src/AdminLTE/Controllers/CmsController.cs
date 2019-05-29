using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLTE.Common;
using AdminLTE.Models;
using AdminLTE.Models.CmsViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static AdminLTE.Common.ModuleHelper;

namespace AdminLTE.Controllers
{
    public class CmsController : Controller
    {
        public static void CreateSideBarMenu(List<SidebarMenu> sidebars)
        {
            sidebars.Add(ModuleHelper.AddTree("Cms"));
            sidebars.Last().TreeChild = new List<SidebarMenu>()
            {
                AddModule(ModuleHelper.Module.CmsCreateProject),
                AddModule(ModuleHelper.Module.CmsCreateGroup),
                AddModule(ModuleHelper.Module.CmsCreatePage),
            };
        }

        public static SidebarMenu AddModule(Module module, Tuple<int, int, int> counter = null)
        {
            if (counter == null)
                counter = Tuple.Create(0, 0, 0);

            switch (module)
            {
                case Module.CmsCreateProject:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Create Project",
                        IconClassName = "fa fa-link",
                        URLPath = "/Cms/Project/create",
                        LinkCounter = counter,
                    };

                case Module.CmsCreateGroup:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Create Group",
                        IconClassName = "fa fa-link",
                        URLPath = "/Cms/Group/create",
                        LinkCounter = counter,
                    };

                case Module.CmsCreatePage:
                    return new SidebarMenu
                    {
                        Type = SidebarMenuType.Link,
                        Name = "Create Group",
                        IconClassName = "fa fa-link",
                        URLPath = "/Cms/Page/create",
                        LinkCounter = counter,
                    };

                default:
                    break;
            }

            return null;
        }

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

        public IActionResult Group(string id)
        {
            return View(id+"_group");
        }

        public IActionResult Project(string id)
        {
            return View(id+"_project");
        }
    }
}