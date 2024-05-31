using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace MarketPlaceListing.Dto;

public class ListingItem
{
    [Required]
    public string? Title { get; init; }
    [Required]
    public string? Category { get; init; }
    [Required]
    public Currency? Price { get; init; }
    [Required] 
    public int Quantity { get; init; }
    [Required]
    public Location? Location { get; init; }
    public List<string>? ImageUrl { get; init; }
    public JsonElement? Description { get; init; }

}
