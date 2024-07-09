using Infrastructure.Foundation.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class WebAPIDbContext : DbContext
{
    public WebAPIDbContext( DbContextOptions options )
        : base( options )
    {
    }
    protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
    {
        base.OnConfiguring( optionsBuilder );

        optionsBuilder.UseSqlServer( "Server=localhost\\SQLEXPRESS;Database=WebAPI;Trusted_Connection=True;TrustServerCertificate=True;" );
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        base.OnModelCreating( modelBuilder );

        modelBuilder.ApplyConfiguration( new AuthorConfiguration() );
        modelBuilder.ApplyConfiguration( new CompositionConfiguration() );
        modelBuilder.ApplyConfiguration( new PlayConfiguration() );
        modelBuilder.ApplyConfiguration( new TheaterConfiguration() );
    }
}
