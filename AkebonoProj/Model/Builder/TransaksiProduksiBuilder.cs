using AkebonoProj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkebonoProj.Model.Builder
{
    public class TransaksiProduksiBuilder : IEntityTypeConfiguration<TransaksiProduksi>
    {
        private readonly AkebonoProjContext _dBContextSample;
        public TransaksiProduksiBuilder(AkebonoProjContext dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }
        public void Configure(EntityTypeBuilder<TransaksiProduksi> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(p => p.TglTransaksi)
                .HasDefaultValue("1900-01-01");

            builder
                .Property(c => c.KodeItem)
                .HasMaxLength(4);

            builder
                .Property(c => c.KodeLokasi)
                .HasMaxLength(4);

            builder
                .Property(c => c.NPK)
                .HasMaxLength(5);

            builder
                .Property(p => p.QtyActual)
                .HasColumnType("int")
                .HasPrecision(10);

            builder
               .HasOne(c => c.Karyawan)
               .WithMany(c => c.TransaksiProduksis)
               .HasForeignKey(c => c.NPK)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_TransaksiProduksis_Karyawan");

            builder
               .HasOne(c => c.Lokasi)
               .WithMany(c => c.TransaksiProduksis)
               .HasForeignKey(c => c.KodeLokasi)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_TransaksiProduksis_Lokasi");

            builder
               .HasOne(c => c.Item)
               .WithMany(c => c.TransaksiProduksis)
               .HasForeignKey(c => c.KodeItem)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_TransaksiProduksis_Item");

        }
    }
}
