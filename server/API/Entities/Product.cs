namespace API.Entities;

public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? PictureUrl { get; set; }
    public string? Type { get; set; }
    public string? Brand { get; set; }
    public int Quantity { get; set; }
}