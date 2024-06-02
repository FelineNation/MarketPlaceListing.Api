using System.ComponentModel.DataAnnotations;

namespace MarketPlaceListing.Dto;

public class CreatingListingResponse
{
    [Required]
    public string? ListingId { get; set; }
}
