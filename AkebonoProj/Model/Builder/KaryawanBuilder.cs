using AkebonoProj.Data;
using AkebonoProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkebonoProj.Model.Builder
{
    public class KaryawanBuilder : IEntityTypeConfiguration<Karyawan>
    {
        private readonly AkebonoProjContext _dBContextSample;
        public KaryawanBuilder(AkebonoProjContext dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }

        public void Configure(EntityTypeBuilder<Karyawan> builder)
        {

            builder
                .Property(c => c.NPK)
                .HasMaxLength(5);

            builder
                .Property(c => c.Name)
                .HasMaxLength(50);

            builder
                .Property(c => c.Alamat)
                .HasMaxLength(10);

            builder
                .HasOne(x => x.AkebonoProjUser)
                .WithOne(x => x.Karyawan)
                .HasForeignKey<Karyawan>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
