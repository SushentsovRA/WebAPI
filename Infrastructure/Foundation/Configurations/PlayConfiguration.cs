using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Foundation.Configurations;
public class PlayConfiguration : IEntityTypeConfiguration<Play>
{
    public void Configure( EntityTypeBuilder<Play> builder )
    {
        builder.ToTable( nameof( Play ) )
               .HasKey( p => p.PlayId );

        builder.Property( p => p.Name )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( p => p.StartDateTimeUtc )
               .IsRequired();

        builder.Property( p => p.EndDateTimeUtc )
               .IsRequired();

        builder.Property( p => p.Price ).HasColumnType( "money" )
               .IsRequired();

        builder.Property( p => p.Description )
               .HasMaxLength( 100 )
               .IsRequired();
    }
}