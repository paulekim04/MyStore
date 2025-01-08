using MyStore.Domain.Entities;

namespace MyStore.Domain.Repositories;

public interface IOrdersRepository
{
    Task<IEnumerable<Order>> GetAllAsync();
}
