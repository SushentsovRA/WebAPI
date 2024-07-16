using Domain.Entities;

namespace Domain.Repositories;

public interface ITheaterRepository
{
    void Save( Theater theater );

    void Update( Theater theater );

    void Delete( int id );
}
