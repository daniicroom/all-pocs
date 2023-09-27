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
    public class InssuingquotationsController : Controller
    {
        private readonly PersonDbContext _context;

        public InssuingquotationsController(PersonDbContext context)
        {
            _context = context;
        }

        // GET: Inssuingquotations
        public async Task<IActionResult> Index()
        {
            var personDbContext = _context.Inssuingquotations.Include(i => i.Book).Include(i => i.Input).Include(i => i.UserApp);
            return View(await personDbContext.ToListAsync());
        }

        // GET: Inssuingquotations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inssuingquotation = await _context.Inssuingquotations
                .Include(i => i.Book)
                .Include(i => i.Input)
                .Include(i => i.UserApp)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inssuingquotation == null)
            {
                return NotFound();
            }

            return View(inssuingquotation);
        }

        // GET: Inssuingquotations/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id");
            ViewData["InputId"] = new SelectList(_context.Inputs, "Id", "Id");
            ViewData["UserAppId"] = new SelectList(_context.Userapps, "Id", "Id");
            return View();
        }

        // POST: Inssuingquotations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsDeleted,CreatedAt,UpdatedAt,UserAppId,InputId,BookId,SesionId,Guid")] Inssuingquotation inssuingquotation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inssuingquotation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", inssuingquotation.BookId);
            ViewData["InputId"] = new SelectList(_context.Inputs, "Id", "Id", inssuingquotation.InputId);
            ViewData["UserAppId"] = new SelectList(_context.Userapps, "Id", "Id", inssuingquotation.UserAppId);
            return View(inssuingquotation);
        }

        // GET: Inssuingquotations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inssuingquotation = await _context.Inssuingquotations.FindAsync(id);
            if (inssuingquotation == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", inssuingquotation.BookId);
            ViewData["InputId"] = new SelectList(_context.Inputs, "Id", "Id", inssuingquotation.InputId);
            ViewData["UserAppId"] = new SelectList(_context.Userapps, "Id", "Id", inssuingquotation.UserAppId);
            return View(inssuingquotation);
        }

        // POST: Inssuingquotations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsDeleted,CreatedAt,UpdatedAt,UserAppId,InputId,BookId,SesionId,Guid")] Inssuingquotation inssuingquotation)
        {
            if (id != inssuingquotation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inssuingquotation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InssuingquotationExists(inssuingquotation.Id))
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
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", inssuingquotation.BookId);
            ViewData["InputId"] = new SelectList(_context.Inputs, "Id", "Id", inssuingquotation.InputId);
            ViewData["UserAppId"] = new SelectList(_context.Userapps, "Id", "Id", inssuingquotation.UserAppId);
            return View(inssuingquotation);
        }

        // GET: Inssuingquotations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inssuingquotation = await _context.Inssuingquotations
                .Include(i => i.Book)
                .Include(i => i.Input)
                .Include(i => i.UserApp)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inssuingquotation == null)
            {
                return NotFound();
            }

            return View(inssuingquotation);
        }

        // POST: Inssuingquotations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inssuingquotation = await _context.Inssuingquotations.FindAsync(id);
            _context.Inssuingquotations.Remove(inssuingquotation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InssuingquotationExists(int id)
        {
            return _context.Inssuingquotations.Any(e => e.Id == id);
        }
    }
}
