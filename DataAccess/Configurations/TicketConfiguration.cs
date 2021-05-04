using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValueTypeExample.Entities;

namespace ValueTypeExample.DataAccess.Configurations
{
    class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.OwnsOne(x => x.PnrDetail);
        }
    }
}
