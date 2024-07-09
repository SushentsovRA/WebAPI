using System.Text;

namespace Domain.Entities;
public class Composition
{
    public int CompositionId { get; private init; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string HeroesInfo { get; private set; }
    public int AuthorId { get; private init; }
    public List<Play> Plays { get; set; } = new List<Play>();

    public Composition( int compositionId, string name, string description, string heroesInfo, int authorId )
    {
        CompositionId = compositionId;
        Name = name;
        Description = description;
        HeroesInfo = heroesInfo;
        AuthorId = authorId;
    }
    public void SetName( string name )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or whitespace.", nameof( name ) );
        }

        Name = name;
    }
    public void SetDescription( string description )
    {
        if ( string.IsNullOrWhiteSpace( description ) )
        {
            throw new ArgumentException( $"'{nameof( description )}' cannot be null or whitespace.", nameof( description ) );
        }

        Description = description;
    }
    public void SetHeroesInfo( string heroesInfo )
    {
        if ( string.IsNullOrWhiteSpace( heroesInfo ) )
        {
            throw new ArgumentException( $"'{nameof( heroesInfo )}' cannot be null or whitespace.", nameof( heroesInfo ) );
        }

        HeroesInfo = heroesInfo;
    }
    public override string ToString()
    {
        StringBuilder sb = new( 300 );
        sb.AppendLine( "[Composition]" );
        sb.AppendLine( $"  CompositionId: {CompositionId}" );
        sb.AppendLine( $"  Name: {Name}" );
        sb.AppendLine( $"  Description:{Description}" );
        sb.AppendLine( $"  HeroesInfo:{HeroesInfo}" );
        sb.AppendLine( $"  AuthorId:{AuthorId}" );

        return sb.ToString();
    }
}
