using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pruebaEntity.Repository;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages.TiposCultivos
{
    public class DetailsModel : PageModel
    {
        private readonly pruebaEntity.Repository.PersonDbContext _context;

        public DetailsModel(pruebaEntity.Repository.PersonDbContext context)
        {
            _context = context;
        }

        public TiposCultivo TiposCultivo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TiposCultivo = await _context.TiposCultivos.FirstOrDefaultAsync(m => m.Id == id);

            if (TiposCultivo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
