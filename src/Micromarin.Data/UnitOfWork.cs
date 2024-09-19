using Micromarin.Core.UnitOfWork;

namespace Micromarin.Data;

public class UnitOfWork : IUnitOfWork
{
  private readonly GenericDbContext _genericDbContext;

  public UnitOfWork(GenericDbContext genericDbContext)
  {
    _genericDbContext = genericDbContext;
  }

  public void Commit()
  {
    _genericDbContext.SaveChanges();
  }
  public async Task CommitAsync()
  {
    await _genericDbContext.SaveChangesAsync();
  }

  public void Dispose()
  {
    _genericDbContext?.Dispose();
  }
}
