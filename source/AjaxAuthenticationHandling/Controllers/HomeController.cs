using AjaxAuthenticationHandling.Security;
using System.Web.Mvc;

namespace AjaxAuthenticationHandling.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult GetData1()
		{
			return Json(new
			{
				Items = new[]
				{
					"Li Chen",
					"Abdullah Khamir",
					"Mark Schrenberg",
					"Katy Sullivan",
					"Erico Gantomaro",
				}
			});
		}

		[HttpPost]
		[ApplicationAuthorize]
		public ActionResult GetData2()
		{
			return Json(new
			{
				Items = new[]
				{
					"Li Chen",
					"Abdullah Khamir",
					"Mark Schrenberg",
					"Katy Sullivan",
					"Erico Gantomaro",
				}
			});
		}

		[HttpPost]
		[ApplicationAuthorize(Roles = "admin")]
		public ActionResult GetData3()
		{
			return Json(new
			{
				Items = new[]
				{
					"Li Chen",
					"Abdullah Khamir",
					"Mark Schrenberg",
					"Katy Sullivan",
					"Erico Gantomaro",
				}
			});
		}
	}

}