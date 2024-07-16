using System.Text;

namespace Domain.Entities;
public class Author
{
    private string _name;
    private DateOnly _birthDate;

    public int AuthorId { get; private init; }

    public string Name { get; private set; }

    public DateOnly BirthDate { get; private set; }

    public List<Composition> Compositions { get; set; } = new List<Composition>();

    public Author( string name, DateOnly birthDate )
    {
        Name = name;
        BirthDate = birthDate;
    }

    public void SetName( string name )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or whitespace.", nameof( name ) );
        }

        Name = name;
    }

    public override string ToString()
    {
        StringBuilder sb = new( 300 );
        sb.AppendLine( "[Author]" );
        sb.AppendLine( $"  AuthorId: {AuthorId}" );
        sb.AppendLine( $"  Name: {Name}" );
        sb.AppendLine( $"  BirthDate: {BirthDate}" );

        return sb.ToString();
    }
}
