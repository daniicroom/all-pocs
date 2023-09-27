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
    public class IndexModel : PageModel
    {
        private readonly prueba.Repository.PersonDbContext _context;

        public IndexModel(prueba.Repository.PersonDbContext context)
        {
            _context = context;
        }

        public IList<Input> Input { get;set; }

        public async Task OnGetAsync()
        {
            Input = await _context.Input.ToListAsync();
        }
    }
}
