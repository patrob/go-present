namespace GoPresent.Api.Data;

public record AuditableEntity : GuidEntity
{
    public string CreatedBy { get; set; }
    public DateTime Created { get; set; }

    public string ModifiedBy { get; set; }
    public DateTime Modified { get; set; }
}