using Quieropizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quieropizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.id = 1;
            producto1.Descripcion = "Pizza jamon y queso";

            var producto2 = new ProductoModel();
            producto2.id = 2;
            producto2.Descripcion = "Pizza 4 estaciones";

            var producto3 = new ProductoModel();
            producto3.id = 3;
            producto3.Descripcion = "Pizza vegetariana";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);



            return View(listadeproductos);
        }
    }
}