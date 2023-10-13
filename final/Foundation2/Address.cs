public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

    public Address(string streetAddress, string city, string state, string country, string zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA");
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}, {_zipCode}\n{_country}";
    }
}