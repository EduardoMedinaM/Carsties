namespace AuctionsService.DTOs;

public record UpdateAuctionDto(
    string Make,
    string Model,
    int Year,
    string Color,
    int Mileage
);
