using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers;

[ApiController]
[Route( "compositions" )]

public class CompositionController : ControllerBase
{
    private readonly ICompositionRepository _compositionRepository;
    public CompositionController( ICompositionRepository compositionRepository )
    {
        _compositionRepository = compositionRepository;
    }

    [HttpPost( "" )]
    public IActionResult CreateComposition( [FromBody] CreateCompositionRequest request )
    {
        Composition composition = new( request.Name, request.Description, request.HeroesInfo, request.AuthorId );
        _compositionRepository.Save( composition );

        return Ok();
    }
}
