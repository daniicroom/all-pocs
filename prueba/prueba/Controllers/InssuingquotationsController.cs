using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prueba.Repository;
using prueba.Repository.Models;

namespace prueba.Controllers
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

            var inssuingquotations = await _context.Inssuingquotations
                .Include(i => i.Book)
                .Include(i => i.Input)
                .Include(i => i.UserApp)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inssuingquotations == null)
            {
                return NotFound();
            }

            return View(inssuingquotations);
        }

        // GET: Inssuingquotations/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id");
            ViewData["InputId"] = new SelectList(_context.Input, "Id", "Id");
            ViewData["UserAppId"] = new SelectList(_context.Userapp, "Id", "Id");
            return View();
        }

        // POST: Inssuingquotations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsDeleted,CreatedAt,UpdatedAt,UserAppId,InputId,BookId,SesionId,Guid")] Inssuingquotations inssuingquotations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inssuingquotations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", inssuingquotations.BookId);
            ViewData["InputId"] = new SelectList(_context.Input, "Id", "Id", inssuingquotations.InputId);
            ViewData["UserAppId"] = new SelectList(_context.Userapp, "Id", "Id", inssuingquotations.UserAppId);
            return View(inssuingquotations);
        }

        // GET: Inssuingquotations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inssuingquotations = await _context.Inssuingquotations.FindAsync(id);
            if (inssuingquotations == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", inssuingquotations.BookId);
            ViewData["InputId"] = new SelectList(_context.Input, "Id", "Id", inssuingquotations.InputId);
            ViewData["UserAppId"] = new SelectList(_context.Userapp, "Id", "Id", inssuingquotations.UserAppId);
            return View(inssuingquotations);
        }

        // POST: Inssuingquotations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsDeleted,CreatedAt,UpdatedAt,UserAppId,InputId,BookId,SesionId,Guid")] Inssuingquotations inssuingquotations)
        {
            if (id != inssuingquotations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inssuingquotations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InssuingquotationsExists(inssuingquotations.Id))
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
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id", inssuingquotations.BookId);
            ViewData["InputId"] = new SelectList(_context.Input, "Id", "Id", inssuingquotations.InputId);
            ViewData["UserAppId"] = new SelectList(_context.Userapp, "Id", "Id", inssuingquotations.UserAppId);
            return View(inssuingquotations);
        }

        // GET: Inssuingquotations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inssuingquotations = await _context.Inssuingquotations
                .Include(i => i.Book)
                .Include(i => i.Input)
                .Include(i => i.UserApp)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inssuingquotations == null)
            {
                return NotFound();
            }

            return View(inssuingquotations);
        }

        // POST: Inssuingquotations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inssuingquotations = await _context.Inssuingquotations.FindAsync(id);
            _context.Inssuingquotations.Remove(inssuingquotations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InssuingquotationsExists(int id)
        {
            return _context.Inssuingquotations.Any(e => e.Id == id);
        }
    }
}
