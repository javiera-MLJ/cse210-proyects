public class Order
{
    List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        return total + ShippingCost();
    }

    public int ShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string PackingLabel()
    {
        {
            string label = "";
            foreach (Product product in _products)
            {
                label += $"{product.GetDisplayProduct()}";
            }
            return label;
        }
    }

    public string ShippingLabel()
    {
        return _customer.DisplayText();
    }
    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

}