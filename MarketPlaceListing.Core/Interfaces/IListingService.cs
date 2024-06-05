using MarketPlaceListing.Dto;

namespace MarketPlaceListing.Core.Interfaces;

public interface IListingService
{
    Task<CreatingListingResponse> CreateListingAsync(CreateListingRequest request);
}