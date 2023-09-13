﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionsService.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }

    /*
    * Nav properties (1:1)
    */
    public Guid AuctionId { get; set; }
    public Auction Auction { get; set; }
}