using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers;

[ApiController]
[Route( "authors" )]

public class AuthorController : ControllerBase
{
    private readonly IAuthorRepository _authorRepository;
    public AuthorController( IAuthorRepository authorRepository )
    {
        _authorRepository = authorRepository;
    }

    [HttpPost( "" )]
    public IActionResult CreateAuthor( [FromBody] CreateAuthorRequest request )
    {
        Author author = new( request.Name, request.BirthDate );
        _authorRepository.Save( author );

        return Ok();
    }
}
