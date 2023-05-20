namespace DeBiLaba2.Models;

public class Order
{
    public int Id { get; set; }


    public int? ShipTypeId { get; set; }

    public int? PaymentTypeId { get; set; }

    public int? UserId { get; set; }

    public string? DeliveryAddress { get; set; }

    public virtual ICollection<Product>? Products { get; } = new List<Product>();

    public virtual PaymentType? PaymentType { get; set; }

    public virtual ShipType? ShipTypeNavigation { get; set; }
    public virtual User? User { get; set; }
}
