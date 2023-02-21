namespace Persistence.Models;
public class Book
{
    public Guid Id { get; init; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public double Price { get; set; }
    public string Genre { get; set; }
}
