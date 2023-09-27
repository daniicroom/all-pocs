using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages.Inssuingquotations
{
    public class DeleteModel : PageModel
    {
        private readonly pruebaEntity.Repository.PersonDbContext _context;

        public DeleteModel(pruebaEntity.Repository.PersonDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inssuingquotation = await _context.Inssuingquotations.FindAsync(id);

            if (Inssuingquotation != null)
            {
                _context.Inssuingquotations.Remove(Inssuingquotation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
