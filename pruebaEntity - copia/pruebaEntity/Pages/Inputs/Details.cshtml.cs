using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages.Inputs
{
    public class DetailsModel : PageModel
    {
        private readonly pruebaEntity.Repository.PersonDbContext _context;

        public DetailsModel(pruebaEntity.Repository.PersonDbContext context)
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

            Input = await _context.Inputs.FirstOrDefaultAsync(m => m.Id == id);

            if (Input == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
