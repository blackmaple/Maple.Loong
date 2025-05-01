using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;

namespace Maple.Loong.Metadata
{
    public partial class GameReourceCache
    {
        public GameMetadataContext MetadataContext { get; }
        ILogger Logger => MetadataContext.Logger;

       

    }


    public class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public nint ObjectPointer { get; set; }
    }

    public class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public nint ObjectPointer { get; set; }

    }

    public class GameMonsterDisplayDTOEX : GameMonsterDisplayDTO
    {
        public nint ObjectPointer { get; set; }

    }


    public class GameValueInfoDTOEX : GameValueInfoDTO
    {
        public nint ObjectPointer { get; set; }

        //  public DictIndex Index { get; set; }
        public float Min { set; get; }


    }





}
