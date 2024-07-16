using System.Text.Json.Serialization;

namespace WebAPI.Dto;

public class CreateAuthorRequest
{
    [JsonPropertyName( "name" )]
    public string Name { get; private set; }

    [JsonPropertyName( "birthDate" )]
    public DateOnly BirthDate { get; private set; }
}
