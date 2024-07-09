using System.Text;

namespace Domain.Entities;
public class Play
{
    public int PlayId { get; private init; }
    public string Name { get; private set; }
    public DateTime StartDateTimeUtc { get; private set; }
    public DateTime EndDateTimeUtc { get; private set; }
    public decimal Price { get; private set; }
    public string Description { get; private set; }
    public int TheaterId { get; private init; }
    public int CompositionId { get; private init; }

    public Play( int playId, string name, DateTime startDateTimeUtc, DateTime endDateTimeUtc, decimal price, string description, int theaterId, int compositionId )
    {
        PlayId = playId;
        Name = name;
        StartDateTimeUtc = startDateTimeUtc;
        EndDateTimeUtc = endDateTimeUtc;
        Price = price;
        Description = description;
        TheaterId = theaterId;
        CompositionId = compositionId;
    }
    public override string ToString()
    {
        StringBuilder sb = new( 300 );
        sb.AppendLine( "[Play]" );
        sb.AppendLine( $"  PlayId: {PlayId}" );
        sb.AppendLine( $"  Name: {Name}" );
        sb.AppendLine( $"  StartDateTimeUtc:{StartDateTimeUtc}" );
        sb.AppendLine( $"  EndDateTimeUtc:{EndDateTimeUtc}" );
        sb.AppendLine( $"  Price:{Price}" );
        sb.AppendLine( $"  Description:{Description}" );
        sb.AppendLine( $"  TheaterId:{TheaterId}" );
        sb.AppendLine( $"  CompositionId:{CompositionId}" );

        return sb.ToString();
    }
}