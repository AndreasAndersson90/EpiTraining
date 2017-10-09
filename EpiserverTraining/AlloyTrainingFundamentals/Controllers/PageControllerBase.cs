using System.Web.Mvc;
using System.Web.Security;
using AlloyTrainingFundamentals.Models.Pages;
using EPiServer.Web.Mvc;

namespace AlloyTrainingFundamentals.Controllers
{
    public abstract class PageControllerBase<T>
        : PageController<T> where T : SitePageData
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}