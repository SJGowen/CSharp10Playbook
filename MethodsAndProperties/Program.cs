﻿using MethodsAndProperties;

CookieCustomer customer = new(1, "Stephen Gowen");

Console.WriteLine(customer);

char firstChar = customer.NameFirstChar;
Console.WriteLine($"Customer's name starts with {firstChar}");

CookieCustomer pluralsight = new(1, "Pluralsight");
CookieCustomer simon = new(2, "Simon the Soon-to-be-overweight");
CookieCustomer browserRobot = new(3, "Browser Robot");

SalesList sales = new();
sales.AddSale(new(simon, 200M))
    .AddSale(new(pluralsight, 80M))
    .AddSale(new(simon, 50M))
    .AddSale(new(browserRobot, 500.5M))
    .AddSale(new(pluralsight, 1000M))
    .AddSale(new(browserRobot, 50M))
    .AddSale(new(pluralsight, 20.25M));

// Fluent coding in LINQ
var highValueSales = sales.EnumerateItems()
    .Where(sale => sale.Value > 100)
    .OrderBy(sale => sale.Customer.Name);

foreach (var sale in highValueSales)
    Console.WriteLine($"{sale.Customer.Name} purchased {sale.Value:c} worth of Cookies");