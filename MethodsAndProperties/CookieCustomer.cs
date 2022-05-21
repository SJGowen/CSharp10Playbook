/// <summary>
/// Choosing a Property Type
/// 
/// Use simplest possible syntax:
/// 
///  * Backing field but no logic: Use auto-property
///    public string? Notes { get; set; }
/// 
///  * No backing field: Prefer expression-bodied property
///    public char NameFirstChar => Name[0];
/// 
///  * Backing field and logic: User full property syntax
///    private string _name;
///    public string Name
///    {
///        get { /* getter code */ }
///        set { /* setter code */ }
///    }
///    
/// </summary>

namespace MethodsAndProperties;

public class CookieCustomer
{
    public int ID { get; } // must be > 0
    public string Name { get; } // must contain something
    public string? Notes { get; set; }
    public char NameFirstChar => Name[0];

    public CookieCustomer(int id, string name, string? notes = null)
    {
        if (id <= 0)
            throw new ArgumentException($"Customer ID must be > 0. Value used for constructor was: {id}", nameof(id));
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Customer name cannot be null or whitespace", nameof(name));

        ID = id;
        Name = name;
        Notes = notes;
    }

    public override string ToString() => $"Customer ID = {ID}, Name = {Name}";
}
