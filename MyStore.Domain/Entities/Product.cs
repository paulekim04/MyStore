using System.ComponentModel.DataAnnotations;

namespace MyStore.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public bool InventoryOnly { get; set; }
    public bool Private { get; set; }
}
