using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PizzaHut
    {
        /// <summary>
        /// ...Product
        /// </summary>
        interface IPizza
        {
            string Eat();
        }
        /// <summary>
        /// ...ConcreteProduct
        /// </summary>
        class CheesePizza : IPizza
        {
            public string Eat()
            {
                return "You ordered a Cheese Pizza";
            }
        }
        /// <summary>
        /// ...ConcreteProduct
        /// </summary>
        class ChickenPizza : IPizza
        {
            public string Eat()
            {
                return "You ordered a Chicken Pizza";
            }
        }

        /// <summary>
        /// ...Creator
        /// </summary>
        interface IPizzaFactory
        {
            IPizza CreatePizza();
        }
        /// <summary>
        /// Represents a factory for creating cheese pizzas.
        /// </summary>
        /// <remarks>This factory implements the <see cref="IPizzaFactory"/> interface and provides a
        /// method to create instances of <see cref="CheesePizza"/>.</remarks>
        class CheesePizzaFactory : IPizzaFactory
        {
            public IPizza CreatePizza()
            {
                return new CheesePizza();
            }
        }

        /// <summary>
        /// Represents a factory for creating chicken pizzas.
        /// </summary>
        /// <remarks>This factory implements the <see cref="IPizzaFactory"/> interface and provides a
        /// method to create instances of <see cref="ChickenPizza"/>.</remarks>
        class ChickenPizzaFactory : IPizzaFactory
        {
            public IPizza CreatePizza()
            {
                return new ChickenPizza();
            }
        }

        /// <summary>
        /// Represents a service that processes pizza orders.
        /// </summary>
        /// <remarks>This interface defines a contract for ordering pizzas by specifying the type of pizza
        /// desired. Implementations of this interface are responsible for fulfilling the order and returning a
        /// confirmation or result.</remarks>
        interface Waiter
        {
            string OrderPizza(string type);
        }

        /// <summary>
        /// Represents a waiter at Pizza Hut who can take pizza orders and serve them.
        /// </summary>
        /// <remarks>This class provides functionality to order a specific type of pizza by name.
        /// Supported pizza types include "cheese" and "chicken". If an unsupported type is requested, an error message
        /// is returned.</remarks>
        public class PizzaHutWaiter : Waiter
        {
            public string OrderPizza(string type)
            {
                try
                {
                    IPizzaFactory factory = type.ToLower() switch
                    {
                        "cheese" => new CheesePizzaFactory(),
                        "chicken" => new ChickenPizzaFactory(),
                        _ => throw new ArgumentException("Invalid pizza type")
                    };
                    IPizza pizza = factory.CreatePizza();
                    return pizza.Eat();
                }
                catch (ArgumentException ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}// End of PizzaHut.cs
