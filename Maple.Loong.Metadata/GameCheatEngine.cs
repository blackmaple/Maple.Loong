using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.Loong.Metadata
{
    public partial class GameCheatEngine(GameReourceCache reourceCache)
    {
        GameReourceCache ReourceCache { get; } = reourceCache;
        GameMetadataContext MetadataContext => ReourceCache.MetadataContext;
        ILogger Logger => MetadataContext.Logger;

        GameController.Ptr_GameController Ptr_GameController { get; } = GameController.Ptr_GameController.INSTANCE;
        WorldData.Ptr_WorldData Ptr_WorldData => this.Ptr_GameController.WORLD_DATA;
        public bool InGame()
        {
            return this.Ptr_GameController.IsNotNull() && this.Ptr_GameController.M_CACHED_PTR != nint.Zero;
        }

        public IEnumerable<GameCharacterDisplayDTO> GetGameCharacters()
        {
            var worldData = this.Ptr_WorldData;
            var player = worldData.PLAYER();
            var playerId = player.HERO_ID;
            foreach (var character in worldData.HEROS.AsEnumerable())
            {
                var id = character.HERO_ID;
                yield return new GameCharacterDisplayDTO()
                {
                    ObjectId = id.ToString(),
                    DisplayName = character.HERO_NICK_NAME.ToString(),
                    DisplayCategory = playerId == id ? nameof(EnumHeroType.Player) :nameof(EnumHeroType.Hero),
                    DisplayDesc = string.Empty,
                };
            }
        }





    }

    public enum EnumHeroType
    { 
        Player,
        Hero
    }
}
