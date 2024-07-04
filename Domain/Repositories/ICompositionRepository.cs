using Domain.Entities;

namespace Domain.Repositories;
public interface ICompositionRepository
{
    void Save( Author author );
}