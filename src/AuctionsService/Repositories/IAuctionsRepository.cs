using AuctionsService.DTOs;

namespace AuctionsService.Repositories;

public interface IAuctionsRepository
{
    public Task<IEnumerable<AuctionDto>> GetAllAuctionsAsync();
}
