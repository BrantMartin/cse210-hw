public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product()
    {
        _name ="";
        _id = 0;
        _price = 0.0;
        _quantity = 0;
    }

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public string getName()
    {
        return _name;
    }

    public void setId(int id)
    {
        _id = id;
    }

    public int getId()
    {
        return _id;
    }

    public void setPrice(double price)
    {
        _price = price;
    }

    public double getPrice()
    {
        return _price;
    }

    public void setQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int getQuantity()
    {
        return _quantity;
    }
}