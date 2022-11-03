using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using mvc.Models;

namespace mvc.Controllers
{
    public class AccederController : Controller
    {
        //
        // GET: /Acceder/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Enter(string usuario, string password)
        {
            try
            {
                using (DBVEHICULOSEntities db = new DBVEHICULOSEntities())
                {
                    var read = from d in db.USER
                               where d.Email == usuario && d.PassWord == password && d.idEstatus == 1
                               select d;

                    if (read.Count() > 0)
                    {
                        Session["Usuario"] = read.First();
                        return Content("1");
                    }
                    else
                    {
                        return Content("Revise usuario y contraseña");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error: " + ex.Message);
            }
        }
    }
}