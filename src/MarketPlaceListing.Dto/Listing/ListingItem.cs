using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MarketPlaceListing.Dto;

public class ListingItem
{
    /// <summary>
    /// Name for the listing item
    /// </summary>
    [Required]
    public string? Title { get; init; }
    /// <summary>
    /// Item Category, e.g. Health, Supplies etc.
    /// If not defined in the enum, it will default to Other
    /// </summary>
    [Required]
    public ListingItemCategory Category { get; init; }
    /// <summary>
    /// Unit Price of the item with currency
    /// </summary>
    [Required]
    public Currency? Price { get; init; }
    /// <summary>
    /// Quantity of the item available
    /// </summary>
    [Required] 
    public int Quantity { get; init; }
    /// <summary>
    /// Location of the item
    /// </summary>
    [Required]
    public Location? Location { get; init; }
    /// <summary>
    /// Image Urls for the item
    /// </summary>
    public List<string>? ImageUrl { get; init; }
    /// <summary>
    /// Description of the item, which can be any json object
    /// </summary>
    public JsonElement? Description { get; init; }
    /// <summary>
    /// Start Date of the listing
    /// </summary>
    public DateTime? ListingStartDate { get; private set; }
    /// <summary>
    /// End Date of the listing
    /// </summary>
    public DateTime? ListingEndDate { get; init; }
    /// <summary>
    /// Unique identifier for the listing item
    /// </summary>
    public string? ListingItemId { get; private set; } 

    public ListingItem()
    {
        ListingItemId = string.Concat("listing-", Guid.NewGuid().ToString());
    }
}
