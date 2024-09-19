using Micromarin.Core.DTOs;
using Micromarin.Core.Models;
using Micromarin.Core.Services;
using Micromarin.Shared.BaseController;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Micromarin.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DynamicEntityController(IGenericService<DynamicEntity, DynamicEntityDto> _genericservice) : CustomBaseController
{
  [HttpPost("Create")]
  public async Task<IActionResult> Create([FromBody] DynamicEntityDto dynamicEntityDto)
  {

    return ActionResultInstance(await _genericservice.AddAsync(dynamicEntityDto));
  }

  [HttpPut("Update")]
  public async Task<IActionResult> Update([FromQuery] Guid Id, [FromBody] DynamicEntityDto dynamicEntityDto)
  {
    return ActionResultInstance(await _genericservice.Update(dynamicEntityDto, Id));
  }

  [HttpDelete("Delete/{Id}")]
  public async Task<IActionResult> Delete(Guid Id)
  {
    return ActionResultInstance(await _genericservice.Remove(Id));
  }


  [HttpGet("GetById/{Id}")]
  public async Task<IActionResult> GetById(Guid Id)
  {
    return ActionResultInstance(await _genericservice.GetByIdAsync(Id));
  }
}
