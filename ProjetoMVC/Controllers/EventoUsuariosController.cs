#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;
using ProjetoMVC.Models.Dominio;

namespace ProjetoMVC.Controllers
{
    public class EventoUsuariosController : Controller
    {
        private readonly Contexto _context;
        private readonly ISession _session;

        public EventoUsuariosController(Contexto context, ISession session)
        {
            _context = context;
            _session = session;
        }

        // GET: EventoUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventoUsuario.ToListAsync());
        }

        // GET: EventoUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoUsuario = await _context.EventoUsuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventoUsuario == null)
            {
                return NotFound();
            }

            return View(eventoUsuario);
        }

        // GET: EventoUsuarios/Create
        public IActionResult Create()
        {

            return View();
        }

        //public IActionResult Create(int eventoId)
        //{
        //    EventoUsuario eventoUsuario = new EventoUsuario();

        //    eventoUsuario.Usuario = _session.Id;
        //    eventoUsuario.Evento = eventoId;
        //    _context.Add(eventoUsuario);
        //    _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        // POST: EventoUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] EventoUsuario eventoUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventoUsuario);
        }

        // GET: EventoUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoUsuario = await _context.EventoUsuario.FindAsync(id);
            if (eventoUsuario == null)
            {
                return NotFound();
            }
            return View(eventoUsuario);
        }

        // POST: EventoUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] EventoUsuario eventoUsuario)
        {
            if (id != eventoUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventoUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventoUsuarioExists(eventoUsuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(eventoUsuario);
        }

        // GET: EventoUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoUsuario = await _context.EventoUsuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (eventoUsuario == null)
            {
                return NotFound();
            }

            return View(eventoUsuario);
        }

        // POST: EventoUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventoUsuario = await _context.EventoUsuario.FindAsync(id);
            _context.EventoUsuario.Remove(eventoUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventoUsuarioExists(int id)
        {
            return _context.EventoUsuario.Any(e => e.Id == id);
        }
    }
}
