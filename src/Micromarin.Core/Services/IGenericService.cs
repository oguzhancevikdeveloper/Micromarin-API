using Micromarin.Shared.DTOs;
using System.Linq.Expressions;

namespace Micromarin.Core.Services;

public interface IGenericService<TEntity, TDto> where TEntity : class where TDto : class
{
  Task<Response<TDto>> AddAsync(TDto dto);
  Task<Response<NoDataDto>> Update(TDto dto, Guid id);
  Task<Response<NoDataDto>> Remove(Guid id);

  Task<Response<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
  Task<Response<TDto>> GetByIdAsync(Guid id);
  Task<Response<IEnumerable<TDto>>> GetAllAsync();
}