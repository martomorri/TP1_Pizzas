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

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {

        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {

        }
    }
}