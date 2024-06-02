using MarketPlaceListing.Core.Services;
using MarketPlaceListing.Dto;

namespace MarketPlaceListing.Core.Interfaces;

public interface IListingService
{
    Task CreateListingAsync(CreateListingRequest request);
}