using Maple.Loong.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;
using System.Collections.Immutable;

namespace Maple.Loong.Windows
{
    internal sealed class GameCheatEngineService
        (ILogger<GameCheatEngineService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<GameMetadataContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {
        protected sealed override GameMetadataContext LoadGameContext()
        {



            var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = GameMetadataContext.MonoJsonClassDTO,
                Methods = GameMetadataContext.MonoJsonMethodDTO,
                Fields = GameMetadataContext.MonoJsonFieldDTO,
            });


            return new GameMetadataContext(Logger, searchService, RuntimeContext);



        }

        public required GameReourceCache Cache { get; set; }

        protected override async ValueTask LoadGameDataAsync()
        {
            Cache = await this.MonoTaskAsync(static (p) => new GameReourceCache(p)).ConfigureAwait(false);
            //   await this.MonoTaskAsync(static (p, @this) => @this.LoadGameMetadata(), this).ConfigureAwait(false);

        }

        private void LoadGameMetadata()
        {
            foreach (var klass in EnumSingletonClasses().ToArray())
            {
                var className = RuntimeContext.RuntiemProvider.GetMonoClassName(klass);
                Logger.LogInformation("classname:{name}", className.ToString());

            }
        }
        private IEnumerable<PMonoClass> EnumSingletonClasses()
        {
            foreach (var image in Context.ImageNames)
            {
                if (!image.Utf8Name.AsSpan().StartsWith("Assembly-CSharp"u8))
                {
                    continue;
                }
                foreach (var klass in RuntimeContext.EnumMonoObjects(image.Pointer))
                {
                    var pMonoClass = klass.Pointer;
                    if (HasStaticField(pMonoClass) || HasSingletonClass(pMonoClass))
                    {
                        yield return pMonoClass;
                    }
                }

            }

            bool HasStaticField(PMonoClass pMonoClass)
            {
                foreach (var f in RuntimeContext.EnumMonoFields(pMonoClass, EnumMonoFieldOptions.Static))
                {
                    if (f.FieldType.Pointer == pMonoClass)
                    {
                        return true;
                    }
                }
                return false;
            }

            bool HasSingletonClass(PMonoClass pMonoClass)
            {
                foreach (var parent in RuntimeContext.RuntiemProvider.EnumMonoParentClasses(pMonoClass))
                {
                    var className = RuntimeContext.RuntiemProvider.GetMonoClassName(parent);
                    if (className.AsReadOnlySpan().StartsWith("Singleton"u8))
                    {
                        return true;
                    }
                }
                return false;

            }

        }

        protected override IUnityPlayerNativeMethods? LoadUnityEngineContext()
        {
            throw new NotImplementedException();
        }

        private Task<GameCheatEngine> GetGameCheatEngine()
        {
            return this.MonoTaskAsync((p, cache) => GameCheatEngine.Create(cache), this.Cache);
        }

        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return base.GetListCurrencyDisplayAsync();
        }


        public sealed override ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            return ValueTask.FromResult<GameInventoryDisplayDTO[]>(this.Cache.ALL_ITEM);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameCheatEngine = await this.GetGameCheatEngine().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameCheatEngine.GetGameInventoryInfo(args.inventoryObjectDTO), (gameCheatEngine, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameCheatEngine = await this.GetGameCheatEngine().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.gameCheatEngine.UpdateGameInventoryInfo(args.inventoryObjectDTO), (gameCheatEngine, inventoryObjectDTO)).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCharacterDisplayDTO[]> GetListCharacterDisplayAsync()
        {
            var gameCheatEngine = await this.GetGameCheatEngine().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, cheat) => cheat.GetGameCharacters().ToArray(), gameCheatEngine).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCharacterStatusDTO> GetCharacterStatusAsync(GameCharacterObjectDTO characterObjectDTO)
        {
            var cheat = await this.GetGameCheatEngine().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => args.cheat.GetGameCharacterStatus(args.characterObjectDTO), (cheat, characterObjectDTO)).ConfigureAwait(false);
        }

    }

}
