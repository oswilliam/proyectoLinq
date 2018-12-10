using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejemplo0212.Models;

namespace Ejemplo0212.Controllers
{
    public class EstudiController : Controller
    {
        Estudiantes db = new Estudiantes();
        // GET: Estudi
        public ActionResult Index()
        {

            var listado = db.Lista();
            return View(listado.ToList());
        }
         [HttpPost]
         public ActionResult Index(string txtbuscar,string select)
         {
            var query = from tbl in db.Lista() select tbl;
           switch (select)
           {
                case "value1":
                    var query1 = from p in db.Lista() where p.Materia.Contains(txtbuscar) select p;
                 return View(query1.ToList());
               case "value2":
                 int a = Convert.ToInt32(txtbuscar);
                   var query2 = from j in db.Lista() where j.Carnet == a select j;
                   return View(query2.ToList());
              case "value3":
                  var query3 = from n in db.Lista() where n.Nombre.Contains(txtbuscar) select n;
                  return View(query3.ToList());
               case "value4":
                   double e = Convert.ToDouble(txtbuscar);
                   var query4 = from o in db.Lista() where o.Promedio == e select o;
                    return View(query4.ToList());
           }


           return View(query.ToList());

         }
       
           
    }
}