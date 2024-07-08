using AkebonoProj.Data;
using AkebonoProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkebonoProj.Model.Builder
{
    public class ItemBuilder : IEntityTypeConfiguration<Items>
    {
        private readonly AkebonoProjContext _dBContextSample;
        public ItemBuilder(AkebonoProjContext dbContextSample)
        {
            _dBContextSample = dbContextSample;
        }

        public void Configure(EntityTypeBuilder<Items> builder)
        {

            builder
                .Property(c => c.Kode)
                .HasMaxLength(4);

            builder
                .Property(c => c.NameItem)
                .HasMaxLength(50);
        }
    }
}
