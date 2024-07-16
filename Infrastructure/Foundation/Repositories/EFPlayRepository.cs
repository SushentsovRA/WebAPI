using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Foundation.Repositories;

public class EFPlayRepository : IPlayRepository
{
    private readonly WebAPIDbContext _dbContext;

    public EFPlayRepository( WebAPIDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public void Save( Play play )
    {
        _dbContext.Set<Play>().Add( play );
        _dbContext.SaveChanges();
    }
}
