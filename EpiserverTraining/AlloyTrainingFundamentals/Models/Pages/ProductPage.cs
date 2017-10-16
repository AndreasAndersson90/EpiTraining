using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTrainingFundamentals.Models.Pages
{
    [ContentType(
        DisplayName = "Product", 
        GUID = "503f2015-fe27-4c4f-a1bf-3b2d1d3fd5d6", 
        Description = "Use this for software products that Alloy sells.",
        GroupName = SiteGroupNames.Specialized)]
    [SiteCommerceIcon]
    public class ProductPage : StartPage
    {   
        [Required]
        [CultureSpecific]
        [Display(Name = "Unique selling points",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }

        [Display(Name = "Main content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(Name = "Related content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}