using System.ComponentModel.DataAnnotations;
using AlloyTraining;
using AlloyTraining.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTrainingFundamentals.Models.Pages
{
    [ContentType(DisplayName = "Start",
        GroupName = SiteGroupNames.Specialized,
        Description = "The home page for a website with an area for blocks and partial pages.")]
    [SiteStartIcon]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer text",
            GroupName = SiteTabNames.SiteSettings, Order = 100)]
        public virtual string FooterText { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
            Description = "Drag and drop images, blocks, and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData), typeof(ProductPage))]
        public virtual ContentArea MainContentArea { get; set; }

    }
}