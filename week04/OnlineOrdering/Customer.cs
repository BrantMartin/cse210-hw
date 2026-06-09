public class Customer
{
    public string _name;
    public Address _address;

    public Customer()
    {
        _name = "";
        _address = new Address();
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public string getName()
    {
        return _name;
    }

    public Address getAddress()
    {
        return _address;
    }

    public bool checkUnited()
    {
        return _address.checkUnited();
    }
}