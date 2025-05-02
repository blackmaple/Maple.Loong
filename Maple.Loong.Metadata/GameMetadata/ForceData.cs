using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ForceData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ForceData>, Ptr_ForceData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ForceData", "ForceData")]
    public partial class ForceData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ForceData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ForceData(System.IntPtr ptr) => new Ptr_ForceData(ptr);
            public static implicit operator System.IntPtr(Ptr_ForceData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ForceData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ForceData"]
        /// </summary>
        partial struct Ptr_ForceData
        {
            /// <summary>
            /// 0x10 System.Int32 forceID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceID", "System.Int32")]
            public partial System.Int32 FORCE_ID { get; set; }


            /// <summary>
            /// 0x18 System.String forceName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceName", "System.String")]
            public partial PMonoString FORCE_NAME { get; set; }


            /// <summary>
            /// 0x20 System.Int32 defaultSkinID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defaultSkinID", "System.Int32")]
           public partial System.Int32 DEFAULT_SKIN_ID { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Boolean bigForce
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bigForce", "System.Boolean")]
           public partial System.Boolean BIG_FORCE { get; set; } 
*/

            /// <summary>
            /// 0x25 System.Boolean autoAddMember
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("autoAddMember", "System.Boolean")]
           public partial System.Boolean AUTO_ADD_MEMBER { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String forceStyle
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceStyle", "System.String")]
           public partial nint FORCE_STYLE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single forceMaleRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceMaleRate", "System.Single")]
           public partial System.Single FORCE_MALE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 forceLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceLv", "System.Int32")]
           public partial System.Int32 FORCE_LV { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 mainAreaID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mainAreaID", "System.Int32")]
           public partial System.Int32 MAIN_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 masterForce
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("masterForce", "System.Int32")]
           public partial System.Int32 MASTER_FORCE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<System.Int32> servantForce
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("servantForce", "System.Collections.Generic.List<System.Int32>")]
           public partial nint SERVANT_FORCE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<System.Int32> startSkillBookID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("startSkillBookID", "System.Collections.Generic.List<System.Int32>")]
           public partial nint START_SKILL_BOOK_ID { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String color
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("color", "System.String")]
           public partial nint COLOR { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 leader
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("leader", "System.Int32")]
           public partial System.Int32 LEADER { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<System.Int32> ownAreasID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ownAreasID", "System.Collections.Generic.List<System.Int32>")]
           public partial nint OWN_AREAS_ID { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<System.Int32> ownResourcePointsID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ownResourcePointsID", "System.Collections.Generic.List<System.Int32>")]
           public partial nint OWN_RESOURCE_POINTS_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.List<System.Int32> ownHeros
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ownHeros", "System.Collections.Generic.List<System.Int32>")]
           public partial nint OWN_HEROS { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<System.Int32> heroLvNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroLvNum", "System.Collections.Generic.List<System.Int32>")]
           public partial nint HERO_LV_NUM { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 totalSalary
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalSalary", "System.Int32")]
           public partial System.Int32 TOTAL_SALARY { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 totalPopulation
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalPopulation", "System.Int32")]
           public partial System.Int32 TOTAL_POPULATION { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.List<System.Single> resourceStore
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourceStore", "System.Collections.Generic.List<System.Single>")]
           public partial nint RESOURCE_STORE { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.List<System.Single> resourceStoreMax
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourceStoreMax", "System.Collections.Generic.List<System.Single>")]
           public partial nint RESOURCE_STORE_MAX { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.List<System.Single> resourceChange
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourceChange", "System.Collections.Generic.List<System.Single>")]
           public partial nint RESOURCE_CHANGE { get; set; } 
*/

            /// <summary>
            /// 0xA0 ItemListData forceStorage
            /// class ["Assembly-CSharp.dll".""."ItemListData"]
            /// </summary>
            /// <returns>class ItemListData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceStorage", "ItemListData")]
           public partial nint FORCE_STORAGE { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Single forceStorageSelfDiscount
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceStorageSelfDiscount", "System.Single")]
           public partial System.Single FORCE_STORAGE_SELF_DISCOUNT { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Single forceStorageOtherDiscount
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceStorageOtherDiscount", "System.Single")]
           public partial System.Single FORCE_STORAGE_OTHER_DISCOUNT { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.List<BookWriterData> bookWriterList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BookWriterData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookWriterList", "System.Collections.Generic.List<BookWriterData>")]
           public partial nint BOOK_WRITER_LIST { get; set; } 
*/

            /// <summary>
            /// 0xB8 ItemListData bookStorage
            /// class ["Assembly-CSharp.dll".""."ItemListData"]
            /// </summary>
            /// <returns>class ItemListData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookStorage", "ItemListData")]
           public partial nint BOOK_STORAGE { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Boolean bookStorageDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookStorageDirty", "System.Boolean")]
           public partial System.Boolean BOOK_STORAGE_DIRTY { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.Dictionary<System.Int32 , System.Int32> bookStorageMaxRareLv
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookStorageMaxRareLv", "System.Collections.Generic.Dictionary<System.Int32,System.Int32>")]
           public partial nint BOOK_STORAGE_MAX_RARE_LV { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.List<System.Single> forceFavor
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceFavor", "System.Collections.Generic.List<System.Single>")]
           public partial nint FORCE_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<System.Int32> kungfuSkillFocus
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kungfuSkillFocus", "System.Collections.Generic.List<System.Int32>")]
           public partial nint KUNGFU_SKILL_FOCUS { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Collections.Generic.List<System.Int32> livingSkillFocus
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("livingSkillFocus", "System.Collections.Generic.List<System.Int32>")]
           public partial nint LIVING_SKILL_FOCUS { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Collections.Generic.List<System.Single> itemFocus
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemFocus", "System.Collections.Generic.List<System.Single>")]
           public partial nint ITEM_FOCUS { get; set; } 
*/

            /// <summary>
            /// 0xF0 ForceFocusType forceFocus
            /// enum ["Assembly-CSharp.dll".""."ForceFocusType"]
            /// </summary>
            /// <returns>enum ForceFocusType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceFocus", "ForceFocusType")]
           public partial ForceFocusType FORCE_FOCUS { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Boolean forceDetailDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceDetailDirty", "System.Boolean")]
           public partial System.Boolean FORCE_DETAIL_DIRTY { get; set; } 
*/

            /// <summary>
            /// 0xF5 System.Boolean forceHeroDetailDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceHeroDetailDirty", "System.Boolean")]
           public partial System.Boolean FORCE_HERO_DETAIL_DIRTY { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Collections.Generic.List<ForceFavorSettingData> forceFavorSetting
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceFavorSettingData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceFavorSetting", "System.Collections.Generic.List<ForceFavorSettingData>")]
           public partial nint FORCE_FAVOR_SETTING { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32 thisMonthAttackResourcePoint
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthAttackResourcePoint", "System.Int32")]
           public partial System.Int32 THIS_MONTH_ATTACK_RESOURCE_POINT { get; set; } 
*/

            /// <summary>
            /// 0x104 System.Int32 thisMonthGetResource
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthGetResource", "System.Int32")]
           public partial System.Int32 THIS_MONTH_GET_RESOURCE { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 thisMonthAddOtherForceFavor
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthAddOtherForceFavor", "System.Int32")]
           public partial System.Int32 THIS_MONTH_ADD_OTHER_FORCE_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 thisMonthReduceOtherForceFavor
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthReduceOtherForceFavor", "System.Int32")]
           public partial System.Int32 THIS_MONTH_REDUCE_OTHER_FORCE_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Int32 randomAttackAreaDay
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("randomAttackAreaDay", "System.Int32")]
           public partial System.Int32 RANDOM_ATTACK_AREA_DAY { get; set; } 
*/

            /// <summary>
            /// 0x114 System.Int32 nowResearchTech
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nowResearchTech", "System.Int32")]
           public partial System.Int32 NOW_RESEARCH_TECH { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Collections.Generic.List<ForceTechLvData> techLvData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceTechLvData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("techLvData", "System.Collections.Generic.List<ForceTechLvData>")]
           public partial nint TECH_LV_DATA { get; set; } 
*/

            /// <summary>
            /// 0x120 ForceSpeAddData techSpeAddData
            /// class ["Assembly-CSharp.dll".""."ForceSpeAddData"]
            /// </summary>
            /// <returns>class ForceSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("techSpeAddData", "ForceSpeAddData")]
           public partial nint TECH_SPE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x128 ForceSpeAddData forceSpeAddData
            /// class ["Assembly-CSharp.dll".""."ForceSpeAddData"]
            /// </summary>
            /// <returns>class ForceSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceSpeAddData", "ForceSpeAddData")]
           public partial nint FORCE_SPE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<System.Collections.Generic.List<ItemData>> showRoomItems
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<ItemData>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("showRoomItems", "System.Collections.Generic.List<System.Collections.Generic.List<ItemData>>")]
           public partial nint SHOW_ROOM_ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Single showRoomChangeFame
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("showRoomChangeFame", "System.Single")]
           public partial System.Single SHOW_ROOM_CHANGE_FAME { get; set; } 
*/

            /// <summary>
            /// 0x140 ForceJobSettingData forceJobSettingData
            /// class ["Assembly-CSharp.dll".""."ForceJobSettingData"]
            /// </summary>
            /// <returns>class ForceJobSettingData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceJobSettingData", "ForceJobSettingData")]
           public partial nint FORCE_JOB_SETTING_DATA { get; set; } 
*/

            /// <summary>
            /// 0x148 ForceInteractionTimeData forceInteractionTimeData
            /// class ["Assembly-CSharp.dll".""."ForceInteractionTimeData"]
            /// </summary>
            /// <returns>class ForceInteractionTimeData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceInteractionTimeData", "ForceInteractionTimeData")]
           public partial nint FORCE_INTERACTION_TIME_DATA { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Boolean thisMonthAttack
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthAttack", "System.Boolean")]
           public partial System.Boolean THIS_MONTH_ATTACK { get; set; } 
*/

            /// <summary>
            /// 0x154 System.Int32 thisMonthManaged
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthManaged", "System.Int32")]
           public partial System.Int32 THIS_MONTH_MANAGED { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Single playerOutForceContribution
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerOutForceContribution", "System.Single")]
           public partial System.Single PLAYER_OUT_FORCE_CONTRIBUTION { get; set; } 
*/

            /// <summary>
            /// 0x15C System.Int32 speBuildingID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speBuildingID", "System.Int32")]
           public partial System.Int32 SPE_BUILDING_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ForceData"]
        /// </summary>
        partial struct Ptr_ForceData
        {
            /// <summary>
            /// static  System.String GetChangeResourceSound(System.Int32 id, System.Single num)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChangeResourceSound", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           public static partial nint GET_CHANGE_RESOURCE_SOUND(System.Int32 id, System.Single num); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void AddHero(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
           public partial void ADD_HERO(nint targetHero); 
*/
            /// <summary>
            ///   System.Void AddHero(HeroData targetHero, System.Int32 _forceLv, System.Int32 _generation)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <param name = "_forceLv">struct System.Int32</param>
            /// <param name = "_generation">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial void ADD_HERO(nint targetHero, System.Int32 _forceLv, System.Int32 _generation); 
*/
            /// <summary>
            ///   System.Boolean AreaNotFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AreaNotFull", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean AREA_NOT_FULL(); 
*/
            /// <summary>
            ///   System.Void BookStorageAddBook(ItemData book, System.Boolean showInfo)
            /// </summary>
            /// <param name = "book">class ItemData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BookStorageAddBook", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void BOOK_STORAGE_ADD_BOOK(nint book, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeForceFavor(System.Int32 id, System.Single favor, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "favor">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeForceFavor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public partial void CHANGE_FORCE_FAVOR(System.Int32 id, System.Single favor, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeResource(System.Collections.Generic.List<System.Single> resourceList, System.Boolean showInfo, System.Boolean showHud)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "showHud">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public partial void CHANGE_RESOURCE(nint resourceList, System.Boolean showInfo, System.Boolean showHud); 
*/
            /// <summary>
            ///   System.Void ChangeResource(System.Collections.Generic.List<ResourceData> resourceList, System.Boolean showInfo, System.Boolean showHud)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<ResourceData></param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "showHud">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public partial void CHANGE_RESOURCE(nint resourceList, System.Boolean showInfo, System.Boolean showHud); 
*/
            /// <summary>
            ///   System.Void ChangeResource(System.Int32 id, System.Single num, System.Boolean showInfo, System.Boolean showHud)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "showHud">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           public partial void CHANGE_RESOURCE(System.Int32 id, System.Single num, System.Boolean showInfo, System.Boolean showHud); 
*/
            /// <summary>
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint CLONE(); 
*/
            /// <summary>
            ///   System.Void CostResource(System.Collections.Generic.List<System.Single> resourceList, System.Boolean showInfo)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void COST_RESOURCE(nint resourceList, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void CostResource(System.Collections.Generic.List<ResourceData> resourceList, System.Boolean showInfo)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<ResourceData></param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void COST_RESOURCE(nint resourceList, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void CostResource(ResourceData resource, System.Boolean showInfo)
            /// </summary>
            /// <param name = "resource">class ResourceData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourceData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void COST_RESOURCE(nint resource, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void CostResource(System.Int32 id, System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           public partial void COST_RESOURCE(System.Int32 id, System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<HeroData> FindAllHero(System.Int32 minForceLv, System.Int32 maxForceLv, System.Boolean noLeader, System.Boolean noJob, System.Boolean noPlayer, System.Boolean noPrison)
            /// </summary>
            /// <param name = "minForceLv">struct System.Int32</param>
            /// <param name = "maxForceLv">struct System.Int32</param>
            /// <param name = "noLeader">struct System.Boolean</param>
            /// <param name = "noJob">struct System.Boolean</param>
            /// <param name = "noPlayer">struct System.Boolean</param>
            /// <param name = "noPrison">struct System.Boolean</param>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAllHero", "System.Collections.Generic.List<HeroData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 5)]
           public partial nint FIND_ALL_HERO(System.Int32 minForceLv, System.Int32 maxForceLv, System.Boolean noLeader, System.Boolean noJob, System.Boolean noPlayer, System.Boolean noPrison); 
*/
            /// <summary>
            ///   System.Void ForceConquerArea(AreaData targetArea, System.Boolean showInfo)
            /// </summary>
            /// <param name = "targetArea">class AreaData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForceConquerArea", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("AreaData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void FORCE_CONQUER_AREA(nint targetArea, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ForceConquerResourcePoint(AreaData targetArea, System.Boolean showInfo)
            /// </summary>
            /// <param name = "targetArea">class AreaData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForceConquerResourcePoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("AreaData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void FORCE_CONQUER_RESOURCE_POINT(nint targetArea, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ForceConquerResourcePoint(ResourcePointData targetResourcePoint, System.Boolean showInfo)
            /// </summary>
            /// <param name = "targetResourcePoint">class ResourcePointData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForceConquerResourcePoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourcePointData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void FORCE_CONQUER_RESOURCE_POINT(nint targetResourcePoint, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Single GetChangeAllAreaState(AreaStateType areaStateType)
            /// </summary>
            /// <param name = "areaStateType">enum AreaStateType</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChangeAllAreaState", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("AreaStateType", 0)]
           public partial System.Single GET_CHANGE_ALL_AREA_STATE(AreaStateType areaStateType); 
*/
            /// <summary>
            ///   System.Single GetForceFavor(System.Int32 forceID)
            /// </summary>
            /// <param name = "forceID">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceFavor", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Single GET_FORCE_FAVOR(System.Int32 forceID); 
*/
            /// <summary>
            ///   System.Int32 GetForceJobExtraAttriNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceJobExtraAttriNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_FORCE_JOB_EXTRA_ATTRI_NUM(); 
*/
            /// <summary>
            ///   System.Single GetForceJobExtraExpRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceJobExtraExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_FORCE_JOB_EXTRA_EXP_RATE(); 
*/
            /// <summary>
            ///   System.String GetForceName()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_FORCE_NAME();

            /// <summary>
            ///   HeroData GetLeader()
            /// </summary>
            /// <returns>class HeroData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLeader", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_LEADER(); 
*/
            /// <summary>
            ///   System.Single GetMaxAreaNum()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxAreaNum", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_MAX_AREA_NUM(); 
*/
            /// <summary>
            ///   System.Single GetMaxHeroNum()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxHeroNum", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_MAX_HERO_NUM(); 
*/
            /// <summary>
            ///   ForceTechLvData GetNowResearchTech()
            /// </summary>
            /// <returns>class ForceTechLvData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNowResearchTech", "ForceTechLvData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_NOW_RESEARCH_TECH(); 
*/
            /// <summary>
            ///   HeroData GetOwnHero(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class HeroData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOwnHero", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_OWN_HERO(System.Int32 id); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<HeroData> GetOwnHeros()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOwnHeros", "System.Collections.Generic.List<HeroData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_OWN_HEROS(); 
*/
            /// <summary>
            ///   System.Boolean HaveResource(ResourceData resource)
            /// </summary>
            /// <param name = "resource">class ResourceData</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourceData", 0)]
           public partial System.Boolean HAVE_RESOURCE(nint resource); 
*/
            /// <summary>
            ///   System.Boolean HaveResource(System.Collections.Generic.List<System.Single> resourceList)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<System.Single></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
           public partial System.Boolean HAVE_RESOURCE(nint resourceList); 
*/
            /// <summary>
            ///   System.Boolean HaveResource(System.Collections.Generic.List<ResourceData> resourceList)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<ResourceData></param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
           public partial System.Boolean HAVE_RESOURCE(nint resourceList); 
*/
            /// <summary>
            ///   System.Boolean HaveResource(System.Int32 id, System.Single num)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           public partial System.Boolean HAVE_RESOURCE(System.Int32 id, System.Single num); 
*/
            /// <summary>
            ///   AreaData MainArea()
            /// </summary>
            /// <returns>class AreaData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MainArea", "AreaData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint MAIN_AREA(); 
*/
            /// <summary>
            ///   System.Boolean PopulationNotFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PopulationNotFull", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean POPULATION_NOT_FULL(); 
*/
            /// <summary>
            ///   System.Void RemoveHero(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
           public partial void REMOVE_HERO(nint targetHero); 
*/
            /// <summary>
            ///   System.Void SetForceFavor(ForceFavorSettingData setting)
            /// </summary>
            /// <param name = "setting">class ForceFavorSettingData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetForceFavor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ForceFavorSettingData", 0)]
           public partial void SET_FORCE_FAVOR(nint setting); 
*/
            /// <summary>
            ///   System.Void SetForceFavor(System.Int32 id, System.Single favor)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "favor">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetForceFavor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           public partial void SET_FORCE_FAVOR(System.Int32 id, System.Single favor); 
*/
            /// <summary>
            ///   System.Void SetForceJob(System.Int32 jobType, System.Int32 jobID, HeroData targetHero)
            /// </summary>
            /// <param name = "jobType">struct System.Int32</param>
            /// <param name = "jobID">struct System.Int32</param>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetForceJob", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 2)]
           public partial void SET_FORCE_JOB(System.Int32 jobType, System.Int32 jobID, nint targetHero); 
*/
            /// <summary>
            ///   System.Void SetLeader(HeroData targetHero, System.Boolean showInfo)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetLeader", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void SET_LEADER(nint targetHero, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void SetNowResearch(ForceTechLvData targetTech, System.Boolean showInfo)
            /// </summary>
            /// <param name = "targetTech">class ForceTechLvData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetNowResearch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ForceTechLvData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
           public partial void SET_NOW_RESEARCH(nint targetTech, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void UpgradeNowResearch(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpgradeNowResearch", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial void UPGRADE_NOW_RESEARCH(System.Boolean showInfo); 
*/
        }
    }
}