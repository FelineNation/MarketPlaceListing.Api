using System.ComponentModel.DataAnnotations;

namespace MarketPlaceListing.Dto;

public class Currency
{
    public decimal Price { get; set; }
    [Required]
    public string? CurrencyType { get; set; }
}
