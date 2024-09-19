using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Micromarin.Data;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GenericDbContext>
{
  public GenericDbContext CreateDbContext(string[] args)
  {

    DbContextOptionsBuilder<GenericDbContext> dbContextOptionsBuilder = new();
    dbContextOptionsBuilder.UseSqlServer("Server=DESKTOP-K7M8593\\SQLEXPRESS;Database=DynamicEntityDb;Trusted_Connection=True;TrustServerCertificate=True");
    return new(dbContextOptionsBuilder.Options);
  }
}
