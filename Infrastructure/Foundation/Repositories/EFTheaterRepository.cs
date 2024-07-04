using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Foundation.Repositories;

public class EFTheaterRepository : ITheaterRepository
{
    private readonly WebAPIDbContext _dbContext;

    public EFTheaterRepository( WebAPIDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public void Save( Theater hotel )
    {
        _dbContext.Set<Theater>().Add( hotel );
        _dbContext.SaveChanges();
    }

    private Theater GetTheaterById( int id )
    {
        return _dbContext.Set<Theater>().FirstOrDefault( h => h.TheaterId == id );
    }
}