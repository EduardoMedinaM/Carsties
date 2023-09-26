using System.ComponentModel.DataAnnotations;

namespace AuctionsService.DTOs;

public class CreateAuctionDto
{
    [Required] public string Make { set; get; }
    [Required] public string Model { set; get; }
    [Required] public int Year { set; get; }
    [Required] public string Color { set; get; }
    [Required] public int Mileage { set; get; }
    [Required] public string ImageUrl { set; get; }
    [Required] public int ReservePrice { set; get; }
    [Required] public DateTime AuctionEnd { set; get; }
};
