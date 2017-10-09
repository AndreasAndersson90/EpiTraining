using AlloyTrainingFundamentals.Models.Pages;
using AlloyTrainingFundamentals.Business.ExtensionMethods;
using EPiServer.Core;

namespace AlloyTrainingFundamentals.Models.ViewModels
{
    public class DefaultPageViewModel<T>
        : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = currentPage.ContentLink.GetSection();
        }

        public T CurrentPage { get; set; }
        public IContent Section { get; set; }
    }
}