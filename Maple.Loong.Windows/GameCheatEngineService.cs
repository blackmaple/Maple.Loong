using Maple.Loong.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
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
            //     Cache = await this.MonoTaskAsync(static (p) => new GameReourceCache(p)).ConfigureAwait(false);
            await this.MonoTaskAsync(static (p, @this) => @this.LoadGameMetadata(), this).ConfigureAwait(false);

        }

        private void LoadGameMetadata()
        {
            foreach (var klass in EnumSingletonClasses().ToArray())
            {
                var className = RuntimeContext.RuntiemProvider.GetMonoClassName(klass);
                Logger.LogInformation("classname:{name}", className.ToString());

            }
        }
        private IEnumerable<PMonoClass> EnumSingletonClasses( )
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





    }

}
