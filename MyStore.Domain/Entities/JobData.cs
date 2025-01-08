using System.ComponentModel.DataAnnotations;

namespace MyStore.Domain.Entities;

public class JobData
{
    public int Id { get; set; }
    public int PostingId { get; set; }
}