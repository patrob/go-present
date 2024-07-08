using System.ComponentModel.DataAnnotations.Schema;
using GoPresent.Api.Data;

namespace GoPresent.Api.Features.Presentations.Entities;

[Table("Slides")]
public record SlideEntity : AuditableEntity
{
    public string Label { get; set; }
    
    public virtual IEnumerable<SlideObjectEntity> SlideObjects { get; set; }
}