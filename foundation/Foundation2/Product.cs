public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetCost()
    {
        return _quantity * _price;
    }

    public string Name()
    {
        return  _name;
    }

    public string Id()
    {
        return _productId;
    }

    public int Quantity()
    {
        return _quantity;
    }



}