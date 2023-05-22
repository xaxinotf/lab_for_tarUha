using DeBiLaba2.Models;
using Microsoft.EntityFrameworkCore;

namespace DeBiLaba2.Contexts;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<PaymentType> PaymentTypes { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<ShipType> ShipTypes { get; set; }

    public DbSet<Users> Users { get; set; } = default!;
}
