public class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;

    public Customer(Address address)
    {
        _address = address;
    }

    public string LivesInUsa()
    {
        if (_address.GetUbication())
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }

    public void SetCustomer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string GetCustomer()
    {
        return $"Name: {_firstName} {_lastName}";
    }
}