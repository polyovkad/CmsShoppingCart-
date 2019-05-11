using CmsShoppingCart.Models.Data;
using CmsShoppingCart.Models.Data.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CmsShoppingCart.Areas.Admin.Controllers
{
    public class PagesController : Controller
    {
        // GET: Admin/Pages
        public ActionResult Index()
        {
            //Declare list of PageVM
            List<PageVM> pageList;

            //Init the list
            using (Db db = new Db())
            {
                //Init the list
                pageList = db.Pages.ToArray().OrderBy(x => x.Sorting).Select(x => new PageVM(x)).ToList();
            }
            //Return view with list
            return View(pageList);
        }

        // GET: Admin/Pages/AddPage
        public ActionResult AddPage()
        {
            return View();
        }
    }
}