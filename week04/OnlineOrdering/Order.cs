public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private Address _packingLabel;
    private Address _shippingLabel;

    public Order()
    {
        _customer = new Customer();
        _packingLabel = _customer.getAddress();
        _shippingLabel = _customer.getAddress();
    }

    public Order(Customer customer)
    {
        _customer = customer;
        _packingLabel = _customer.getAddress();
        _shippingLabel = _customer.getAddress();
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public Customer getCustomer()
    {
        return _customer;
    }

    public void setCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void setPackingLabel(Address address)
    {
        _packingLabel = address;
    }

    public string getPackingLabel()
    {
        return _packingLabel.getString();
    }

    public void setShippingLabel(Address address)
    {
        _shippingLabel = address;
    }

    public string getShippingLabel()
    {
        return _shippingLabel.getString();
    }

    public double calcTotal()
    {
        double total = 0.0;
        for (int i = 0; i < _products.Count(); i++)
        {
            total += _products[i].getPrice() * _products[i].getQuantity();
        }
        if (_customer.checkUnited() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
}