using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages.Inssuingquotations
{
    public class EditModel : PageModel
    {
        private readonly pruebaEntity.Repository.PersonDbContext _context;

        public EditModel(pruebaEntity.Repository.PersonDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inssuingquotation Inssuingquotation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inssuingquotation = await _context.Inssuingquotations
                .Include(i => i.Book)
                .Include(i => i.Input)
                .Include(i => i.UserApp).FirstOrDefaultAsync(m => m.Id == id);

            if (Inssuingquotation == null)
            {
                return NotFound();
            }
           ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id");
           ViewData["InputId"] = new SelectList(_context.Inputs, "Id", "Id");
           ViewData["UserAppId"] = new SelectList(_context.Userapps, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Inssuingquotation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InssuingquotationExists(Inssuingquotation.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InssuingquotationExists(int id)
        {
            return _context.Inssuingquotations.Any(e => e.Id == id);
        }
    }
}
