using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaInventario.DAL;
using SistemaInventario.Models;

namespace SistemaInventario.Controllers
{
    public class RegistroUsuariosController : Controller
    {
        private InventarioDB db = new InventarioDB();

        // GET: RegistroUsuarios
        public ActionResult Index()
        {
            return View(db.usuario.ToList());
        }

        // GET: RegistroUsuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroUsuario registroUsuario = db.usuario.Find(id);
            if (registroUsuario == null)
            {
                return HttpNotFound();
            }
            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroUsuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioID,Nombre,Apellido,Telefono,Clave,ValidaClave,Tipo,Fecha")] RegistroUsuario registroUsuario)
        {
            if (ModelState.IsValid)
            {
                db.usuario.Add(registroUsuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroUsuario registroUsuario = db.usuario.Find(id);
            if (registroUsuario == null)
            {
                return HttpNotFound();
            }
            return View(registroUsuario);
        }

        // POST: RegistroUsuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioID,Nombre,Apellido,Telefono,Clave,ValidaClave,Tipo,Fecha")] RegistroUsuario registroUsuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registroUsuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registroUsuario);
        }

        // GET: RegistroUsuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroUsuario registroUsuario = db.usuario.Find(id);
            if (registroUsuario == null)
            {
                return HttpNotFound();
            }
            return View(registroUsuario);
        }

        // POST: RegistroUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroUsuario registroUsuario = db.usuario.Find(id);
            db.usuario.Remove(registroUsuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
