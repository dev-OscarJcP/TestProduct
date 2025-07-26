using BackEndTestProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndTestProduct.Controllers
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(id);
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateProductModel createProduct)
        {
            if (createProduct.ExpirationDate < DateTime.Now)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { id = createProduct.Id }, createProduct);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CreateProductModel updateProduct)
        {
            if (updateProduct.ExpirationDate < DateTime.Now)
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
