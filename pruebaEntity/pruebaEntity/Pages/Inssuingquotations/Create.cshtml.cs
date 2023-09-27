using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages.Inssuingquotations
{
    public class CreateModel : PageModel
    {
        private readonly pruebaEntity.Repository.PersonDbContext _context;

        public CreateModel(pruebaEntity.Repository.PersonDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookId"] = new SelectList(_context.Books, "Id", "Id");
        ViewData["InputId"] = new SelectList(_context.Inputs, "Id", "Id");
        ViewData["UserAppId"] = new SelectList(_context.Userapps, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Inssuingquotation Inssuingquotation { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inssuingquotations.Add(Inssuingquotation);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
