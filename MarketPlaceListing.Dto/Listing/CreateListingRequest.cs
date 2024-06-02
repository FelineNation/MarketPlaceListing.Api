using System.ComponentModel.DataAnnotations;

namespace MarketPlaceListing.Dto;

public class CreateListingRequest
{
    [Required]
    public string? ListedByUserId { get; init; }
    [Required]
    public List<ListingItem>? ListingItems { get; init; }
}
