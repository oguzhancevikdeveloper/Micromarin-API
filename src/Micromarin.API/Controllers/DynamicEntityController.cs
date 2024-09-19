using Micromarin.Core.DTOs;
using Micromarin.Core.Models;
using Micromarin.Core.Services;
using Micromarin.Shared.BaseController;
using Microsoft.AspNetCore.Mvc;

namespace Micromarin.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DynamicEntityController(IGenericService<DynamicEntity, DynamicEntityDto> _genericservice) : CustomBaseController
{
  [HttpPost("Create")]
  public async Task<IActionResult> Create(DynamicEntityDto dynamicEntityDto)
  {
    return ActionResultInstance(await _genericservice.AddAsync(dynamicEntityDto));
  }

  [HttpPut("Update")]
  public async Task<IActionResult> Update(Guid Id,DynamicEntityDto dynamicEntityDto)
  {
    return ActionResultInstance(await _genericservice.Update(dynamicEntityDto,Id));
  }

  [HttpDelete("Delete/{Id}")]
  public async Task<IActionResult> Update(Guid Id)
  {
    return ActionResultInstance(await _genericservice.Remove(Id));
  }


  [HttpGet("GetById/{Id}")]
  public async Task<IActionResult> GetById(Guid Id)
  {
    return ActionResultInstance(await _genericservice.GetByIdAsync(Id));
  }
}
