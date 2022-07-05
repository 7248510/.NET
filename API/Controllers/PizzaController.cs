using System.Collections.Generic;
using System.Linq;
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
        // GET ID
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id) //Pass the ID is the parameters
        {
            var pizza = PizzaService.Get(id); //Get a single ID
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