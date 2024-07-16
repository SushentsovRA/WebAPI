using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Foundation.Configurations;

public class TheaterConfiguration : IEntityTypeConfiguration<Theater>
{
    public void Configure( EntityTypeBuilder<Theater> builder )
    {
        builder.ToTable( nameof( Theater ) )
               .HasKey( t => t.TheaterId );

        builder.Property( t => t.Name )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( t => t.Address )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( t => t.FirstOpenDate )
               .IsRequired();

        builder.Property( t => t.OpenTime )
               .IsRequired();

        builder.Property( t => t.CloseTime )
               .IsRequired();

        builder.Property( t => t.Description )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( t => t.PhoneNumber )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.HasMany( t => t.Plays )
               .WithOne()
               .HasForeignKey( p => p.TheaterId );
    }
}