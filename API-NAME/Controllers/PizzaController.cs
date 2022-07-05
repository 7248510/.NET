using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Services;
//This is not persitent. The data is saved in an in-memory cache
namespace ContosoPizza.Controllers
{
    //dotnet tool install -g Microsoft.dotnet-httprepl
    //httprepl http://localhost:5000
    //cd API
    //GET
    [ApiController]
    [Route("[controller]")] //Route(will get processed as a controller)
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
            //Empty constructor
        }
        //dotnet build && dotnet run
        //GET ALL
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
            PizzaService.GetAll();

        [HttpGet("{name}")] //Search by name
        public ActionResult<Pizza> GetName(string name) //Pass the ID is the parameters
        {
            //Console.WriteLine(name);
            var pizza = PizzaService.GetName(name); //Get a single ID
            //Console.WriteLine(pizza);
            if(pizza == null)
                return NotFound();
            return pizza; //Else return Pizza
        }
        // POST action
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Create), new {id=pizza.Id}, pizza);
        }
        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id) {
                return BadRequest(); //Will return bad request result
            }
            var existingPizza = PizzaService.Get(id);
            if (existingPizza is null) {
                return NotFound();
                //return not found result
            }
            PizzaService.Update(pizza);
            return NoContent(); //return no content result
        }
        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza is null) {
                return NotFound();
            }
            PizzaService.Delete(id);
            return NoContent();
        }
    }
}