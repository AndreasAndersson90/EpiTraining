using EPiServer.Core;

namespace EpiserverTraining.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
