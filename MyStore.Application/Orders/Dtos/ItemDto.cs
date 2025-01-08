using MyStore.Domain.Entities;

namespace MyStore.Application.Orders.Dtos;
public class ItemDto
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public string Currency { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public decimal RetailCost { get; set; }
    public decimal AccountDiscount { get; set; }
    public decimal CouponDiscount { get; set; }
    public decimal NetCost { get; set; }
}
