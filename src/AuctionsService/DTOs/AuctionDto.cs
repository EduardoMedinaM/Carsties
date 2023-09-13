namespace AuctionsService.DTOs;

public record AuctionDto(
    Guid Id,
    string Seller,
    string Winner,
    int? SoldAmount,
    int? CurrentHighBid,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    DateTime AuctionEnd,
    string Status,
    string Make,
    string Model,
    int Year,
    string Color,
    int Mileage,
    string ImageUrl,
    int ReservePrice
);
