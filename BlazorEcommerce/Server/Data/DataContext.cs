namespace BlazorEcommerce.Server.Data;

public class DataContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<ProductType> ProductTypes => Set<ProductType>();
    public DbSet<ProductVariant> ProductVariants => Set<ProductVariant>();
    public DbSet<User> Users => Set<User>();
    public DbSet<CartItem> CartItems => Set<CartItem>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Address> Addresses => Set<Address>();
        
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("blazor_ecommerce");
        modelBuilder.Entity<CartItem>()
            .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });
        
        modelBuilder.Entity<ProductVariant>()
            .HasKey(p => new { p.ProductId, p.ProductTypeId });
        
        modelBuilder.Entity<OrderItem>()
            .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

        modelBuilder.SeedData();
    }
}