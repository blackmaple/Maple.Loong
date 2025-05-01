using Microsoft.Extensions.Logging;

namespace Maple.Loong.Metadata
{
    public partial class GameCheatEngine(GameReourceCache reourceCache)
    {
        GameReourceCache ReourceCache { get; } = reourceCache;
        GameMetadataContext MetadataContext => ReourceCache.MetadataContext;
        ILogger Logger => MetadataContext.Logger;
 

      







    }

}
