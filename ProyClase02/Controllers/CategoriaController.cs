using ProyClase02.Models.Conection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyClase02.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            try
            {
                //ConectionBD db = new ConectionBD();

                List<tb_Categoria> listaCat;
                using (var db = new ConectionBD())  //db variable generica
                {
                    listaCat = db.tb_Categoria.ToList();
                    return View(listaCat);
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        [HttpGet] //Me retorne una vista
        public ActionResult Agregar(tb_Categoria cat)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                using (var db=new ConectionBD())
                {
                    db.tb_Categoria.Add(cat);//Agrega la informacion
                     db.SaveChanges();//Guarda la informacion
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);

                //throw;
                return View();
            }


            
        }
        public ActionResult Editar(int id)
        {
            try
            {
                using (var db=new ConectionBD())
                {
                   tb_Categoria cat = db.tb_Categoria.Find(id);
                    return View(cat);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        [HttpPost]
        public ActionResult Editar(tb_Categoria p_cat)
        {
            try
            {
                using (var db=new ConectionBD())
                {
                    tb_Categoria cat = db.tb_Categoria.Find(p_cat.idCategoria);
                    cat.nombreCategoria = p_cat.nombreCategoria;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                throw;
            }
     
        }

    }
    

}