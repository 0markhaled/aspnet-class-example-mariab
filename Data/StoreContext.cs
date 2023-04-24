using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RP_EF_Maria.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
public class StoreContext : IdentityDbContext<ApplicationUser>
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }

    public DbSet<Game> Game { get; set; } = default!;
    public DbSet<Rating> Rating { get; set; } = default!;


}
