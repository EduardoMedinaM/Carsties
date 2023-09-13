using AuctionsService.Data;
using AuctionsService.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuctionsService.Repositories;

public class AuctionsRepository : IAuctionsRepository
{
    private readonly AuctionDbContext _auctionDbContext;
    private readonly IMapper _mapper;

    public AuctionsRepository(AuctionDbContext auctionDbContext, IMapper mapper)
    {
        _auctionDbContext = auctionDbContext;
        _mapper = mapper;
    }
    public async Task<IEnumerable<AuctionDto>> GetAllAuctionsAsync() =>
        _mapper.Map<IEnumerable<AuctionDto>>(
            await _auctionDbContext
                    .Auctions
                    .Include(x => x.Item)
                    .OrderBy(x => x.Item.Make)
                    .ToListAsync());
}
