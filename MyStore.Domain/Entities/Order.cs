namespace MyStore.Domain.Entities;
public class Order
{
    public int Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public string PaymentMethod { get; set; } = string.Empty;
    public int RecruiterId { get; set; }
    public int DivisionId { get; set; }
    public int CompanyId { get; set; }
    public bool Validated { get; set; }
    public DateTime Created { get; set; }
    public DateTime Completed { get; set; }
    public IEnumerable<Item> Items { get; set; }
}
