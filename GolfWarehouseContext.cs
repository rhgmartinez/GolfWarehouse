using Golf_Warehouse_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

public class GolfWarehouseContext : DbContext
{
    public GolfWarehouseContext(DbContextOptions<GolfWarehouseContext> options) : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerShippingAddress> CustomerShippingAddresses { get; set; }

    public DbSet<Item> Items { get; set; }
    public DbSet<ItemBarcode> ItemBarcodes { get; set; }
    public DbSet<ItemCategory> ItemCategories { get; set; }
    public DbSet<ItemSerialNumber> ItemSerialNumbers { get; set; }
    public DbSet<ItemStockingLocation> ItemStockingLocations { get; set; }
    public DbSet<ItemStockingLocationsCell> ItemStockingLocationsCells { get; set; }
    public DbSet<ItemStockingLocationValue> ItemStockingLocationValues { get; set; }
    public DbSet<ItemSubcategory> ItemSubcategories{ get; set; }

    public DbSet<POSHeader> POSHeaders { get; set; }
    public DbSet<POSLineItem> POSLineItems { get; set; }
    // Add other DbSets as needed
}