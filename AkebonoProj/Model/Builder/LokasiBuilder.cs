using AkebonoProj.Data;
using AkebonoProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkebonoProj.Model.Builder
{
    public class LokasiBuilder : IEntityTypeConfiguration<Lokasi>
    {
        private readonly AkebonoProjContext _dBContextSample;
        public LokasiBuilder(AkebonoProjContext dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }
        public void Configure(EntityTypeBuilder<Lokasi> builder)
        {

            builder
                .Property(c => c.Kode)
                .HasMaxLength(4);

            builder
                .Property(c => c.NameLocation)
                .HasMaxLength(50);

        }
    }
}
