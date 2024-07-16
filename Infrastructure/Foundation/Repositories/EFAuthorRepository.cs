using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Foundation.Repositories;

public class EFAuthorRepository : IAuthorRepository
{
    private readonly WebAPIDbContext _dbContext;

    public EFAuthorRepository( WebAPIDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public void Save( Author author )
    {
        _dbContext.Set<Author>().Add( author );
        _dbContext.SaveChanges();
    }
}