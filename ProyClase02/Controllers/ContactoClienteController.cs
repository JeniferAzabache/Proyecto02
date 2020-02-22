using ProyClase02.Models.BEAN;
using ProyClase02.Models.Conection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyClase02.Controllers
{
    public class ContactoClienteController : Controller
    {
        // GET: ContactoCliente
        public ActionResult Index()
        {
            try
            {
           
                using (var db = new ConectionBD())  //db variable generica
                {
                    var lista = from cc in db.tb_ContactoCliente
                                join c in db.tb_Colaborador on cc.idColaborador equals c.idColaborador
                                join cl in db.tb_Cliente on cc.tb_Cliente equals cl.idCliente
                                select new ContactoClienteBEAN
                                {
                                    idContactibilidad=cc.idContactabilidad,
                                    idColaborador=cc.idColaborador,
                                    NombreColaborador = c.nombreColaborador + " " + c.apellidoColaborador,
                                    fechaContactoCliente=cc.fechaContactoCliente,
                                    idCliente=cc.idCliente,
                                    NombreCliente=cl.nombreCliente+" "+cl.apellidosCliente
                                    NombreProducto=p.nombreProducto


                                    //idContactibilidad = cc.idContactibilidad,
                                    //idColaborador = cc.idColaborador,
                                    //NombreColaborador = c.nombreColaborador + " " + c.apellidoColaborador,
                                    //fechaContactoCliente= cc.fechaContactoCliente,
                                    //idCliente = cc.idCliente
                                };

                    // List < tb_ContactoCliente > listaClie = db.tb_ContactoCliente.ToList();
                    List<ContactoClienteBEAN> listClie = lista.ToList();
                    return View(listClie);
                }
            }
            catch (Exception)
            {

                throw;
            }

            
        }
        public ActionResult Agregar()
        {

            //Model pasar informacion por medio del view
            //ViewBag
            //List<tb_Producto> listProd;

            using (var db =new ConectionBD())
            {
                //listProd = db.tb_Producto.ToList();
                //ViewBag.ListaProductos = listProd;

                var items = new List<SelectListItem>();
                items = db.tb_Producto.Select(
                    c => new SelectListItem()
                    {
                        Value = c.idProducto.ToString(),
                        Text = c.nombreProducto
                    }).ToList();
            ViewBag.ListaProductos = items;
            
            }
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(tb_ContactoCliente)
        {
            return View();
        }
    }
}