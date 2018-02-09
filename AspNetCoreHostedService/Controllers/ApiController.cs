namespace AspNetCoreHostedService.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System;

	[Route("[controller]/[action]")]
	public class ApiController : Controller
	{
		[HttpGet]
		public JsonResult Status()
		{
			return Json(new { status = true, message = "Background service started.", date = DateTime.Now });
		}
	}
}