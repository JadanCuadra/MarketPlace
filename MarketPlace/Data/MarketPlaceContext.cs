using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarketPlace.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MarketPlace.Data
{
    public class MarketPlaceContext : IdentityDbContext<IdentityUser>
    {
        public MarketPlaceContext (DbContextOptions<MarketPlaceContext> options)
            : base(options)
        {
        }

        public DbSet<MarketPlace.Models.Categoria> Categoria { get; set; } = default!;

        public DbSet<MarketPlace.Models.Productos> Productos { get; set; }

        public DbSet<MarketPlace.Models.Slider> Slider { get; set; }

        public DbSet<MarketPlace.Models.Usuarios> Usuarios { get; set; }
    }
}
