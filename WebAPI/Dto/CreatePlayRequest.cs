using System.Text.Json.Serialization;

namespace WebAPI.Dto;

public class CreatePlayRequest
{
    [JsonPropertyName( "name" )]
    public string Name { get; private set; }

    [JsonPropertyName( "startDateTimeUtc" )]
    public DateTime StartDateTimeUtc { get; private set; }

    [JsonPropertyName( "endDateTimeUtc" )]
    public DateTime EndDateTimeUtc { get; private set; }

    [JsonPropertyName( "price" )]
    public decimal Price { get; private set; }

    [JsonPropertyName( "description" )]
    public string Description { get; private set; }

    [JsonPropertyName( "theaterId" )]
    public int TheaterId { get; private init; }

    [JsonPropertyName( "compositionId" )]
    public int CompositionId { get; private init; }
}
