using AuctionsService.Data;
using AuctionsService.DTOs;
using AuctionsService.Entities;
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
        _mapper.Map<List<AuctionDto>>(await _auctionDbContext
                    .Auctions
                    .Include(x => x.Item)
                    .OrderBy(x => x.Item.Make)
                    .ToListAsync());
    public async Task<AuctionDto> GetAuctionByIdAsync(Guid id) =>
        _mapper.Map<AuctionDto>(
            await _auctionDbContext
            .Auctions
            .Include(x => x.Item)
            .FirstOrDefaultAsync(x => x.Id == id));

    public async Task<AuctionDto> CreateAuctionAsync(CreateAuctionDto createAuctionDto)
    {
        var auction = _mapper.Map<Auction>(createAuctionDto);

        // TODO: add current user as seller
        auction.Seller = "test";

        // Added to memory and track the 'Auction' entity
        await _auctionDbContext.Auctions.AddAsync(auction);

        var operations = await _auctionDbContext.SaveChangesAsync() > 0;
        if(!operations) return null;

        return _mapper.Map<AuctionDto>(auction);
    }
            
}
