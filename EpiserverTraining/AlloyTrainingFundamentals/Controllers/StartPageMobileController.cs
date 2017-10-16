using System.Web.Mvc;
using AlloyTrainingFundamentals.Models.Pages;
using AlloyTrainingFundamentals.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;

namespace AlloyTrainingFundamentals.Controllers
{
    [TemplateDescriptor(Tags = new[] { RenderingTags.Mobile }, AvailableWithoutTag = false)]
    public class StartPageMobileController : PageControllerBase<StartPage>
    {   
       public ActionResult Index(StartPage currentPage)
        {
            var viewmodel = new DefaultPageViewModel<StartPage>(currentPage);
            return View(viewmodel);
        }
    }
}