using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using WMSWeb.Models;

namespace WMSWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController

       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UsuarioNoRegistrado()
        {
            ViewBag.Error = "No se encontro el Usuario";
            return View();
        }
        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: LoginController/Login
    

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public bool obtenerUsuarios(string usr, string pwd, string bd)
        {
            var intento = 0;
            do
            {
                using (Models.ESSENTIALWMSContext db = new Models.ESSENTIALWMSContext())
                {
                    var oUser = (from d in db.Usuario
                                 where d.CodUsuario.Equals(usr)
                                 select d).FirstOrDefault();

                    if (oUser == null)
                    {
                        intento++;
                        return false;

                    }
                    else
                    {
                        if (oUser.Clave == pwd)
                        {

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }

            } while (intento <= 3);
        }


       
    }
}
