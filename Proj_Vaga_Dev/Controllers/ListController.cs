using Microsoft.AspNetCore.Mvc;

namespace Proj_Vaga_Dev.Controllers
{
	public class ListController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
