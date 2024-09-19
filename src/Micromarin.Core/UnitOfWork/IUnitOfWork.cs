namespace Micromarin.Core.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
  Task CommitAsync();
  void Commit();
}