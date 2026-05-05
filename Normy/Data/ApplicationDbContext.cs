using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Normy.Models;

namespace Normy.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Wyrob> Wyroby => Set<Wyrob>();
    public DbSet<Pomiar> Pomiary => Set<Pomiar>();
    public DbSet<PomiarCzasu> PomiaryCzasu => Set<PomiarCzasu>();
    public DbSet<DodatkowaCzynnosc> DodatkoweCzynnosci { get; set; }
}