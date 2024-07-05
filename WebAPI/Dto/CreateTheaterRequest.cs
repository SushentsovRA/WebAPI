namespace WebAPI.Dto;

public class CreateHotelRequest
{
    public string Name { get; private set; }
    public string Address { get; private init; }
    public DateTime FirstOpenDate { get; private init; }
    public TimeOnly OpenTime { get; private set; }
    public TimeOnly CloseTime { get; private set; }
    public string Description { get; private set; }
    public string PhoneNumber { get; private set; }
}