using CodeRefacto;

Console.WriteLine("Hello, World!");

AfterRefacto processor = new AfterRefacto();

Item item1 = new Item { Id = 1, Name = "Pc Dell", Price = 1000.00m };
Item item2 = new Item { Id = 2, Name = "Clavier mechanique", Price = 150.00m };

Order order = new Order
{
    Id = 1,
    IsVerified = true,
    Status = "ReadyToProcess"
};
order.Items.Add(item1);
order.Items.Add(item2);


processor.Process(order);
Console.WriteLine($"La commande {order.Id} a ete traitee : {order.IsProcessed}");