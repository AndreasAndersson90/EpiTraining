using System.Web.Mvc;
using AlloyTrainingFundamentals.Models.Pages;
using AlloyTrainingFundamentals.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTrainingFundamentals.Controllers
{
    [TemplateDescriptor(Inherited = true, Tags = new[] {SiteTags.Full}, AvailableWithoutTag = true)]
    public class AllPagesFullPartialController
        : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            var viewmodel = new DefaultPageViewModel<SitePageData>(currentPage);
            return PartialView(SiteTags.Full, viewmodel);
        }
    }


    [TemplateDescriptor(Inherited = true, Tags = new[] {SiteTags.Wide}, AvailableWithoutTag = false)]
    public class AllPagesWidePartialController
        : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            var viewmodel = new DefaultPageViewModel<SitePageData>(currentPage);
            return PartialView(SiteTags.Wide, viewmodel);
        }
    }

    [TemplateDescriptor(Inherited = true, Tags = new[] { SiteTags.Narrow }, AvailableWithoutTag = false)]
    public class AllPagesNarrowPartialController
        : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            var viewmodel = new DefaultPageViewModel<SitePageData>(currentPage);
            return PartialView(SiteTags.Narrow, viewmodel);
        }
    }
}