using System.Web.Mvc;
using AlloyTrainingFundamentals.Models.Pages;
using AlloyTrainingFundamentals.Models.ViewModels;

namespace AlloyTrainingFundamentals.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var viewmodel = new DefaultPageViewModel<StartPage>(currentPage);
            return View(viewmodel);
        }
    }
}