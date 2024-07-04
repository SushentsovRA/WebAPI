using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

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
}