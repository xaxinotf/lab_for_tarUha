using System.ComponentModel.DataAnnotations;

namespace DeBiLaba2.Models;

public class Order
{
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int? ShipTypeId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int? PaymentTypeId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int? UserId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string? DeliveryAddress { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual ICollection<Product>? Products { get; } = new List<Product>();

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual PaymentType? PaymentType { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual ShipType? ShipTypeNavigation { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual Users? User { get; set; }
}
