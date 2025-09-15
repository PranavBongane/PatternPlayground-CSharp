using static Abstract_Factory.Canteen;

var waiter = new Waiter();

waiter.TakeOrder("Coffee");   // Your Coffee is ready...😊
waiter.TakeOrder("Samosa");   // Your Samosa is ready...😊
waiter.TakeOrder("Milkshake"); // Sorry, we don't have that item.
