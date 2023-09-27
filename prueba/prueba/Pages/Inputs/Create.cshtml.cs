using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using prueba.Repository;
using prueba.Repository.Models;

namespace prueba.Pages.Inputs
{
    public class CreateModel : PageModel
    {
        private readonly prueba.Repository.PersonDbContext _context;

        public CreateModel(prueba.Repository.PersonDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Input Input { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Input.Add(Input);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
