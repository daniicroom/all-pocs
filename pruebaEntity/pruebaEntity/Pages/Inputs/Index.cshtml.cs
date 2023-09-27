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
    public class IndexModel : PageModel
    {
        private readonly pruebaEntity.Repository.PersonDbContext _context;

        public IndexModel(pruebaEntity.Repository.PersonDbContext context)
        {
            _context = context;
        }

        public IList<Input> Input { get;set; }

        public async Task OnGetAsync()
        {
            Input = await _context.Inputs.ToListAsync();
        }
    }
}
