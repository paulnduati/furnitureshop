using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FurnitureShop.Models;

namespace FurnitureShop.Data
{
    public class FurnitureShopContext : DbContext
    {
        public FurnitureShopContext (DbContextOptions<FurnitureShopContext> options)
            : base(options)
        {
        }

        public DbSet<FurnitureShop.Models.Catalog> Catalog { get; set; } = default!;
    }
}
