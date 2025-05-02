using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.Loong.Metadata
{




    [ContextParentMetadata<ContextMetadataCollector>(true)]


    [ContextMemberMetadata<GameDataController>]

    [ContextMemberMetadata<ItemData>]
    [ContextMemberMetadata<EquipmentData>]
    [ContextMemberMetadata<MedFoodData>]
    [ContextMemberMetadata<BookData>]
    [ContextMemberMetadata<TreasureData>]
    [ContextMemberMetadata<MaterialData>]
    [ContextMemberMetadata<HorseData>]


    [ContextMemberMetadata<HeroData>]
    [ContextMemberMetadata<KungfuSkillData>]
    [ContextMemberMetadata<HeroTagDataBase>]

    [ContextMemberMetadata<SkinDataBase>]
    [ContextMemberMetadata<ForceData>]

    public partial class GameMetadataContext
    {


    }
}
