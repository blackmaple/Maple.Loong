using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."GameDataController"]
    /// [UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GameDataController>, Ptr_GameDataController>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "GameDataController", "GameDataController")]
    public partial class GameDataController
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GameDataController(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GameDataController(System.IntPtr ptr) => new Ptr_GameDataController(ptr);
            public static implicit operator System.IntPtr(Ptr_GameDataController ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_GameDataController ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GameDataController"]
        /// </summary>
        partial struct Ptr_GameDataController
        {
            /// <summary>
            /// 0x0 System.String playerprefDataFileName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint PLAYERPREF_DATA_FILE_NAME = PlayerprefData.dat; 
*/
            /// <summary>
            /// 0x0 System.String objectIsNullMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint OBJECT_IS_NULL_MESSAGE = The Object you want to instantiate is null.; 
*/
            /// <summary>
            /// 0x0 System.String cloneDestroyedMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           public const nint CLONE_DESTROYED_MESSAGE = Instantiate failed because the clone was destroyed during creati; 
*/
            /// <summary>
            /// 0x0 System.Collections.Generic.List<System.String> saveDataFileName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("saveDataFileName", "System.Collections.Generic.List<System.String>")]
           public static partial nint SAVE_DATA_FILE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OffsetOfInstanceIDInCPlusPlusObject", "System.Int32")]
           public static partial System.Int32 OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT { get; set; } 
*/

            /// <summary>
            /// 0x8 RePlayerPrefData playerPrefData
            /// class ["Assembly-CSharp.dll".""."RePlayerPrefData"]
            /// </summary>
            /// <returns>class RePlayerPrefData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerPrefData", "RePlayerPrefData")]
           public static partial nint PLAYER_PREF_DATA { get; set; } 
*/

            /// <summary>
            /// 0x10 GameDataController _instance
            /// class ["Assembly-CSharp.dll".""."GameDataController"]
            /// </summary>
            /// <returns>class GameDataController</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_instance", "GameDataController")]
            public static partial GameDataController.Ptr_GameDataController INSTANCE { get; set; }


            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.String> CheckVersionHideSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CheckVersionHideSkill", "System.Collections.Generic.List<System.String>")]
           public static partial nint CHECK_VERSION_HIDE_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x10 System.IntPtr m_CachedPtr
            /// struct ["mscorlib.dll"."System"."IntPtr"]
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CachedPtr", "System.IntPtr")]
           public partial System.IntPtr M_CACHED_PTR { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.Threading.Tasks.Task> Tasks
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Threading.Tasks.Task></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Tasks", "System.Collections.Generic.List<System.Threading.Tasks.Task>")]
           public partial nint TASKS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String saveDataPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("saveDataPath", "System.String")]
           public partial nint SAVE_DATA_PATH { get; set; } 
*/

            /// <summary>
            /// 0x28 GameSaveData gameSaveData
            /// class ["Assembly-CSharp.dll".""."GameSaveData"]
            /// </summary>
            /// <returns>class GameSaveData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gameSaveData", "GameSaveData")]
           public partial nint GAME_SAVE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<RareLvData> rareLvData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<RareLvData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rareLvData", "System.Collections.Generic.List<RareLvData>")]
           public partial nint RARE_LV_DATA { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<ForceLevelData> forceLevelData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceLevelData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceLevelData", "System.Collections.Generic.List<ForceLevelData>")]
           public partial nint FORCE_LEVEL_DATA { get; set; } 
*/

            /// <summary>
            /// 0x40 EventData AiForceAttackPlayerAreaEvent
            /// class ["Assembly-CSharp.dll".""."EventData"]
            /// </summary>
            /// <returns>class EventData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AiForceAttackPlayerAreaEvent", "EventData")]
           public partial nint AI_FORCE_ATTACK_PLAYER_AREA_EVENT { get; set; } 
*/

            /// <summary>
            /// 0x48 EventData AiForceAttackPlayerResourcePointEvent
            /// class ["Assembly-CSharp.dll".""."EventData"]
            /// </summary>
            /// <returns>class EventData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AiForceAttackPlayerResourcePointEvent", "EventData")]
           public partial nint AI_FORCE_ATTACK_PLAYER_RESOURCE_POINT_EVENT { get; set; } 
*/

            /// <summary>
            /// 0x50 EventData AiForceAttackFriendAreaEvent
            /// class ["Assembly-CSharp.dll".""."EventData"]
            /// </summary>
            /// <returns>class EventData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AiForceAttackFriendAreaEvent", "EventData")]
           public partial nint AI_FORCE_ATTACK_FRIEND_AREA_EVENT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.List<ForceJobSettingDataBase> forceJobSettingDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceJobSettingDataBase></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceJobSettingDataBase", "System.Collections.Generic.List<ForceJobSettingDataBase>")]
           public partial nint FORCE_JOB_SETTING_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<System.String> familyNameDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("familyNameDataBase", "System.Collections.Generic.List<System.String>")]
           public partial nint FAMILY_NAME_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<System.String> givenNameDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("givenNameDataBase", "System.Collections.Generic.List<System.String>")]
           public partial nint GIVEN_NAME_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.List<System.String> maleGivenNameDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maleGivenNameDataBase", "System.Collections.Generic.List<System.String>")]
           public partial nint MALE_GIVEN_NAME_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<System.String> femaleGivenNameDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("femaleGivenNameDataBase", "System.Collections.Generic.List<System.String>")]
           public partial nint FEMALE_GIVEN_NAME_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.List<HeroSpeAddDataBase> speAddDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroSpeAddDataBase></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speAddDataBase", "System.Collections.Generic.List<HeroSpeAddDataBase>")]
           public partial nint SPE_ADD_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.List<ForceSpeAddDataBase> forceSpeAddDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceSpeAddDataBase></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceSpeAddDataBase", "System.Collections.Generic.List<ForceSpeAddDataBase>")]
           public partial nint FORCE_SPE_ADD_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.List<ForceTechDataBase> forceTechDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceTechDataBase></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceTechDataBase", "System.Collections.Generic.List<ForceTechDataBase>")]
           public partial nint FORCE_TECH_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Collections.Generic.List<System.Int32> randomSpeAddAvailableID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("randomSpeAddAvailableID", "System.Collections.Generic.List<System.Int32>")]
           public partial nint RANDOM_SPE_ADD_AVAILABLE_ID { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Collections.Generic.List<System.Int32> randomSpeAddNegativeAvailableID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("randomSpeAddNegativeAvailableID", "System.Collections.Generic.List<System.Int32>")]
           public partial nint RANDOM_SPE_ADD_NEGATIVE_AVAILABLE_ID { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Collections.Generic.List<System.Int32> randomSpeAddSelfBuffID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("randomSpeAddSelfBuffID", "System.Collections.Generic.List<System.Int32>")]
           public partial nint RANDOM_SPE_ADD_SELF_BUFF_ID { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.List<AreaData> areaDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<AreaData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("areaDataBase", "System.Collections.Generic.List<AreaData>")]
           public partial nint AREA_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<ForceData> forceDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceDataBase", "System.Collections.Generic.List<ForceData>")]
            public partial SysPtrList<ForceData.Ptr_ForceData> FORCE_DATA_BASE { get; set; }


            /// <summary>
            /// 0xC0 System.Collections.Generic.List<System.Int32> bigForceIDList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bigForceIDList", "System.Collections.Generic.List<System.Int32>")]
           public partial nint BIG_FORCE_ID_LIST { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.List<AreaBuildingDataBase> buildingDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<AreaBuildingDataBase></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buildingDataBase", "System.Collections.Generic.List<AreaBuildingDataBase>")]
           public partial nint BUILDING_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> buildingDataBaseTypeIDList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buildingDataBaseTypeIDList", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
           public partial nint BUILDING_DATA_BASE_TYPE_ID_LIST { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<ItemData> weaponDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("weaponDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> WEAPON_DATA_BASE { get; set; }


            /// <summary>
            /// 0xE0 System.Collections.Generic.List<ItemData> armorDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("armorDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> ARMOR_DATA_BASE { get; set; }


            /// <summary>
            /// 0xE8 System.Collections.Generic.List<ItemData> helmetDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("helmetDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> HELMET_DATA_BASE { get; set; }


            /// <summary>
            /// 0xF0 System.Collections.Generic.List<ItemData> shoesDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shoesDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> SHOES_DATA_BASE { get; set; }


            /// <summary>
            /// 0xF8 System.Collections.Generic.List<ItemData> medDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("medDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> MED_DATA_BASE { get; set; }


            /// <summary>
            /// 0x100 System.Collections.Generic.List<ItemData> foodDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("foodDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> FOOD_DATA_BASE { get; set; }


            /// <summary>
            /// 0x108 System.Collections.Generic.List<ItemData> horseDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("horseDataBase", "System.Collections.Generic.List<ItemData>")]
            public partial SysPtrList<ItemData.Ptr_ItemData> HORSE_DATA_BASE { get; set; }


            /// <summary>
            /// 0x110 System.Collections.Generic.List<KungfuSkillData> kungfuSkillDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<KungfuSkillData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kungfuSkillDataBase", "System.Collections.Generic.List<KungfuSkillData>")]
            public partial SysPtrList<KungfuSkillData.Ptr_KungfuSkillData> KUNGFU_SKILL_DATA_BASE { get; set; }


            /// <summary>
            /// 0x118 System.Collections.Generic.List<KungfuSkillData> summonSkillDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<KungfuSkillData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonSkillDataBase", "System.Collections.Generic.List<KungfuSkillData>")]
            public partial SysPtrList<KungfuSkillData.Ptr_KungfuSkillData> SUMMON_SKILL_DATA_BASE { get; set; }


            /// <summary>
            /// 0x120 System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<KungfuSkillData>>> kungfuSkillDataList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<KungfuSkillData>>></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kungfuSkillDataList", "System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<KungfuSkillData>>>")]
            public partial SysPtrList<SysPtrList<KungfuSkillData.Ptr_KungfuSkillData>> KUNGFU_SKILL_DATA_LIST { get; set; }


            /// <summary>
            /// 0x128 System.Collections.Generic.List<System.Collections.Generic.List<System.String>> HeroNatureTalkTextDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.String>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroNatureTalkTextDataBase", "System.Collections.Generic.List<System.Collections.Generic.List<System.String>>")]
           public partial nint HERO_NATURE_TALK_TEXT_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<HeroData> SpeHeroDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SpeHeroDataBase", "System.Collections.Generic.List<HeroData>")]
            public partial SysPtrList<HeroData.Ptr_HeroData> SPE_HERO_DATA_BASE { get; set; }


            /// <summary>
            /// 0x138 HeroFaceData MaleFaceTotalNum
            /// class ["Assembly-CSharp.dll".""."HeroFaceData"]
            /// </summary>
            /// <returns>class HeroFaceData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaleFaceTotalNum", "HeroFaceData")]
           public partial nint MALE_FACE_TOTAL_NUM { get; set; } 
*/

            /// <summary>
            /// 0x140 HeroFaceData FemaleFaceTotalNum
            /// class ["Assembly-CSharp.dll".""."HeroFaceData"]
            /// </summary>
            /// <returns>class HeroFaceData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FemaleFaceTotalNum", "HeroFaceData")]
           public partial nint FEMALE_FACE_TOTAL_NUM { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> MaleFaceRandomID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaleFaceRandomID", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
           public partial nint MALE_FACE_RANDOM_ID { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> FemaleFaceRandomID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FemaleFaceRandomID", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
           public partial nint FEMALE_FACE_RANDOM_ID { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Collections.Generic.List<PlotData> PlotDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlotData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlotDataBase", "System.Collections.Generic.List<PlotData>")]
           public partial nint PLOT_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x160 System.Collections.Generic.List<SummonData> SummonDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SummonData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SummonDataBase", "System.Collections.Generic.List<SummonData>")]
           public partial nint SUMMON_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x168 System.Collections.Generic.List<ResourcePointTypeData> resourcePointTypeDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ResourcePointTypeData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointTypeDataBase", "System.Collections.Generic.List<ResourcePointTypeData>")]
           public partial nint RESOURCE_POINT_TYPE_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x170 System.Collections.Generic.List<ResourcePointData> resourcePointDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ResourcePointData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointDataBase", "System.Collections.Generic.List<ResourcePointData>")]
           public partial nint RESOURCE_POINT_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x178 System.Collections.Generic.List<HeroTagDataBase> heroTagDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroTagDataBase></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroTagDataBase", "System.Collections.Generic.List<HeroTagDataBase>")]
            public partial SysPtrList<HeroTagDataBase.Ptr_HeroTagDataBase> HERO_TAG_DATA_BASE { get; set; }


            /// <summary>
            /// 0x180 System.Collections.Generic.List<InnData> innDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<InnData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("innDataBase", "System.Collections.Generic.List<InnData>")]
           public partial nint INN_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x188 System.Collections.Generic.List<SkinDataBase> skinDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SkinDataBase></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinDataBase", "System.Collections.Generic.List<SkinDataBase>")]
            public partial SysPtrList<SkinDataBase.Ptr_SkinDataBase> SKIN_DATA_BASE { get; set; }


            /// <summary>
            /// 0x190 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> CheckReplaceSkillIconList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CheckReplaceSkillIconList", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
           public partial nint CHECK_REPLACE_SKILL_ICON_LIST { get; set; } 
*/

            /// <summary>
            /// 0x198 System.Collections.Generic.List<BookTypeIconData> bookTypeIconDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<BookTypeIconData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookTypeIconDataBase", "System.Collections.Generic.List<BookTypeIconData>")]
           public partial nint BOOK_TYPE_ICON_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x1A0 System.Collections.Generic.List<PoetryData> poetryDataBase
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PoetryData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("poetryDataBase", "System.Collections.Generic.List<PoetryData>")]
           public partial nint POETRY_DATA_BASE { get; set; } 
*/

            /// <summary>
            /// 0x1A8 System.Boolean CISFilterWordsSDKInited
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CISFilterWordsSDKInited", "System.Boolean")]
           public partial System.Boolean CIS_FILTER_WORDS_SDK_INITED { get; set; } 
*/

            /// <summary>
            /// 0x1A9 System.Boolean NameCensorWordsChecked
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NameCensorWordsChecked", "System.Boolean")]
           public partial System.Boolean NAME_CENSOR_WORDS_CHECKED { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GameDataController"]
        /// </summary>
        partial struct Ptr_GameDataController
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  GameDataController get_Instance()
            /// </summary>
            /// <returns>class GameDataController</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "GameDataController", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_INSTANCE(); 
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
            ///   System.Void <InitWithEtag>b__61_0(CISFilterWordsSDK.OnlineCensorFileResult result)
            /// </summary>
            /// <param name = "result">class CISFilterWordsSDK.OnlineCensorFileResult</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<InitWithEtag>b__61_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("CISFilterWordsSDK.OnlineCensorFileResult", 0)]
            public partial void INIT_WITH_ETAGB__61_0(nint result); 
*/
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Awake", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AWAKE(); 
*/
            /// <summary>
            ///   System.Boolean CanSaveLoad()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanSaveLoad", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_SAVE_LOAD(); 
*/
            /// <summary>
            ///   System.Void CheckNameCensorWords()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNameCensorWords", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_NAME_CENSOR_WORDS(); 
*/
            /// <summary>
            ///   System.Void CopyLocalCensorWordsFile()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyLocalCensorWordsFile", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void COPY_LOCAL_CENSOR_WORDS_FILE(); 
*/
            /// <summary>
            ///   System.Void CopyTestSave(System.String sourcePath, System.String destPath)
            /// </summary>
            /// <param name = "sourcePath">class System.String</param>
            /// <param name = "destPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTestSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void COPY_TEST_SAVE(nint sourcePath, nint destPath); 
*/
            /// <summary>
            ///   System.Void DeleteSave(System.Int32 saveID)
            /// </summary>
            /// <param name = "saveID">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteSave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void DELETE_SAVE(System.Int32 saveID); 
*/
            /// <summary>
            ///   SkinDataBase FindSkinDataBase(System.Int32 targetSkinID)
            /// </summary>
            /// <param name = "targetSkinID">struct System.Int32</param>
            /// <returns>class SkinDataBase</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindSkinDataBase", "SkinDataBase", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint FIND_SKIN_DATA_BASE(System.Int32 targetSkinID); 
*/
            /// <summary>
            ///   System.Void GameDataIntoGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GameDataIntoGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void GAME_DATA_INTO_GAME(); 
*/
            /// <summary>
            ///   System.Void GameIntoGameData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GameIntoGameData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void GAME_INTO_GAME_DATA(); 
*/
            /// <summary>
            ///   System.String GenerateRandomHeroFamilyName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateRandomHeroFamilyName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GENERATE_RANDOM_HERO_FAMILY_NAME(); 
*/
            /// <summary>
            ///   System.String GenerateRandomHeroGivenName(System.Boolean isFemale, System.Boolean useCensorWords)
            /// </summary>
            /// <param name = "isFemale">struct System.Boolean</param>
            /// <param name = "useCensorWords">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateRandomHeroGivenName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GENERATE_RANDOM_HERO_GIVEN_NAME(System.Boolean isFemale, System.Boolean useCensorWords); 
*/
            /// <summary>
            ///   System.String GenerateRandomHeroName(System.Boolean isFemale, System.String familyName, System.Boolean useCensorWords)
            /// </summary>
            /// <param name = "isFemale">struct System.Boolean</param>
            /// <param name = "familyName">class System.String</param>
            /// <param name = "useCensorWords">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateRandomHeroName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint GENERATE_RANDOM_HERO_NAME(System.Boolean isFemale, nint familyName, System.Boolean useCensorWords); 
*/
            /// <summary>
            ///   SaveInfo GenerateSaveInfo()
            /// </summary>
            /// <returns>class SaveInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateSaveInfo", "SaveInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GENERATE_SAVE_INFO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetBuildingTypeIDList(System.Int32 TargetBuildingID)
            /// </summary>
            /// <param name = "TargetBuildingID">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuildingTypeIDList", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_BUILDING_TYPE_ID_LIST(System.Int32 TargetBuildingID); 
*/
            /// <summary>
            ///   System.Int32 GetForceID(System.String forceName)
            /// </summary>
            /// <param name = "forceName">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_FORCE_ID(nint forceName); 
*/
            /// <summary>
            ///   System.String GetPlayerPrefFilePath()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPlayerPrefFilePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PLAYER_PREF_FILE_PATH(); 
*/
            /// <summary>
            ///   System.Int32 GetRandomBigForceID(System.Single noBigForceRate, System.Int32 noBigForceResult)
            /// </summary>
            /// <param name = "noBigForceRate">struct System.Single</param>
            /// <param name = "noBigForceResult">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomBigForceID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_RANDOM_BIG_FORCE_ID(System.Single noBigForceRate, System.Int32 noBigForceResult); 
*/
            /// <summary>
            ///   System.String GetSaveDataPath(System.Int32 saveID, System.Int32 saveType)
            /// </summary>
            /// <param name = "saveID">struct System.Int32</param>
            /// <param name = "saveType">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSaveDataPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_SAVE_DATA_PATH(System.Int32 saveID, System.Int32 saveType); 
*/
            /// <summary>
            ///   System.String GetSaveDataPath()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSaveDataPath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SAVE_DATA_PATH(); 
*/
            /// <summary>
            ///   SaveInfo GetSaveInfo(System.Int32 saveID)
            /// </summary>
            /// <param name = "saveID">struct System.Int32</param>
            /// <returns>class SaveInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSaveInfo", "SaveInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SAVE_INFO(System.Int32 saveID); 
*/
            /// <summary>
            ///   KungfuSkillData GetSkillDataBase(System.Int32 skillID)
            /// </summary>
            /// <param name = "skillID">struct System.Int32</param>
            /// <returns>class KungfuSkillData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillDataBase", "KungfuSkillData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SKILL_DATA_BASE(System.Int32 skillID); 
*/
            /// <summary>
            ///   System.Int32 GetSkillID(System.String skillName)
            /// </summary>
            /// <param name = "skillName">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_SKILL_ID(nint skillName); 
*/
            /// <summary>
            ///   System.Int32 GetTagID(System.String tagName)
            /// </summary>
            /// <param name = "tagName">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTagID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_TAG_ID(nint tagName); 
*/
            /// <summary>
            ///   System.Boolean HaveSave(System.Int32 saveID)
            /// </summary>
            /// <param name = "saveID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveSave", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean HAVE_SAVE(System.Int32 saveID); 
*/
            /// <summary>
            ///   System.Void InitWithEtag()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitWithEtag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_WITH_ETAG(); 
*/
            /// <summary>
            ///   System.Void InitWithLocalFile()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitWithLocalFile", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_WITH_LOCAL_FILE(); 
*/
            /// <summary>
            ///   System.Void Load(System.Int32 saveID)
            /// </summary>
            /// <param name = "saveID">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void LOAD(System.Int32 saveID); 
*/
            /// <summary>
            ///   System.Void LoadAllGameData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadAllGameData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_ALL_GAME_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadHorseData(ItemData newHorseData, LTCSVLoader loader, System.Int32 i)
            /// </summary>
            /// <param name = "newHorseData">class ItemData</param>
            /// <param name = "loader">class LTCSVLoader</param>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadHorseData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LTCSVLoader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void LOAD_HORSE_DATA(nint newHorseData, nint loader, System.Int32 i); 
*/
            /// <summary>
            ///   System.Void LoadMedFoodData(ItemData newMedData, LTCSVLoader loader, System.Int32 i)
            /// </summary>
            /// <param name = "newMedData">class ItemData</param>
            /// <param name = "loader">class LTCSVLoader</param>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadMedFoodData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LTCSVLoader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void LOAD_MED_FOOD_DATA(nint newMedData, nint loader, System.Int32 i); 
*/
            /// <summary>
            ///   System.Void LoadPeotryData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadPeotryData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_PEOTRY_DATA(); 
*/
            /// <summary>
            ///   System.Void LoadPlayerprefData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadPlayerprefData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_PLAYERPREF_DATA(); 
*/
            /// <summary>
            ///   KungfuSkillData LoadSkillData(LTCSVLoader loader, System.Int32 i, System.Boolean _summonSkill)
            /// </summary>
            /// <param name = "loader">class LTCSVLoader</param>
            /// <param name = "i">struct System.Int32</param>
            /// <param name = "_summonSkill">struct System.Boolean</param>
            /// <returns>class KungfuSkillData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadSkillData", "KungfuSkillData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LTCSVLoader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint LOAD_SKILL_DATA(nint loader, System.Int32 i, System.Boolean _summonSkill); 
*/
            /// <summary>
            ///   System.Void Save(System.Int32 saveID)
            /// </summary>
            /// <param name = "saveID">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Save", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SAVE(System.Int32 saveID); 
*/
            /// <summary>
            ///   System.Void SavePlayerprefData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SavePlayerprefData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SAVE_PLAYERPREF_DATA(); 
*/
            /// <summary>
            ///   System.Void Start()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Start", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<SkillAttackRangeData> StringToAttackRange(System.String resource)
            /// </summary>
            /// <param name = "resource">class System.String</param>
            /// <returns>class System.Collections.Generic.List<SkillAttackRangeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StringToAttackRange", "System.Collections.Generic.List<SkillAttackRangeData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint STRING_TO_ATTACK_RANGE(nint resource); 
*/
            /// <summary>
            ///   AttriNumData StringToAttriRatio(System.String resource)
            /// </summary>
            /// <param name = "resource">class System.String</param>
            /// <returns>class AttriNumData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StringToAttriRatio", "AttriNumData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint STRING_TO_ATTRI_RATIO(nint resource); 
*/
            /// <summary>
            ///   SkillDamageRangeData StringToDamageRange(System.String resource)
            /// </summary>
            /// <param name = "resource">class System.String</param>
            /// <returns>class SkillDamageRangeData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StringToDamageRange", "SkillDamageRangeData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint STRING_TO_DAMAGE_RANGE(nint resource); 
*/
            /// <summary>
            ///   HeroSpeAddData StringToSpeAddData(System.String resource)
            /// </summary>
            /// <param name = "resource">class System.String</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StringToSpeAddData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint STRING_TO_SPE_ADD_DATA(nint resource); 
*/
            /// <summary>
            ///   System.Void WriteCheckSkillCsv()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("WriteCheckSkillCsv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void WRITE_CHECK_SKILL_CSV(); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Behaviour"]
        /// </summary>
        partial struct Ptr_GameDataController
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_enabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_ENABLED(); 
*/
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isActiveAndEnabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ACTIVE_AND_ENABLED(); 
*/
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_enabled", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_ENABLED(System.Boolean value); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."MonoBehaviour"]
        /// </summary>
        partial struct Ptr_GameDataController
        {
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CANCEL_INVOKE(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CancelInvokeAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            public static partial void INTERNAL_CANCEL_INVOKE_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_IsInvokingAll", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            public static partial System.Boolean INTERNAL_IS_INVOKING_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeDelayed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public static partial void INVOKE_DELAYED(nint self, nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial System.Boolean IS_INVOKING(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsObjectMonoBehaviour", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_OBJECT_MONO_BEHAVIOUR(nint obj); 
*/
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name = "message">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("print", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public static partial void PRINT(nint message); 
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
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CANCEL_INVOKE(); 
*/
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CANCEL_INVOKE(nint methodName); 
*/
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_useGUILayout", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_USE_GUI_LAYOUT(); 
*/
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetScriptClassName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCRIPT_CLASS_NAME(); 
*/
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Invoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void INVOKE(nint methodName, System.Single time); 
*/
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeRepeating", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void INVOKE_REPEATING(nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_INVOKING(); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_INVOKING(nint methodName); 
*/
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_useGUILayout", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_USE_GUI_LAYOUT(System.Boolean value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint START_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial nint START_COROUTINE(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine_Auto", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE_AUTO(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutineManaged", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial nint START_COROUTINE_MANAGED(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name = "enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutineManaged2", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE_MANAGED2(nint enumerator); 
*/
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopAllCoroutines", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void STOP_ALL_COROUTINES(); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Coroutine", 0)]
            public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void STOP_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutineFromEnumeratorManaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutineManaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Coroutine", 0)]
            public partial void STOP_COROUTINE_MANAGED(nint routine); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Object"]
        /// </summary>
        partial struct Ptr_GameDataController
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name = "arg">class System.Object</param>
            /// <param name = "message">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNullArgument", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CHECK_NULL_ARGUMENT(nint arg, nint message); 
*/
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name = "lhs">class UnityEngine.Object</param>
            /// <param name = "rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompareBaseObjects", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean COMPARE_BASE_OBJECTS(nint lhs, nint rhs); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial void DESTROY_IMMEDIATE(nint obj, System.Boolean allowDestroyingAssets); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_IMMEDIATE(nint obj); 
*/
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name = "target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DontDestroyOnLoad", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DONT_DESTROY_ON_LOAD(nint target); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FIND_OBJECT_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint GET_NAME(nint obj); 
*/
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOffsetOfInstanceIDInCPlusPlusObject", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT(); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean instantiateInWorldSpace); 
*/
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INTERNAL_CLONE_SINGLE(nint data); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_PARENT(nint data, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE(nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_INJECTED(nint data, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name = "o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsNativeObjectAlive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_NATIVE_OBJECT_ALIVE(nint o); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_EQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name = "exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean OP_IMPLICIT(nint exists); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_INEQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void SET_NAME(nint obj, nint name); 
*/
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint TO_STRING(nint obj); 
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
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name = "other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean EQUALS(nint other); 
*/
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_hideFlags", "UnityEngine.HideFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.HideFlags GET_HIDE_FLAGS(); 
*/
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCachedPtr", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.IntPtr GET_CACHED_PTR(); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInstanceID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_INSTANCE_ID(); 
*/
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_hideFlags", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.HideFlags", 0)]
            public partial void SET_HIDE_FLAGS(UnityEngine.HideFlags value); 
*/
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_STRING(); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Component"]
        /// </summary>
        partial struct Ptr_GameDataController
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "parameter">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BroadcastMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SendMessageOptions", 2)]
            public partial void BROADCAST_MESSAGE(nint methodName, nint parameter, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BroadcastMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void BROADCAST_MESSAGE(nint methodName); 
*/
            /// <summary>
            ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BroadcastMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SendMessageOptions", 1)]
            public partial void BROADCAST_MESSAGE(nint methodName, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name = "tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompareTag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean COMPARE_TAG(nint tag); 
*/
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_gameObject", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME_OBJECT(); 
*/
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_transform", "UnityEngine.Transform", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TRANSFORM(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public partial nint GET_COMPONENT(nint type); 
*/
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT(); 
*/
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentFastPath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 1)]
            public partial void GET_COMPONENT_FAST_PATH(nint type, System.IntPtr oneFurtherThanResultValue); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_COMPONENT_IN_CHILDREN(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT_IN_CHILDREN(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_COMPONENT_IN_PARENT(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Component>", 1)]
            public partial void GET_COMPONENTS(nint type, nint results); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
            public partial void GET_COMPONENTS(nint results); 
*/
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name = "searchType">abstract class System.Type</param>
            /// <param name = "resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsForListInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void GET_COMPONENTS_FOR_LIST_INTERNAL(nint searchType, nint resultList); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 1)]
            public partial void GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive, nint result); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_IN_CHILDREN(); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
            public partial void GET_COMPONENTS_IN_CHILDREN(nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 1)]
            public partial void GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive, nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void SEND_MESSAGE(nint methodName, nint value); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SEND_MESSAGE(nint methodName); 
*/
            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <param name = "options">enum UnityEngine.SendMessageOptions</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendMessage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SendMessageOptions", 2)]
            public partial void SEND_MESSAGE(nint methodName, nint value, UnityEngine.SendMessageOptions options); 
*/
            /// <summary>
            ///   System.Void set_tag(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_tag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_TAG(nint value); 
*/
        }
    }
}