using Microsoft.AspNetCore.Mvc;
using MarketPlaceListing.Dto;
using MarketPlaceListing.Api.Controllers;

namespace MarketPlaceListing.Api;

public class ListingController : BaseController
{
    [HttpPost]
    [Route("create-listing")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult CreateListing([FromBody] CreateListingRequest request)
    {
        return Ok();
    }
}
