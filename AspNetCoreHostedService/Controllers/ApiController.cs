namespace AspNetCoreHostedService.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System;

	[Route("[controller]/[action]")]
	public class ApiController : Controller
	{
		[HttpGet]
		public IActionResult Status()
		{
			return Ok(new { status = true, message = "Background service started.", date = DateTime.Now });
		}
	}
}