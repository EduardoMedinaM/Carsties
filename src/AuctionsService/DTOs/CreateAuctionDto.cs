using System.ComponentModel.DataAnnotations;

namespace AuctionsService.DTOs;

public record CreateAuctionDto(
    [Required] string Make,
    [Required] string Model,
    [Required] int Year,
    [Required] string Color,
    [Required] int Mileage,
    [Required] string ImageUrl,
    [Required] int ReservePrice,
    [Required] DateTime AuctionEnd
);
