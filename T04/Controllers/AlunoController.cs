using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T04.Models;
using T04.Services;

namespace T04.Controllers
{
    public class AlunoController : Controller
    {
        List<Aluno> db;

        public AlunoController(IBanco banco)
        {
            db = banco.Alunos;
        }
        

        // GET: AlunoController
        public ActionResult Index()
        {
            return View(db);
        }

        // GET: AlunoController/Details/5
        public ActionResult Details(int id)
        {
            Aluno al = db.Find(a => a.RA == id);

           return View(al);
        }

        // GET: AlunoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlunoController/Create
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

        // GET: AlunoController/Edit/5
        public ActionResult Edit(int id)
        {
            Aluno al = db.Find(a => a.RA == id);

            return View(al);
        }

        // POST: AlunoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                int pos = db.FindIndex(a => a.RA == id);
                db[pos].Name = collection["Name"];
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunoController/Delete/5
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
    }
}
