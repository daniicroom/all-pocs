using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages.TiposCultivos
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
            return Page();
        }

        [BindProperty]
        public TiposCultivo TiposCultivo { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TiposCultivos.Add(TiposCultivo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
