using System.ComponentModel.DataAnnotations;

namespace DeBiLaba2.Models;

public class Users
{
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Address { get; set; }
}
