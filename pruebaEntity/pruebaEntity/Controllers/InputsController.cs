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
    public class InputsController : Controller
    {
        private readonly PersonDbContext _context;

        public InputsController(PersonDbContext context)
        {
            _context = context;
        }

        // GET: Inputs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inputs.ToListAsync());
        }

        // GET: Inputs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var input = await _context.Inputs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (input == null)
            {
                return NotFound();
            }

            return View(input);
        }

        // GET: Inputs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inputs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsDeleted,CreatedAt,UpdatedAt,SidewalkId,ProductiveSystemId,CropYield,CropProductionCosts,InitialSowingDate,FinalSowingDate,AreaCrop,FinagroCcredit,PlantsByHectare,ClientSize")] Input input)
        {
            if (ModelState.IsValid)
            {
                _context.Add(input);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(input);
        }

        // GET: Inputs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var input = await _context.Inputs.FindAsync(id);
            if (input == null)
            {
                return NotFound();
            }
            return View(input);
        }

        // POST: Inputs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsDeleted,CreatedAt,UpdatedAt,SidewalkId,ProductiveSystemId,CropYield,CropProductionCosts,InitialSowingDate,FinalSowingDate,AreaCrop,FinagroCcredit,PlantsByHectare,ClientSize")] Input input)
        {
            if (id != input.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(input);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InputExists(input.Id))
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
            return View(input);
        }

        // GET: Inputs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var input = await _context.Inputs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (input == null)
            {
                return NotFound();
            }

            return View(input);
        }

        // POST: Inputs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var input = await _context.Inputs.FindAsync(id);
            _context.Inputs.Remove(input);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InputExists(int id)
        {
            return _context.Inputs.Any(e => e.Id == id);
        }
    }
}
