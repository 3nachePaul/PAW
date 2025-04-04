// See https://aka.ms/new-console-template for more information

using Lab2;

// Exercise 1 would normally be called like this:
// Ex1.start();

// Exercise 2 would normally be called like this:
// Ex2.start();

// Exercise 3 would normally be called like this:
// Ex3.start();

// Exercise 4 would normally be called like this:
// Ex4.start();

// Exercise 5 would normally be called like this:
// Ex5.start();

// Creating instances of Dreptunghi and Patrat
Console.WriteLine("Creating Dreptunghi and Patrat objects:");
Dreptunghi dreptunghi = new Dreptunghi(5, 10);
Patrat patrat = new Patrat(7);

// Creating a Venue object
Venue venue = new Venue();

// Creating instances of different Item types
Product product = new Product
{
    ID = 1,
    Name = "Milk",
    Price = 2.5
};

Laptop laptop = new Laptop
{
    ID = 2,
    Name = "MacBook Pro",
    Price = 1999.99,
};

Ticket ticket = new Ticket
{
    ID = 3,
    Name = "Concert Ticket",
    Price = 75.0,
};

// Creating a Cart and adding items to it
Cart cart = new Cart();
cart.AddToCart(product);
cart.AddToCart(laptop);
cart.AddToCart(ticket);

// The following functionality would normally be called:
// cart.ComputeTotalPrice();
// cart.SortCartItems(0); // Sort by price ascending
// cart.DisplayByType(0); // Display all products

Console.WriteLine("Objects successfully instantiated!");
