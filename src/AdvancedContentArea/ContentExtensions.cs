using EPiServer;
using EPiServer.Core;

namespace EPiBootstrapArea
{
    public static class ContentExtensions
    {
        public static string GetContentBookmarkName(this IContent content)
        {
            return content.GetOriginalType().Name.ToLowerInvariant()
                   + "_"
                   + content.ContentLink;
        }
    }
}
