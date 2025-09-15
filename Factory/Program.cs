
using Factory;

PizzaHut.PizzaHutWaiter waiter = new PizzaHut.PizzaHutWaiter();

string order1 = waiter.OrderPizza("cheese");
Console.WriteLine(order1);
string order2 = waiter.OrderPizza("chicken");   
Console.WriteLine(order2);
string order3 = waiter.OrderPizza("veggie");    
Console.WriteLine(order3);