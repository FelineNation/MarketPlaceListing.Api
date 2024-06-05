using System.ComponentModel.DataAnnotations;

namespace MarketPlaceListing.Dto;

public class ElasticListingItem
{
    /// <summary>
    /// Name for the listing item
    /// </summary>
    [Required]
    public string? Title { get; set; }
     /// <summary>
    /// Quantity of the item available
    /// </summary>
    [Required]
    public int Quantity { get; set; }
    /// <summary>
    /// Unit Price of the item with currency
    /// </summary>
    [Required]
    public Currency? Price { get; init; }
    /// <summary>
    /// Preview image url for the item
    /// </summary>
    [Required]
    public string? PreviewImageUrl { get; set; }
    /// <summary>
    /// Start Date of the listing
    /// </summary>
    [Required]
    public DateTime? ListingStartDate { get; set; }
    /// <summary>
    /// End Date of the listing
    /// </summary>
    public DateTime? ListingEndDate { get; set; }
    /// <summary>
    /// Unique identifier for the listing item
    /// </summary>
    [Required]
    public string? ListingItemId { get; set; }
    [Required]
    public ListingStatus ListingStatus { get; set; }
}