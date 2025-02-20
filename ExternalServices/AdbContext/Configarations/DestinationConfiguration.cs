using lotus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lotus.ExternalServices.AdbContext.Configarations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
{
    public void Configure(EntityTypeBuilder<Destination> builder)
    {
        builder.HasKey(d => d.Id);
        

        builder.HasOne(d => d.Travel)
            .WithMany(t => t.Destinations)
            .HasForeignKey(d => d.TravelId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(d => d.Transportation)
            .WithMany(t => t.Destinations)
            .HasForeignKey(d => d.TransportationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
