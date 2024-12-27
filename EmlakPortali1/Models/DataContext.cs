using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmlakPortali1.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {


        public AppDbContext(DbContextOptions options) : base(options)
        {

        }





        public DbSet<Sehir>Sehirs {  get; set; }
        public DbSet<Semt>Semts {  get; set; }

        public DbSet<Mahalle> Mahalles { get; set; }

        public DbSet<Durum> Durums { get; set; }
        public DbSet<Tip> Tips { get; set; }
        public DbSet<Ilan> Ilans { get; set; }

        public DbSet<Resim> Resim { get; set; }

        

    }
}
