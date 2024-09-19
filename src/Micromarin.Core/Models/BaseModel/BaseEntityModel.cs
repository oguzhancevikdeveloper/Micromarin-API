namespace Micromarin.Core.Models.BaseModel;

public class BaseEntityModel
{
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
