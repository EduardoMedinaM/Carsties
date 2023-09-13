using AuctionsService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionsService.Data;
public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }
    
}
