using System.Reflection;
using GoPresent.Api.Features.Presentations.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoPresent.Api.Data;

public class GoPresentDbContext(DbContextOptions<GoPresentDbContext> options) : DbContext(options)
{
    public virtual DbSet<PresentationEntity> Presentations { get; set; }
    public virtual DbSet<SlideEntity> Slides { get; set; }
    public virtual DbSet<SlideObjectEntity> SlideObjects { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        AddTimestamps();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        AddTimestamps();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void AddTimestamps()
    {
        var entities = ChangeTracker.Entries()
            .Where(x => x is { Entity: AuditableEntity, State: EntityState.Added or EntityState.Modified });

        foreach (var entity in entities)
        {
            var now = DateTime.UtcNow; // current datetime

            if (entity.State == EntityState.Added)
            {
                ((AuditableEntity)entity.Entity).Created = now;
            }
            ((AuditableEntity)entity.Entity).Modified = now;
        }
    }
}