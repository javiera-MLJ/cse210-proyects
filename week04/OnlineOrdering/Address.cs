public class Address
{
    private string _city;
    private string _stateOrProvince;
    private string _street;
    private string _country;

    public Address(string city, string street, string stateOrProvince, string country)
    {
        _city = city;
        _stateOrProvince = stateOrProvince;
        _street = street;
        _country = country;
    }

    public bool LiveInUnitedStates()
    {
        return _country.ToUpper() == "USA";
    }
    public string GetDisplayAddress()
    {
        return $"{_city}, {_stateOrProvince}, {_street}, {_country}";
    }
}