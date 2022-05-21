namespace MethodsAndProperties;

public class Sale
{
    public CookieCustomer Customer { get; }
    public decimal Value { get; }

    public Sale(CookieCustomer customer, decimal value)
    {
        Customer = customer ?? throw new ArgumentException("A sale cannot have a null customer", nameof(customer));

        Value = value;
    }
}
