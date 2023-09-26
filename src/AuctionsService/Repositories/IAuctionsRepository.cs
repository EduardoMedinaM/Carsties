using AuctionsService.DTOs;

namespace AuctionsService.Repositories;

public interface IAuctionsRepository
{
    public Task<IEnumerable<AuctionDto>> GetAllAuctionsAsync();
    public Task<AuctionDto> GetAuctionByIdAsync(Guid id);
    public Task<AuctionDto> CreateAuctionAsync(CreateAuctionDto createAuctionDto);
}
