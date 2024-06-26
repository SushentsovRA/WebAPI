namespace Domain.Entities;
public class Theater
{
    public int TheaterId { get; private init; }
    public string NameOfTheater { get; private set; }
    public string Address { get; private init; }
    public DateTime FirstOpenDate { get; private init; }
    public TimeOnly OpenTime { get; private set; }
    public TimeOnly CloseTime { get; private set; }
    public string TheaterDesription { get; private set; }
    public string PhoneNumber { get; private set; }

    public Theater (int theaterid, string nameoftheater, string address, DateTime firstopen, TimeOnly opentime, TimeOnly closetime, string theaterdesription, string phonenumber)
    {
        TheaterId = theaterid;
        NameOfTheater = nameoftheater;
        Address = address;
        FirstOpenDate = firstopen;
        OpenTime = opentime;
        CloseTime = closetime;
        TheaterDesription = theaterdesription;
        PhoneNumber = phonenumber;
    }
    public void SetName( string name )
    {
        if ( string.IsNullOrWhiteSpace( name ) )
        {
            throw new ArgumentException( $"'{nameof( name )}' cannot be null or whitespace.", nameof( name ) );
        }

        Name = name;
    }
}
