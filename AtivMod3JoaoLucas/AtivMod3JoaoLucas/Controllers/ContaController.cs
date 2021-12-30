using AgenciaViagens.Data;
using AgenciaViagens.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagens.Controllers
{
    public class ContaController : Controller 
    {
        private readonly ContaContext _context;

        public ContaController(ContaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Usuario> ListaUsuario = _context.Usuarios;
            return View(ListaUsuario);
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
        public IActionResult Create(Usuario novoUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(novoUsuario);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult EditarUsuario(int id)
        {
            var nomeUsuario = _context.Usuarios.Find(id);
            if (nomeUsuario == null)
            {
                return RedirectToAction("Index");
            }
            return View(nomeUsuario);
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario novoUsuario)
        {
            _context.Usuarios.Update(novoUsuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletarUsuario(int id)
        {
            var nomeUsuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(nomeUsuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
