using Micromarin.Core.Models;
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
}