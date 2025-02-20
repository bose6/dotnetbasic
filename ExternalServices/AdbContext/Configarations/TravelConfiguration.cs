using lotus.models;

namespace lotus.ExternalServices.AdbContext.Configarations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TravelConfiguration : IEntityTypeConfiguration<Travelplan>
{
    public void Configure(EntityTypeBuilder<Travelplan> builder)
    {
        builder.HasKey(t => t.Id);


        builder.HasOne(t => t.User)
            .WithMany(u => u.Travels)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(t => t.Destinations)
            .WithOne(d => d.Travel)
            .HasForeignKey(d => d.TravelId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
