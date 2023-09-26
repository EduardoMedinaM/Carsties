using AuctionsService.DTOs;
using AuctionsService.Entities;

namespace AuctionsService.Repositories;

public interface IAuctionsRepository
{
    public Task<IEnumerable<AuctionDto>> GetAllAuctionsAsync();
    public Task<AuctionDto> GetAuctionByIdAsync(Guid id);

}
