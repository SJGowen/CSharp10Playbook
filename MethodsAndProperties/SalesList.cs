namespace MethodsAndProperties;

public class SalesList
{
    private readonly List<Sale> _sales = new();

    public (string CustomerName, decimal TotalSpent, int NumberOfSales) GetHighestValueCustomer()
    {
        var customersBySpend = from transaction in _sales
                               group transaction by transaction.Customer into grouping
                               let totalValue = grouping.Select(x => x.Value).Sum()
                               let salesCount = grouping.Count()
                               orderby totalValue descending
                               select (grouping.Key.Name, totalValue, salesCount);
        return customersBySpend.First();
    }

    public IEnumerable<Sale> EnumerateItems()
    {
        foreach (var item in _sales)
            yield return item;
    }

    /// <summary>
    /// This is an example of how you enable Fluent Coding
    ///  * For All Fluent Methods you return the Class Name
    ///  * and you return this at the bottom of the method 
    ///  
    /// Fluent methods might slightly impact performance...
    /// because of the extra overhead in returning a value
    /// instead of void.
    /// </summary>
    public SalesList AddSale(Sale item)
    {
        _sales.Add(item);
        return this;
    }
}
