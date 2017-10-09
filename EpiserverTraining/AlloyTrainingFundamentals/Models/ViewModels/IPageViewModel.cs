using AlloyTrainingFundamentals.Models.Pages;
using EPiServer.Core;

namespace AlloyTrainingFundamentals.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        IContent Section { get; }
    }
}