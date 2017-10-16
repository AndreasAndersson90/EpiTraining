using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AlloyTrainingFundamentals.Models.Pages;
using AlloyTrainingFundamentals.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTrainingFundamentals.Controllers
{
    public class ProductPageController : PageControllerBase<ProductPage>
    {
        public ActionResult Index(ProductPage currentPage)
        {
            var vm = new DefaultPageViewModel<ProductPage>(currentPage);

            return View(vm);
        }
    }
}