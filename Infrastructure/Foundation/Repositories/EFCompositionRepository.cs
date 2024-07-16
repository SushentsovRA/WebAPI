using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Foundation.Repositories;

public class EFCompositionRepository : ICompositionRepository
{
    private readonly WebAPIDbContext _dbContext;

    public EFCompositionRepository( WebAPIDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public void Save( Composition composition )
    {
        _dbContext.Set<Composition>().Add( composition );
        _dbContext.SaveChanges();
    }
}
