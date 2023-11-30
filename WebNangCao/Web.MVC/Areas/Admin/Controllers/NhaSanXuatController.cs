using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.MVC.Models;

namespace Web.MVC.Areas.Admin.Controllers
{
    [Authorize]
    public class NhaSanXuatController : Controller
    {
        private readonly NhaSachEntities context = new NhaSachEntities();
        public int Create(NhaSanXuat nhaSanXuat)
        {
            try
            {
                context.NhaSanXuat.Add(nhaSanXuat);
                context.SaveChanges();
                return nhaSanXuat.Id;
            }
            catch
            {
                throw new Exception("Cannot insert");
            }
        }

        public ActionResult Index()
        {
            var NSX = context.NguoiDung.ToList();
            return View(NSX);
        }
    }
}