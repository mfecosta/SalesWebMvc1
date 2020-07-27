using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc1.Models;
using SalesWebMvc1.Services;

namespace SalesWebMvc1.Data
{
    public class SalesWebMvc1Context : DbContext
    {
        public SalesWebMvc1Context (DbContextOptions<SalesWebMvc1Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SallesRecord> SallesRecord { get; set; }
        public DbSet<Seller> Selller { get; set; }
        
    }
}
