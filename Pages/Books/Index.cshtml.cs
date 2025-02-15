﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maria_Zaha_Lab2.Data;
using Maria_Zaha_Lab2.Models;

namespace Maria_Zaha_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Maria_Zaha_Lab2.Data.Maria_Zaha_Lab2Context _context;

        public IndexModel(Maria_Zaha_Lab2.Data.Maria_Zaha_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }

    }
}
