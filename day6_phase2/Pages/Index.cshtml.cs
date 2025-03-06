using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Day6P2_razorcrud.Models;

namespace Day6P2_razorcrud.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Day6P2_razorcrud.Models.CustomerDbContext _context;

        public IndexModel(Day6P2_razorcrud.Models.CustomerDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
