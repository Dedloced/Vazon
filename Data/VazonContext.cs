using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vazon.Models;

namespace Vazon.Data
{
    public class VazonContext : DbContext
    {
        public VazonContext (DbContextOptions<VazonContext> options)
            : base(options)
        {
        }

        public DbSet<Vazon.Models.Product> Product { get; set; } = default!;
    }
}
