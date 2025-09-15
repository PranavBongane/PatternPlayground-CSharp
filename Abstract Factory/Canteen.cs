using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Canteen
    {
        #region Products
        interface drinks // drinks interface (PRODUCT)
        {
            string getDrink();
        }

        class Coffee : drinks // Coffee class implementing drinks interface (concreet Implementation)
        {
            public string getDrink()
            {
                return "Your Coffee is ready...😊";
            }
        }

        class Tea : drinks // Tea class implementing drinks interface (concreet Implementation)
        {
            public string getDrink()
            {
                return "Your Tea is ready...😊";
            }
        }

        class Juice : drinks // Juice class implementing drinks interface (concreet Implementation)
        {
            public string getDrink()
            {
                return "Your Juice is ready...😊";
            }
        }

        interface snaks // snaks interface (PRODUCT)
        {
            string getSnaks();
        }

        class Samosa : snaks // Samosa class implementing snaks interface (concreet Implementation)
        {
            public string getSnaks()
            {
                return "Your Samosa is ready...😊";
            }
        }

        class VadaPav : snaks // VadaPav class implementing snaks interface (concreet Implementation)
        {
            public string getSnaks()
            {
                return "Your Vada Pav is ready...😊";
            }
        }

        class Sandwich : snaks // Sandwich class implementing snaks interface (concreet Implementation)
        {
            public string getSnaks()
            {
                return "Your Sandwich is ready...😊";
            }
        }
        #endregion

        #region Factories
        interface Shef // Shef interface (Abstract Factory)
        {
            dynamic Prepair(string order);
        }

        class DrinksShef : Shef // DrinksShef class implementing Shef interface (concreet Implementation of Abstract Factory)
        {
            public dynamic Prepair(string order)
            {
                if (order.Equals("Coffee", StringComparison.OrdinalIgnoreCase))
                {
                    return new Coffee();
                }
                else if (order.Equals("Tea", StringComparison.OrdinalIgnoreCase))
                {
                    return new Tea();
                }
                else if (order.Equals("Juice", StringComparison.OrdinalIgnoreCase))
                {
                    return new Juice();
                }
                else
                {
                    return null;
                }
            }

        }

        class SnaksShef : Shef // SnaksShef class implementing Shef interface (concreet Implementation of Abstract Factory)
        {
            public dynamic Prepair(string order)
            {
                if (order.Equals("Samosa", StringComparison.OrdinalIgnoreCase))
                {
                    return new Samosa();
                }
                else if (order.Equals("VadaPav", StringComparison.OrdinalIgnoreCase))
                {
                    return new VadaPav();
                }
                else if (order.Equals("Sandwich", StringComparison.OrdinalIgnoreCase))
                {
                    return new Sandwich();
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region Client
        public class Waiter
        {
            public void TakeOrder(string order)
            {
                Shef shef = null;

                switch (order.ToLower())
                {
                    case "coffee":
                    case "tea":
                    case "juice":
                        shef = new DrinksShef();
                        break;
                    case "samosa":
                    case "vadapav":
                    case "sandwich":
                        shef = new SnaksShef();
                        break;
                    default:
                        Console.WriteLine("Sorry, we don't have that item.");
                        return; // exit early for invalid order
                }

                var item = shef.Prepair(order);

                if (item is drinks drink)
                    Console.WriteLine(drink.getDrink());
                else if (item is snaks snak)
                    Console.WriteLine(snak.getSnaks());
            }
        }
        #endregion
    }
}
