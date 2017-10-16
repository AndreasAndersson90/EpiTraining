using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using AlloyTrainingFundamentals;
using AlloyTrainingFundamentals.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Standard",
        GroupName = SiteGroupNames.Common,
        Description = "Use this page type unless you need a more specialized one.")]
    [SitePageIcon]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }
        
        [CultureSpecific]
        [Display(Name = "Main content area",
            Description = "Drag and drop images, blocks, and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData), typeof(ImageData))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}