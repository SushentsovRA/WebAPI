namespace Domain.Entities;
public class Play
{
    public int PlayId { get; private init; }
    public string NameOfPlay { get; private set; }
    public DateTime StartDateTimeUtc { get; private set; }
    public DateTime EndDateTimeUtc { get; private set; }
    public int Price { get; private set; }
    public string PlayDesription { get; private set; }
    public int TheaterId { get; private init; }
    public int CompositionId { get; private init; }

    public Play (int playid, string nameofplay, DateTime startdatetimeutc, DateTime enddatetimeutc, int price, string playdesription, int theaterid, int compositionid )
    {
        PlayId = playid;
        NameOfPlay = nameofplay;
        StartDateTimeUtc = startdatetimeutc;
        EndDateTimeUtc = enddatetimeutc;
        Price = price;
        PlayDesription = playdesription;
        TheaterId = theaterid;
        CompositionId = compositionid;
    }
}
