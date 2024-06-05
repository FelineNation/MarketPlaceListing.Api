using MarketPlaceListing.Core.Interfaces;
using MarketPlaceListing.Dto;
using MarketPlaceListing.EventHub.Interfaces;
using AutoMapper;

namespace MarketPlaceListing.Core.Services;

public class MarketPlaceListingService : IListingService
{
    private readonly ITopicProducer _topicProducer;
    private readonly IMapper _mapper;
    public MarketPlaceListingService(ITopicProducer topicProducer, IMapper mapper)
    {
        _topicProducer = topicProducer;
        _mapper = mapper;
    }
    
    public async Task<CreatingListingResponse> CreateListingAsync(CreateListingRequest request)
    {
        // Todo: Implement the logic to publish the listing item to the marketplace
        await Task.Delay(100);
        var listingItems = request.ListingItems;
        var result = new CreatingListingResponse(){
            AsAt = DateTime.UtcNow,
            ListedItems = MapToElasticListingItem(listingItems!)
        };
        return result;
    }

    private List<ElasticListingItem> MapToElasticListingItem(List<ListingItem> listingItems)
    {
        var elasticListingItems = new List<ElasticListingItem>();
        foreach (var item in listingItems)
        {
            var elasticItem = _mapper.Map<ElasticListingItem>(item);
            elasticListingItems.Add(elasticItem);
        }
        return elasticListingItems;
    }
}