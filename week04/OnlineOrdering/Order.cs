using System.Reflection.Metadata.Ecma335;

public class Order
{
    private Customer _customer;
    private Address _address;
    private List<Product> _productList;

    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
        _productList = new List<Product>();
    }

    public void SetProductList(Product product)
    {
        _productList.Add(product);
    }

    public double TotalCost()
    {
        double _totalCost = 0;
        foreach (Product product in _productList)
        {
            _totalCost += product.PartialCost();
        }
        if (_customer.LivesInUsa() == "Yes")
        {
            _totalCost = _totalCost + 5;
        }
        else
        {
            _totalCost = _totalCost + 35;
        }
        return _totalCost;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Paking label:");
        foreach (Product product in _productList)
        {
            Console.WriteLine(product.GetProduct());
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Shipping label:");
        Console.WriteLine(_customer.GetCustomer());
        Console.WriteLine(_address.GetAddress());
    }
}