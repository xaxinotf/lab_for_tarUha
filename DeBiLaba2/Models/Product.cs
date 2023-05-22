namespace DeBiLaba2.Models;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string RelaiseFromAndDosing { get; set; } = null!;

    public string ShelfLife { get; set; } = null!;
    public int? UserId { get; set; }
    public virtual Users? User { get; set; }
    public virtual ICollection<Order>? Order { get; } = new List<Order>();
}
