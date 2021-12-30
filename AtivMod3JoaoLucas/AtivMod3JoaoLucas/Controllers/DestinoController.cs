using AgenciaViagens.Data;
using AgenciaViagens.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagens.Controllers
{
    public class DestinoController : Controller 
    {
        private readonly ContaContext _context;

        public DestinoController(ContaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Destino> ListaDestino = _context.Destinos;
            return View(ListaDestino);
        }

        public IActionResult Destinos()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destino novoDestino)
        {
            if (ModelState.IsValid)
            {
                _context.Destinos.Add(novoDestino);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult EditarDestino(int id)
        {
            var nomeDestino = _context.Destinos.Find(id);
            if (nomeDestino == null)
            {
                return RedirectToAction("Index");
            }
            return View(nomeDestino);
        }

        [HttpPost]
        public IActionResult EditarDestino(Destino novoDestino)
        {
            _context.Destinos.Update(novoDestino);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletarDestino(int id)
        {
            var nomeDestino = _context.Destinos.Find(id);
            _context.Destinos.Remove(nomeDestino);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
