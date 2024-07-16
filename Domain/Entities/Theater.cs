﻿using System;
using System.Net;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace Domain.Entities;

public class Theater
{
    public int TheaterId { get; private init; }

    public string Name { get; private set; }

    public string Address { get; private init; }

    public DateTime FirstOpenDate { get; private init; }

    public TimeOnly OpenTime { get; private set; }

    public TimeOnly CloseTime { get; private set; }

    public string Description { get; private set; }

    public string PhoneNumber { get; private set; }

    public List<Author> Authors { get; private init; } = new List<Author>();

    public List<Play> Plays { get; private set; } = new List<Play>();

    public Theater( string name, string address, DateTime firstOpenDate, TimeOnly openTime, TimeOnly closeTime, string description, string phoneNumber )
    {
        Name = name;
        Address = address;
        FirstOpenDate = firstOpenDate;
        OpenTime = openTime;
        CloseTime = closeTime;
        Description = description;
        PhoneNumber = phoneNumber;
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

    public void SetPhoneNumber( string phoneNumber )
    {
        if ( string.IsNullOrWhiteSpace( phoneNumber ) )
        {
            throw new ArgumentException( $"'{nameof( phoneNumber )}' cannot be null or whitespace.", nameof( phoneNumber ) );
        }
        PhoneNumber = phoneNumber;
    }

    public void CopyFrom( Theater other )
    {
        SetName( other.Name );
        SetDescription( other.Description );
        SetPhoneNumber( other.PhoneNumber );
    }

    public override string ToString()
    {
        StringBuilder sb = new( 300 );
        sb.AppendLine( "[Theater]" );
        sb.AppendLine( $"  TheaterId: {TheaterId}" );
        sb.AppendLine( $"  Name: {Name}" );
        sb.AppendLine( $"  Address: {Address}" );
        sb.AppendLine( $"  FirstOpenDate: {FirstOpenDate}" );
        sb.AppendLine( $"  OpenTime: {OpenTime}" );
        sb.AppendLine( $"  CloseTime: {CloseTime}" );
        sb.AppendLine( $"  Description: {Description}" );
        sb.AppendLine( $"  PhoneNumber: {PhoneNumber}" );

        return sb.ToString();
    }
}