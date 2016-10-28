using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MadamRozikaData.Services;

namespace MadamRozikaOOP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _MenuPartial()
        {
            var service = new HeaderMenuService();
            return PartialView(service.GetMenu());
        }

        public PartialViewResult _HeaderBandPartial()
        {
            var service = new HeaderBandService();
            return PartialView(service.GetHeaderNews());
        }

        public PartialViewResult _FooterPartial()
        {
            var service = new FooterService();
            return PartialView(service.GetFooter());
        }
    }
}