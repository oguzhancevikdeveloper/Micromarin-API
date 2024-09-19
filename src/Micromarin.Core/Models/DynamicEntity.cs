using Micromarin.Core.Models.BaseModel;

namespace Micromarin.Core.Models;

public class DynamicEntity : BaseEntityModel
{

  public string ObjectType { get; set; } // Nesne türü (örn. ürün, sipariş)
  public string Data { get; set; } // JSON formatındaki veri

}
