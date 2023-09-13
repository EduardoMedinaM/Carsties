using AuctionsService.DTOs;
using AuctionsService.Entities;
using AutoMapper;

namespace AuctionsService.Mappers;

public class AuctionMappingProfile : Profile
{
    public AuctionMappingProfile()
    {
        CreateMap<Auction, AuctionDto>()
        .IncludeMembers(x => x.Item);

        CreateMap<Item, AuctionDto>()
        .IncludeMembers();

        CreateMap<CreateAuctionDto, Auction>()
        .ForMember(d => d.Item, o => o.MapFrom(dto => dto));

        CreateMap<CreateAuctionDto, Item>();
    }
}
