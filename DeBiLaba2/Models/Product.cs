using System.ComponentModel.DataAnnotations;

namespace DeBiLaba2.Models;

public class Product
{
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string RelaiseFromAndDosing { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string ShelfLife { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int? UserId { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual Users? User { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual ICollection<Order>? Order { get; } = new List<Order>();
}
