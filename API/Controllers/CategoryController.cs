
using API.Services;
using Common;
using LinqToDB;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Context;
using Repository.Entity;
using System.Drawing.Design;

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

        [HttpGet("FindId")]
        public IActionResult Getvalue(int id)
        {
            return Ok(_categoryService.GetCategory().FirstOrDefault(p => p.ID == id));
       // value: _categoryService.GetCategory().FirstOrDefault(p => p.ID == id).CategoryName.ToString()); ; ; ;

        }

        [HttpGet("Create")]
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