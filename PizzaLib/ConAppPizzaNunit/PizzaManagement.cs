using System;
using System.Collections.Generic;

namespace ConAppPizzaNunit
{
    public class PizzaManagement
    {
        private List<PizzaNu> pizzas;

        public PizzaManagement()
        {
            pizzas = new List<PizzaNu>();
        }

        public void AddPizza(PizzaNu pizza)
        {
            pizzas.Add(pizza);
        }

        public List<PizzaNu> GetPizzas()
        {
            return pizzas;
        }
    }

}