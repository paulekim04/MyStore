using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Entities;
using MyStore.Domain.Repositories;
using MyStore.Infrastructure.Persistence;

namespace MyStore.Infrastructure.Repositories;
internal class ProductsRepository(MyStoreDbContext dbContext) : IProductsRepository
{
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var products = await dbContext.Products.ToListAsync();

        return products;
    }
}
