using AutoMapper;
using Micromarin.Core.DTOs;
using Micromarin.Core.Models;

namespace Micromarin.Service.Mapping;

internal class DtoMapper : Profile
{
  public DtoMapper()
  {
    CreateMap<DynamicEntityDto, DynamicEntity>().ReverseMap();
  }
}