public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.LiveInUnitedStates();
    }

    public string DisplayText()
    {
        return $"{ _name}\n{_address.GetDisplayAddress()}"; 
    }
}