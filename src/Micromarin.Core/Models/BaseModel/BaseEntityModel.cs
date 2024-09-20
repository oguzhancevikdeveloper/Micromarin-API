using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micromarin.Core.Models.BaseModel;

public class BaseEntityModel
{
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public Guid Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
  public bool IsActive { get; set; }


  public BaseEntityModel()
  {
    Id = Guid.NewGuid();
    IsActive = true;
  }
}
