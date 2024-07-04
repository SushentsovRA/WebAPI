using Domain.Entities;

namespace Domain.Repositories;
public interface IAuthorRepository
{
    void Save( Author author );
}