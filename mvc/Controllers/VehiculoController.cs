using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using mvc.Models;
using mvc.Models.TableVewModel;

using mvc.Models.ViewModels;
namespace mvc.Controllers
{
    public class VehiculoController : Controller
    {
        // GET: Vehiculo
        public ActionResult Index()
        {
            List<VehiculoTableViewModel> lst = null;

            using (DBVEHICULOSEntities db = new DBVEHICULOSEntities())
            {
                lst = (from d in db.VEHICULO
                       orderby d.ID
                       
                       select new VehiculoTableViewModel
                       {
                           ID = d.ID,
                           Marca = d.MARCA,
                           Modelo = d.MODELO,
                           Año = d.nYEAR,
                           Condicion = d.CONDICION,
                           Imagen = d.FOTOS
                       }).ToList();
            }



            return View(lst);
        }

        [HttpGet]
        public ActionResult Add()
        {


            return View();
        }

        [HttpPost]
        public ActionResult  Add(VehiculoViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}
            using(var db = new DBVEHICULOSEntities())
            {
                VEHICULO oVehiculo = new VEHICULO();
                oVehiculo.MARCA = model.Marca;
                oVehiculo.MODELO = model.Modelo;
                oVehiculo.nYEAR = model.Año;
                oVehiculo.CONDICION = model.Condicion;
                oVehiculo.FOTOS = model.Foto;
                

                db.VEHICULO.Add(oVehiculo);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Vehiculo/"));
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            EditVehiculoViewModel model = new EditVehiculoViewModel();
            using(var db = new DBVEHICULOSEntities())
            {
                var oVehiculo = db.VEHICULO.Find(Id);
                model.Marca = oVehiculo.MARCA;
                model.Modelo = oVehiculo.MODELO;
                model.Año = oVehiculo.nYEAR;
                model.Condicion = oVehiculo.CONDICION;
                model.Foto = oVehiculo.FOTOS;
            }

            return View(model) ;
        }

        [HttpPost]
        public ActionResult Edit(EditVehiculoViewModel model)
        {
            using(var db = new DBVEHICULOSEntities())
            {
                var oVehiculo = db.VEHICULO.Find(model.ID);
                oVehiculo.MARCA = model.Modelo;
                oVehiculo.MODELO = model.Modelo;
                oVehiculo.nYEAR = model.Año;
                oVehiculo.CONDICION = model.Condicion;
                oVehiculo.FOTOS = model.Foto;

                db.Entry(oVehiculo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Redirect(Url.Content("~/Vehiculo/"));
            }

            
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            using (var db = new DBVEHICULOSEntities())
            {
                var oVehiculo = db.VEHICULO.Find(Id);
                db.VEHICULO.Attach(oVehiculo);
                db.VEHICULO.Remove(oVehiculo);

                db.SaveChanges();

                return Content("1");
            }
        }
    }
}