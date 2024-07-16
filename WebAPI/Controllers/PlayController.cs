using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers;

[ApiController]
[Route( "plays" )]

public class PlayController : ControllerBase
{
    private readonly IPlayRepository _playRepository;
    public PlayController( IPlayRepository playRepository )
    {
        _playRepository = playRepository;
    }

    [HttpPost( "" )]
    public IActionResult CreatePlay( [FromBody] CreatePlayRequest request )
    {
        Play play = new( request.Name, request.StartDateTimeUtc, request.EndDateTimeUtc, request.Price, request.Description, request.TheaterId, request.CompositionId );
        _playRepository.Save( play );

        return Ok();
    }
}
