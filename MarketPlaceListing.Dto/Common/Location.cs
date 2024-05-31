using System.ComponentModel.DataAnnotations;

namespace MarketPlaceListing.Dto;

public class Location
{
    public string? Address { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public string? State { get; set; }
    [Required]
    public string? Country { get; set; }
    [Required]
    public string? PostCode { get; set; }
}
