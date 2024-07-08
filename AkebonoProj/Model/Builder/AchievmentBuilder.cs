using AkebonoProj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkebonoProj.Model.Builder
{
    public class AchievmentBuilder : IEntityTypeConfiguration<Achievment>
    {
        private readonly AkebonoProjContext _dBContextSample;
        public AchievmentBuilder(AkebonoProjContext dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }
        public void Configure(EntityTypeBuilder<Achievment> builder)
        {

            builder
                .Property(c => c.Kode)
                .HasMaxLength(4);

            builder
                .Property(p => p.TimeFrom)
                .HasDefaultValue("1900-01-01");

            builder
                .Property(p => p.TimeTo)
                .HasDefaultValue("1900-01-01");

        }
    }
}
