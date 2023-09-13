using AuctionsService.DTOs;
using AuctionsService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AuctionsService.Controllers;

[ApiController]
[Route("api/[controllerName]")]
public class AuctionsController : ControllerBase
{
    private readonly IAuctionsRepository _auctionDbRepository;

    public AuctionsController(IAuctionsRepository auctionDbRepository)
    {
        _auctionDbRepository = auctionDbRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AuctionDto>>> GetAllAuctionsAsync() => 
        Ok(await _auctionDbRepository.GetAllAuctionsAsync());
}
