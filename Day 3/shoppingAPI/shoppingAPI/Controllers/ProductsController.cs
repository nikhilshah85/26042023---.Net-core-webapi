using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shoppingAPI.Models;
namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        Products pObj = new Products(); //this is a very bad code, we shold use DI instead

        [HttpGet]
        [Route("productlist")]
        public IActionResult GetAllProducts()
        {
            return Ok(pObj.GetAllProducts());
        }

        [HttpGet]
        [Route("productlist/searchbyid/{id}")]
        public IActionResult GetProduct(int id) 
        {
            try
            {
                return Ok(pObj.GetproductById(id));
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }            
        }
        [HttpGet]
        [Route("productlist/searchbycategory/{category}")]
        public IActionResult GetProductByCategory(string category)
        {
            return Ok(pObj.GetProductsByCategory(category));
        }

        [HttpPost]
        [Route("productlist/add")]
        public IActionResult AddnewProduct([FromBody]Products newProduct)
        {
            try
            {
                string result = pObj.AddNewProduct(newProduct);
                return Created("",result);
            }
            catch (Exception es)
            {

                return Ok(es.Message);
            }
        }

        [HttpPut]
        [Route("productlist/edit")]
        public IActionResult EditeProduct([FromBody] Products productToEdit)
        {
            try
            {
                string result = pObj.EditProduct(productToEdit);
                return Accepted(result);
            }
            catch (Exception es)
            {
                return Ok(es.Message);
                
            }
        }

        [HttpDelete]
        [Route("productlist/delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                string result = pObj.DeleteProduct(id);
                return Accepted(result);
            }
            catch (Exception es)
            {
                return Ok(es.Message);                
            }
        }
    }
}








