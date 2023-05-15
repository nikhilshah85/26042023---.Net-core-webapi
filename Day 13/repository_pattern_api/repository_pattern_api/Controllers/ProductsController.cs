using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repository_pattern_api.Repository;
using repository_pattern_api.Model;
namespace repository_pattern_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //all the operations wil happen with the IProduct Interface

        IProduct _iproduct; //DI


        public ProductsController(IProduct product)
        {
            _iproduct = product;
        }

        [HttpGet]
        [Route("plist")]
        public IActionResult GetAllProduct()
        {
            return Ok(_iproduct.GetProducts());
        }


        [HttpGet]
        [Route("plist/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_iproduct.GetProductById(id));
        }

        [HttpPost]
        [Route("plist/add")]
        public IActionResult AddProduct(Products pObj)
        {
           var result =  _iproduct.AddProduct(pObj);
            return Created("", result);
        }


    }
}















