using System.ComponentModel.DataAnnotations.Schema;
using GoPresent.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoPresent.Api.Features.Presentations.Entities;

[Table("SlideObjects")]
public record SlideObjectEntity : AuditableEntity, IEntityTypeConfiguration<SlideObjectEntity>
{
    public SlideObject SlideObject { get; set; }
    
    public void Configure(EntityTypeBuilder<SlideObjectEntity> builder)
    {
        builder.OwnsOne(slideObjectEntity => slideObjectEntity.SlideObject, ownedObj => ownedObj.ToJson());
    }
}