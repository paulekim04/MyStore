using MyStore.Domain.Entities;

namespace MyStore.Domain.Repositories;

public interface IProductsRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
}
