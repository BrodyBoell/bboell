using Microsoft.AspNetCore.Mvc;
using ResponsiveWebApp.Models;
using System.Diagnostics;

namespace ResponsiveWebApp.Controllers
{
	public class HomeController : Controller
	{


		[HttpGet]
		public IActionResult Index()
		{
			//Setting default values

			ViewBag.currentAge = 0;
			ViewBag.print = "";
			return View();
		}
		[HttpPost]
		public IActionResult Index(AgeThisYear model)
		{
			if (ModelState.IsValid)
			{
				//Showing the data from methods

				ViewBag.currentAge = model.ageThisYear();
				ViewBag.print = model.Output();
			}
			else
			{
				ViewBag.currentAge = 0;
			}
			return View(model);
		}
	}
}