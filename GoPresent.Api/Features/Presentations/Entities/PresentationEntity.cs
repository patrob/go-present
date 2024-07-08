using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoPresent.Api.Data;

namespace GoPresent.Api.Features.Presentations.Entities;

[Table("Presentations")]
public record PresentationEntity : AuditableEntity
{
    public required string Name { get; set; }
}