using Domain.Entities;

namespace Domain.Repositories;

public interface IPlayRepository
{
    void Save( Play play );
}
