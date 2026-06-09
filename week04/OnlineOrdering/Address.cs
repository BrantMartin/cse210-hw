public class Address
{
    private string _streetAdd;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        _streetAdd = "";
        _city = "";
        _state = "";
        _country = "";
    }

    public Address(string streetAdd, string city, string state, string country)
    {
        _streetAdd = streetAdd;
        _city = city;
        _state = state;
        _country = country;
    }

    public void setStreetAdd(string streetAdd)
    {
        _streetAdd = streetAdd;
    }

    public string getStreetAdd()
    {
        return _streetAdd;
    }

    public void setCity(string city)
    {
        _city = city;
    }

    public string getCity()
    {
        return _city;
    }

    public void setState(string state)
    {
        _state = state;
    }

    public string getState()
    {
        return _state;
    }

    public void setCountry(string country)
    {
        _country = country;
    }

    public string getCountry()
    {
        return _country;
    }

    public bool checkUnited()
    {
        if (_country == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string getString()
    {
        return $"{_streetAdd} {_city}, {_state}, {_country}";
    }
}