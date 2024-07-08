using AkebonoProj.Data;
using AkebonoProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkebonoProj.Model.Builder
{
    public class PlanningBuilder : IEntityTypeConfiguration<Planning>
    {
        private readonly AkebonoProjContext _dBContextSample;
        public PlanningBuilder(AkebonoProjContext dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }
        public void Configure(EntityTypeBuilder<Planning> builder)
        {
            builder
                .Property(c => c.Id)
                .HasColumnType("UNIQUEIDENTIFIER");

            builder
                .Property(c => c.KodeItem)
                .HasMaxLength(4);

            builder
                .Property(p => p.QtyTarget)
                .HasColumnType("int")
                .HasPrecision(10);

            builder
                .Property(p => p.WaktuTarget)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);

            builder
                .HasOne(x => x.Item)
                .WithOne(x => x.Planning)
                .HasForeignKey<Planning>(x => x.KodeItem)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
