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
    public class ProductPagePartialController
    : PartialContentController<ProductPage>
    {
        public override ActionResult Index(ProductPage currentPage)
    {
        var viewmodel = new DefaultPageViewModel<ProductPage>(currentPage);
        return PartialView(viewmodel);
    }
}
}