
using API.Services;
using Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Context;



namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
	

		private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

		[EnableCors("mypolicy")]
		[HttpGet]

        public IActionResult GetListCategory()
                           => Ok(_categoryService.GetCategory());

		

		[HttpPost("create")]
        public IActionResult Create(CategoriaModel category)
        {
            _categoryService.AddCategory(new CategoriaModel()
            {
                CategoryName = category.CategoryName
            });
            return Ok();
        }

        [HttpPatch("update")]
        public IActionResult Update(CategoriaModel category)
        {
            _categoryService.UpdateCategory(category);

            return Ok();

        }



    }
}