using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Entities;
public class Author
{
    public int AuthorId { get; private init; }
    public string NameOfAuthor { get; private set; }
    public DateOnly BirthDate { get; private set; }

    public Author ( int authorid, string nameofauthor, DateOnly birthdate )
    {
        AuthorId = authorid;
        NameOfAuthor = nameofauthor;
        BirthDate = birthdate;
    }
    public void SetNameOfAuthor( string nameofauthor )
    {
        if ( string.IsNullOrWhiteSpace( nameofauthor ) )
        {
            throw new ArgumentException( $"'{nameof( nameofauthor )}' cannot be null or whitespace.", nameof( nameofauthor ) );
        }

        NameOfAuthor = nameofauthor;
    }
    public void SetBirthDate( DateOnly birthdate )
    {
        if ( birthdate == DateOnly.MinValue )
        {
            throw new ArgumentException( $"'{nameof( birthdate )}' cannot be less then MinValue.", nameof( birthdate ) );
        }

        BirthDate = birthdate;
    }
}
