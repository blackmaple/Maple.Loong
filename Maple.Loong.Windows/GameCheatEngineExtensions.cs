using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Loong.Windows
{
    internal static class GameCheatEngineExtensions
    {

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "龙胤立志传";
                p.QQ = "0";
                p.Http = true;
                p.NamedPipe = true;
                p.AutoOpenUrl = true;

            }, services =>
            {
                services.UseGameContextService<GameCheatEngineService>();
            });

            //延迟启动
            Thread.Sleep(8000);
            webapp.Run();

            return 1;
        }

    }

}
