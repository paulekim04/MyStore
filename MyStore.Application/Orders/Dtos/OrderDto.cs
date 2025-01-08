namespace MyStore.Application.Orders.Dtos;

public class OrderDto
{
    public int Id { get; set; }
    public IEnumerable<ItemDto> Items { get; set; }
}
