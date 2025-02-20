using lotus.models;

namespace lotus.ExternalServices.AdbContext.Configarations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TransportationConfiguration : IEntityTypeConfiguration<Transportation>
{
    public void Configure(EntityTypeBuilder<Transportation> builder)
    {
        builder.HasKey(t => t.Id);
        

        builder.HasMany(t => t.Destinations)
            .WithOne(d => d.Transportation)
            .HasForeignKey(d => d.TransportationId);
    }
}
