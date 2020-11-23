using Crud2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud2020.Controllers
{
    public class FastSearchController : Controller
    {
        loginDBEntities db = new loginDBEntities();
        // GET: FastSearch
        public ActionResult Index(string searching)
        {
            return View(db.Users.Where(x=>x.UserName.Contains(searching) || searching == null).ToList());
        }
    }
}