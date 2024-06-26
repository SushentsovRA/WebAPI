namespace Domain.Entities;
public class Composition
{
    public int CompositionId { get; private init; }
    public string NameOfComposition { get; private set; }
    public string CompositionDesription { get; private set; }
    public string HeroesInfo { get; private set; }
    public int AuthorId { get; private init; }

    public Composition ( int compositionid, string nameofcomposition, string compositiondesription, string heroesinfo, int authorid)
    {
        CompositionId = compositionid;
        NameOfComposition = nameofcomposition;
        CompositionDesription = compositiondesription;
        HeroesInfo = heroesinfo;
        AuthorId = authorid;
    }
    public void SetNameOfComposition( string nameofcomposition )
    {
        if ( string.IsNullOrWhiteSpace( nameofcomposition ) )
        {
            throw new ArgumentException( $"'{nameof( nameofcomposition )}' cannot be null or whitespace.", nameof( nameofcomposition ) );
        }

        NameOfComposition = nameofcomposition;
    }
    public void SetCompositionDesription( string compositiondesription )
    {
        if ( string.IsNullOrWhiteSpace( compositiondesription ) )
        {
            throw new ArgumentException( $"'{nameof( compositiondesription )}' cannot be null or whitespace.", nameof( compositiondesription ) );
        }

        CompositionDesription = compositiondesription;
    }
    public void SetHeroesInfo( string heroesinfo )
    {
        if ( string.IsNullOrWhiteSpace( heroesinfo ) )
        {
            throw new ArgumentException( $"'{nameof( heroesinfo )}' cannot be null or whitespace.", nameof( heroesinfo ) );
        }

        HeroesInfo = heroesinfo;
    }
}
