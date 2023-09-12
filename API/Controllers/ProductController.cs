using API.Services;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
		public ActionResult Index()
		{
			var productdata = from product in _productService.GetProduct()
							   select product;
			return Ok(productdata);
		}



		[HttpPost("create")]
		public IActionResult Create(ProdutoModel product)
		{
			_productService.AddProduct(new ProdutoModel()
			{
				ProductName = product.ProductName


			});
			return Ok();
		}

	}



    }


