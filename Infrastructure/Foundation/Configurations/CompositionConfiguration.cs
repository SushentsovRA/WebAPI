using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.Configurations;

public class CompositionConfiguration : IEntityTypeConfiguration<Composition>
{
    public void Configure( EntityTypeBuilder<Composition> builder )
    {
        builder.ToTable( nameof( Composition ) )
               .HasKey( c => c.CompositionId );

        builder.Property( c => c.Name )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( c => c.Description )
               .HasMaxLength( 100 )
               .IsRequired();

        builder.Property( c => c.HeroesInfo )
               .HasMaxLength( 100 )
               .IsRequired();
    }
}