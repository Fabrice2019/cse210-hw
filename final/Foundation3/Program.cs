using System;
using System.Collections.Generic;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public override string ToString()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{_address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: General Event";
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: General Event\nTitle: {_title}\nDate: {_date}";
    }
}

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Lecture\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Lecture\nTitle: {_title}\nDate: {_date}";
    }
}

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDate: {_date}";
    }
}

class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 High St", "Othertown", "ON", "Canada");
        Address address3 = new Address("789 Park Ave", "Sometown", "TX", "USA");

        // Create events
        Lecture lecture = new Lecture("C# Programming Lecture", "Learn about advanced C# programming techniques", "05/30/2024", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Networking Event", "Connect with professionals in your field", "06/15/2024", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Join us for a fun and relaxing picnic", "07/04/2024", "12:00 PM", address3, "Sunny and warm");

        // Create a list of events
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}
