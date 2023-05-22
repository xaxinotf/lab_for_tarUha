using System.ComponentModel.DataAnnotations;

namespace DeBiLaba2.Models;

public class PaymentType
{
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Desription { get; set; } = null!;

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
