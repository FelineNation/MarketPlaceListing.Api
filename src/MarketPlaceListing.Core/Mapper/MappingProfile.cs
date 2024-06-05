using AutoMapper;
using MarketPlaceListing.Dto;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ListingItem, ElasticListingItem>().ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            .ForMember(dest => dest.PreviewImageUrl, opt => opt.MapFrom(src => src.ImageUrl != null ? src.ImageUrl.FirstOrDefault() : null))
            .ForMember(dest => dest.ListingStartDate, opt => opt.MapFrom(src => src.ListingStartDate))
            .ForMember(dest => dest.ListingEndDate, opt => opt.MapFrom(src => src.ListingEndDate))
            .ForMember(dest => dest.ListingItemId, opt => opt.MapFrom(src => src.ListingItemId))
            .ForMember(dest => dest.ListingStatus, opt => opt.MapFrom(src => ListingStatus.Pending));
    }
}