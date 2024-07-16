using System.Text.Json.Serialization;

namespace WebAPI.Dto;

public class CreateCompositionRequest
{
    [JsonPropertyName( "name" )]
    public string Name { get; private set; }

    [JsonPropertyName( "description" )]
    public string Description { get; private set; }

    [JsonPropertyName( "heroesInfo" )]
    public string HeroesInfo { get; private set; }

    [JsonPropertyName( "authorId" )]
    public int AuthorId { get; private init; }
}
