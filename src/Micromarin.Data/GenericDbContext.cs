using Micromarin.Core.Models;
using Micromarin.Core.Models.BaseModel;
using Microsoft.EntityFrameworkCore;

namespace Micromarin.Data;

public sealed class GenericDbContext : DbContext
{
  public GenericDbContext(DbContextOptions<GenericDbContext> options) : base(options) { }

  DbSet<DynamicEntity> DynamicEntities => Set<DynamicEntity>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    base.OnModelCreating(modelBuilder);


  }


  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
  {

    var datas = ChangeTracker
         .Entries<BaseEntityModel>();

    foreach (var data in datas)
    {
      _ = data.State switch
      {
        EntityState.Added => data.Entity.CreatedAt = DateTime.UtcNow,
        EntityState.Modified => data.Entity.UpdatedAt = DateTime.UtcNow,
        _ => DateTime.UtcNow
      };
    }

    return await base.SaveChangesAsync(cancellationToken);
  }
}
