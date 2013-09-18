using System.Web.Mvc;
using System.Web.Security;

namespace AjaxAuthenticationHandling.Controllers
{
	public class AccountController : Controller
	{
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(string login, string password)
		{
			if ((login == "admin") && (password == "123"))
			{
				FormsAuthentication.SetAuthCookie(login, true);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ModelState.AddModelError("IncorrectUser", "Please, use correct login and password.");
				return View();
			}
		}

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Login");
		}
	}
}