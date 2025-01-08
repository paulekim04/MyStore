using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Entities;
using MyStore.Domain.Repositories;
using MyStore.Infrastructure.Persistence;

namespace MyStore.Infrastructure.Repositories;
internal class OrdersRepository(MyStoreDbContext dbContext) : IOrdersRepository
{
    public async Task<IEnumerable<Order>> GetAllAsync()
    {
        var orders = await dbContext.Orders.Include(o => o.Items).ToListAsync();

        return orders;
    }
}
