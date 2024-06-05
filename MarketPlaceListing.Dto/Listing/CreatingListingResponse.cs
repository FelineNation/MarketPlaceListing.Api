using System.ComponentModel.DataAnnotations;

namespace MarketPlaceListing.Dto;

public class CreatingListingResponse
{
    [Required]
    public DateTime AsAt { get; set; }
    [Required]
    public List<ElasticListingItem>? ListedItems { get; set; }
}
