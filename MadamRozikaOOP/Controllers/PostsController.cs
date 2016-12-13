using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MadamRozikaData.Services;

namespace MadamRozikaOOP.Controllers
{
    public class PostsController : Controller
    {
        // GET: Post
        public ActionResult Post(int nid)
        {
            using (PostsService hs = new PostsService())
            {
                var poobj = hs.GetPostContentDto(nid);

                return View(poobj);
            } 
        }

    }
}
