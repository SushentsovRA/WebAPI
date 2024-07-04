using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.Configurations;
public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure( EntityTypeBuilder<Author> builder )
    {
        builder.ToTable( nameof( Author ) )
               .HasKey( a => a.AuthorId );

        builder.Property( a => a.Name )
               .HasMaxLength( 50 )
               .IsRequired();
        
        builder.Property( a => a.BirthDate )
               .IsRequired();
    }
}