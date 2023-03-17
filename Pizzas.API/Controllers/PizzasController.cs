using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pizzas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Pizza> ListaPizzas = BD.GetAll();
            return Ok(ListaPizzas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Pizza pizza = BD.GetById(id);
            if (id <= 0) return BadRequest();
            else if (pizza == null) return NotFound();
            else return Ok(pizza);
        }

        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            int RowsAffected = BD.Insert(pizza);
            return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            Pizza entity = BD.GetById(id);
            int RowsAffected;
            if (id != pizza.Id) return BadRequest();
            else
            {
                if (entity == null) return NotFound();
                else
                {
                    RowsAffected = BD.UpdateById(pizza);
                    if (RowsAffected > 0) return Ok(pizza);
                    else return NotFound();
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            Pizza entity = BD.GetById(id);
            int RowsAffected;
            if (entity == null) return NotFound();
            else
            {
                RowsAffected = BD.DeleteById(id);
                if (RowsAffected > 0) return Ok(pizza);
                else return NotFound();
            }
        }
    }
}