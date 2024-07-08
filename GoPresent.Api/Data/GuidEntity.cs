using System.ComponentModel.DataAnnotations;

namespace GoPresent.Api.Data;

public record GuidEntity
{
    [Key]
    public Guid Id { get; set; }
}