using Microsoft.AspNetCore.Mvc;
using MarketPlaceListing.Dto;
using MarketPlaceListing.Api.Controllers;
using MarketPlaceListing.Core.Interfaces;

namespace MarketPlaceListing.Api;

public class ListingController : BaseController
{
    private readonly IListingService _listingService;

    public ListingController(IListingService listingService)
    {
        _listingService = listingService;
    }

    [HttpPost]
    [Route("create-listing")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CreatingListingResponse))]
    public async Task<IActionResult> CreateListing([FromBody] CreateListingRequest request)
    {
        var result = await _listingService.CreateListingAsync(request);
        return Ok(result);
    }
}
