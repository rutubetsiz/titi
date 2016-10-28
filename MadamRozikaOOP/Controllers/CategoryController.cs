using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MadamRozikaData.Services;

namespace MadamRozikaOOP.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index(string categoryurl="moda", int sayfaid=0)
        {
            var service = new CategoryService();
            return View(service.GetNewsList(categoryurl));
        }
    }
}