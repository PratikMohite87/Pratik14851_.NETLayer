using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebPages.Models;

namespace RazorWebPages.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebPages.Models.EFCodeFirstDBContext _context;

        public IndexModel(RazorWebPages.Models.EFCodeFirstDBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Category).ToListAsync();
        }
    }
}
