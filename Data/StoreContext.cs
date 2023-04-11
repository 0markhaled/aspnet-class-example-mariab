using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RP_EF_Maria.Pages;

    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<RP_EF_Maria.Pages.Game> Game { get; set; } = default!;
    }
