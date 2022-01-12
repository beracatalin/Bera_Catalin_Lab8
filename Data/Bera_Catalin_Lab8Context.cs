using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bera_Catalin_Lab8.Models;

namespace Bera_Catalin_Lab8.Data
{
    public class Bera_Catalin_Lab8Context : DbContext
    {
        public Bera_Catalin_Lab8Context (DbContextOptions<Bera_Catalin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bera_Catalin_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bera_Catalin_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
