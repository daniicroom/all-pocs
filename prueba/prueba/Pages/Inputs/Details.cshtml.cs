using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using prueba.Repository;
using prueba.Repository.Models;

namespace prueba.Pages.Inputs
{
    public class DetailsModel : PageModel
    {
        private readonly prueba.Repository.PersonDbContext _context;

        public DetailsModel(prueba.Repository.PersonDbContext context)
        {
            _context = context;
        }

        public Input Input { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Input = await _context.Input.FirstOrDefaultAsync(m => m.Id == id);

            if (Input == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
