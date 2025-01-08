using System.ComponentModel.DataAnnotations;

namespace MyStore.Domain.Entities;
public class Item
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public string Currency { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public decimal RetailCost { get; set; }
    public decimal AccountDiscount { get; set; }
    public decimal CouponDiscount { get; set; }
    public decimal NetCost { get; set; }
    public int JobDataId { get; set; }
    public JobData JobData { get; set; }
    public Order Order { get; set; }
}
