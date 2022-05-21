using MethodsAndProperties;

CookieCustomer customer = new(1, "Stephen Gowen");

Console.WriteLine(customer);

char firstChar = customer.NameFirstChar;
Console.WriteLine($"Customer's name starts with {firstChar}");