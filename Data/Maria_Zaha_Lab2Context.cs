using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maria_Zaha_Lab2.Models;

namespace Maria_Zaha_Lab2.Data
{
    public class Maria_Zaha_Lab2Context : DbContext
    {
        public Maria_Zaha_Lab2Context (DbContextOptions<Maria_Zaha_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Maria_Zaha_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Maria_Zaha_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
