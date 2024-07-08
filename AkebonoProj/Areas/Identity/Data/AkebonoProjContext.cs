using AkebonoProj.Areas.Identity.Data;
using AkebonoProj.Model;
using AkebonoProj.Model.Builder;
using AkebonoProj.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AkebonoProj.Data;

public class AkebonoProjContext : IdentityDbContext<AkebonoProjUser, ApplicationRole, Guid>
{
    public AkebonoProjContext(DbContextOptions<AkebonoProjContext> options)
        : base(options)
    {
    }

    public DbSet<Karyawan> Karyawans => Set<Karyawan>();
    public DbSet<Items> Items => Set<Items>();
    public DbSet<Lokasi> Lokasis => Set<Lokasi>();
    public DbSet<Achievment> Achievments => Set<Achievment>();
    public DbSet<Planning> Plannings => Set<Planning>();
    public DbSet<TransaksiProduksi> TransaksiProduksis => Set<TransaksiProduksi>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        new KaryawanBuilder(this).Configure(builder.Entity<Karyawan>());
        new ItemBuilder(this).Configure(builder.Entity<Items>());
        new LokasiBuilder(this).Configure(builder.Entity<Lokasi>());
        new AchievmentBuilder(this).Configure(builder.Entity<Achievment>());
        new PlanningBuilder(this).Configure(builder.Entity<Planning>());
        new TransaksiProduksiBuilder(this).Configure(builder.Entity<TransaksiProduksi>());
    }
}
