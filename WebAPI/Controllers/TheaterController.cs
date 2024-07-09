using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Foundation.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers;
[ApiController]
[Route( "theaters" )]

public class TheaterController : ControllerBase
{
    private readonly ITheaterRepository _theaterRepository;
    public TheaterController( ITheaterRepository theaterRepository )
    {
        _theaterRepository = theaterRepository;
    }

    [HttpPost( "" )]
    public IActionResult CreateHotel( [FromBody] CreateHotelRequest request )
    {
        Theater theater = new( request.Name, request.Address, request.FirstOpenDate, request.OpenTime, request.CloseTime, request.Description, request.PhoneNumber );
        _theaterRepository.Save( theater );

        return Ok();
    }
}