public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    public void SetProduct(string productName, string productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public double PartialCost()
    {
        return _productPrice * _productQuantity;
    }

    public string GetProduct()
    {
        return $"Product: {_productName}, ID: {_productId}";
    }
}