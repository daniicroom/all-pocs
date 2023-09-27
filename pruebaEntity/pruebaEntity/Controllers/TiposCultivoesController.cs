using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Controllers
{
    public class TiposCultivoesController : Controller
    {
        private readonly PersonDbContext _context;

        public TiposCultivoesController(PersonDbContext context)
        {
            _context = context;
        }

        // GET: TiposCultivoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposCultivos.ToListAsync());
        }

        // GET: TiposCultivoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposCultivo = await _context.TiposCultivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposCultivo == null)
            {
                return NotFound();
            }

            return View(tiposCultivo);
        }

        // GET: TiposCultivoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposCultivoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Habilitado")] TiposCultivo tiposCultivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiposCultivo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposCultivo);
        }

        // GET: TiposCultivoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposCultivo = await _context.TiposCultivos.FindAsync(id);
            if (tiposCultivo == null)
            {
                return NotFound();
            }
            return View(tiposCultivo);
        }

        // POST: TiposCultivoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Habilitado")] TiposCultivo tiposCultivo)
        {
            if (id != tiposCultivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposCultivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposCultivoExists(tiposCultivo.Id))
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
            return View(tiposCultivo);
        }

        // GET: TiposCultivoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposCultivo = await _context.TiposCultivos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposCultivo == null)
            {
                return NotFound();
            }

            return View(tiposCultivo);
        }

        // POST: TiposCultivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tiposCultivo = await _context.TiposCultivos.FindAsync(id);
            _context.TiposCultivos.Remove(tiposCultivo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposCultivoExists(int id)
        {
            return _context.TiposCultivos.Any(e => e.Id == id);
        }
    }
}
