using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bold.Data;
using Bold.Models;

namespace Bold.Pages.Nagi
{
    public class IndexModel : PageModel
    {
        private readonly Bold.Data.BoldContext _context;

        public IndexModel(Bold.Data.BoldContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
