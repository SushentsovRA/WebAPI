using System.Text.Json.Serialization;

namespace WebAPI.Dto;

public class CreateHotelRequest
{
    [JsonPropertyName( "name" )]
    public string Name { get; private set; }
    [JsonPropertyName( "address" )]
    public string Address { get; private init; }
    [JsonPropertyName( "firstOpenDate" )]
    public DateTime FirstOpenDate { get; private init; }
    [JsonPropertyName( "openTime" )]
    public TimeOnly OpenTime { get; private set; }
    [JsonPropertyName( "closeTime" )]
    public TimeOnly CloseTime { get; private set; }
    [JsonPropertyName( "description" )]
    public string Description { get; private set; }
    [JsonPropertyName( "phoneNumber" )]
    public string PhoneNumber { get; private set; }
}