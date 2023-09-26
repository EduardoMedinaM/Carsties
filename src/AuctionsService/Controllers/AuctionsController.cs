using AuctionsService.DTOs;
using AuctionsService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AuctionsService.Controllers;

[ApiController]
[Route("api/{controller}")]
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

    [HttpGet("{id}")]
    [ActionName(nameof(GetAuctionByIdAsync))]
    public async Task<ActionResult<AuctionDto>> GetAuctionByIdAsync(Guid id)
    {
        var auctionDto = await _auctionDbRepository.GetAuctionByIdAsync(id);
        if (auctionDto is null) return NotFound(id);
        return Ok(auctionDto);
    }

    [HttpPost]
    public async Task<ActionResult<AuctionDto>> CreateAuctionAsync(CreateAuctionDto createAuction)
    {
        var auctionDto = await _auctionDbRepository.CreateAuctionAsync(createAuction);
        if (auctionDto is null) return BadRequest("Could not save changes to the DB.");
        return CreatedAtAction(nameof(GetAuctionByIdAsync), new { id = auctionDto.Id }, auctionDto);
    }
}
