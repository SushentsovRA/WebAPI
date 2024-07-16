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

    public void Save( Theater theater )
    {
        _dbContext.Set<Theater>().Add( theater );
        _dbContext.SaveChanges();
    }

    public void Update( Theater theater )
    {
        Theater existingTheater = GetTheaterById( theater.TheaterId );
        existingTheater.CopyFrom( theater );
        _dbContext.SaveChanges();
    }

    public void Delete( int id )
    {
        Theater existingTheater = GetTheaterById( id );
        _dbContext.Set<Theater>().Remove( existingTheater );
        _dbContext.SaveChanges();
    }

    private Theater GetTheaterById( int id )
    {
        return _dbContext.Set<Theater>().FirstOrDefault( t => t.TheaterId == id );
    }
}