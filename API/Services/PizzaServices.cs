using ContosoPizza.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas {get;} //Init the list of Pizza's make it static so it persists
        static int nextId = 3; //Next ID in the line is 3
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            { //Some JSON values
                new Pizza { Id = 1, Name = "Pepperoni", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Supreme", IsGlutenFree = true }
            };
        }
        public static List<Pizza> GetAll() => Pizzas; //Get all instances of Pizza
        public static Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id); //Get the specific ID
        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++; //increment the ID
            Pizzas.Add(pizza);
        }
        public static void Delete(int id)
        {
            var pizza = Get(id);
            if(pizza is null)
                return;
            Pizzas.Remove(pizza);
        }
        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if(index == -1)
                return;
            Pizzas[index] = pizza;
        }
    }
}