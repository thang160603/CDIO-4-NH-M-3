using CDIO_4._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CDIO_4._1.Areas.Admin.Controllers
{
    public class DanhMucController : Controller
    {
        ApplicationDbContext db =new ApplicationDbContext();
        // GET: Admin/DanhMuc
        public ActionResult Index()
        {
            var items = db.DanhMucs;
            return View();
        }
        public ActionResult Add()
        {
            return View();  
        }
    }
}