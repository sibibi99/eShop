using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        public ProductController(IPublicProductService publicProductService)
        {
            _publicProductService = publicProductService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _publicProductService.GetAll();
            return Ok(data);
        }

       
    }
}
