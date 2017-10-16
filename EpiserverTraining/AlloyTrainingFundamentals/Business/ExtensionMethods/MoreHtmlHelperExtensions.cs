using EPiServer.Core;
using EPiServer.ServiceLocation;
using System.Collections.Generic;
using System.Web.Mvc;
using EPiServer;

namespace AlloyTrainingFundamentals.Business.ExtensionMethods
{
        public static class MoreHtmlHelperExtensions
        {
            public static IEnumerable<PageData> GetStartPageChildren(
                this HtmlHelper html)
            {
                // Get the registered service that implements IContentLoader.
                var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
                // Get the child pages of the page.
                return loader.GetChildren<PageData>(ContentReference.StartPage);
            }
        }
}