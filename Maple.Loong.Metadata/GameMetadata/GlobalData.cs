namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."GlobalData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GlobalData>, Ptr_GlobalData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "GlobalData", "GlobalData")]
    public partial class GlobalData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GlobalData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GlobalData(System.IntPtr ptr) => new Ptr_GlobalData(ptr);
            public static implicit operator System.IntPtr(Ptr_GlobalData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_GlobalData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GlobalData"]
        /// </summary>
        partial struct Ptr_GlobalData
        {
            /// <summary>
            /// 0x0 System.Single GameObjScale
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single GAME_OBJ_SCALE = 0.186; 
*/
            /// <summary>
            /// 0x0 System.Single areaMapTileSize
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single AREA_MAP_TILE_SIZE = 1; 
*/
            /// <summary>
            /// 0x0 System.Int32 WorldMapMaxTryTimes
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 WORLD_MAP_MAX_TRY_TIMES = 99; 
*/
            /// <summary>
            /// 0x0 System.Int32 Infinity
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            public const System.Int32 INFINITY = 999999; 
*/
            /// <summary>
            /// 0x0 System.Single AIMoveThinkTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single AI_MOVE_THINK_TIME = 0.5; 
*/
            /// <summary>
            /// 0x0 System.Single AIAttackThinkTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single AI_ATTACK_THINK_TIME = 0.5; 
*/
            /// <summary>
            /// 0x0 System.String leftFootStepEventName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint LEFT_FOOT_STEP_EVENT_NAME = leftfootstep; 
*/
            /// <summary>
            /// 0x0 System.String rightFootStepEventName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint RIGHT_FOOT_STEP_EVENT_NAME = rightfootstep; 
*/
            /// <summary>
            /// 0x0 Version GameVersion
            /// enum ["Assembly-CSharp.dll".""."Version"]
            /// </summary>
            /// <returns>enum Version</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GameVersion", "Version")]
            public static partial Version GAME_VERSION { get; set; } 
*/

            /// <summary>
            /// 0x4 DemoVersion DemoVersion
            /// enum ["Assembly-CSharp.dll".""."DemoVersion"]
            /// </summary>
            /// <returns>enum DemoVersion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DemoVersion", "DemoVersion")]
            public static partial DemoVersion DEMO_VERSION { get; set; } 
*/

            /// <summary>
            /// 0x8 System.Boolean GameConsoleEnabled
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GameConsoleEnabled", "System.Boolean")]
            public static partial System.Boolean GAME_CONSOLE_ENABLED { get; set; } 
*/

            /// <summary>
            /// 0x10 System.Collections.Generic.List<System.Int32> PlayTestAvailableAreaID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayTestAvailableAreaID", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint PLAY_TEST_AVAILABLE_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.Int32> PlayTestAvailableForceID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayTestAvailableForceID", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint PLAY_TEST_AVAILABLE_FORCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.Int32> PlayTestAvailableInnID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayTestAvailableInnID", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint PLAY_TEST_AVAILABLE_INN_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 PlayTestMaxLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayTestMaxLv", "System.Int32")]
            public static partial System.Int32 PLAY_TEST_MAX_LV { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 PlayTestMaxFavor
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayTestMaxFavor", "System.Int32")]
            public static partial System.Int32 PLAY_TEST_MAX_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String VersionNum
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("VersionNum", "System.String")]
            public static partial nint VERSION_NUM { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String FixNum
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FixNum", "System.String")]
            public static partial nint FIX_NUM { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Random systemRandom
            /// class ["mscorlib.dll"."System"."Random"]
            /// </summary>
            /// <returns>class System.Random</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("systemRandom", "System.Random")]
            public static partial nint SYSTEM_RANDOM { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Single MaxAreaStateDefenceRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxAreaStateDefenceRate", "System.Single")]
            public static partial System.Single MAX_AREA_STATE_DEFENCE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Single AttackAreaFightScoreRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttackAreaFightScoreRate", "System.Single")]
            public static partial System.Single ATTACK_AREA_FIGHT_SCORE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 MaxAttackSkillNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxAttackSkillNum", "System.Int32")]
            public static partial System.Int32 MAX_ATTACK_SKILL_NUM { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 MaxTagNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxTagNum", "System.Int32")]
            public static partial System.Int32 MAX_TAG_NUM { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 MaxFriendNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxFriendNum", "System.Int32")]
            public static partial System.Int32 MAX_FRIEND_NUM { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 MaxLoverNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxLoverNum", "System.Int32")]
            public static partial System.Int32 MAX_LOVER_NUM { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Int32 MaxBrotherNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxBrotherNum", "System.Int32")]
            public static partial System.Int32 MAX_BROTHER_NUM { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 MaxHeroNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxHeroNum", "System.Int32")]
            public static partial System.Int32 MAX_HERO_NUM { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 RecommendHeroNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RecommendHeroNum", "System.Int32")]
            public static partial System.Int32 RECOMMEND_HERO_NUM { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Single MapBorderWidth
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MapBorderWidth", "System.Single")]
            public static partial System.Single MAP_BORDER_WIDTH { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Single MapBorderHeight
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MapBorderHeight", "System.Single")]
            public static partial System.Single MAP_BORDER_HEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<System.String> ResulotionChoice
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ResulotionChoice", "System.Collections.Generic.List<System.String>")]
            public static partial nint RESULOTION_CHOICE { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String NumText
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NumText", "System.String")]
            public static partial nint NUM_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String ChineseNumText
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChineseNumText", "System.String")]
            public static partial nint CHINESE_NUM_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 MaxLogNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxLogNum", "System.Int32")]
            public static partial System.Int32 MAX_LOG_NUM { get; set; } 
*/

            /// <summary>
            /// 0x94 System.Int32 PlayerForceID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayerForceID", "System.Int32")]
            public static partial System.Int32 PLAYER_FORCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Single HeroBaseHp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroBaseHp", "System.Single")]
            public static partial System.Single HERO_BASE_HP { get; set; } 
*/

            /// <summary>
            /// 0x9C System.Single HeroBaseMp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroBaseMp", "System.Single")]
            public static partial System.Single HERO_BASE_MP { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 HeroMaxAttriNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroMaxAttriNum", "System.Int32")]
            public static partial System.Int32 HERO_MAX_ATTRI_NUM { get; set; } 
*/

            /// <summary>
            /// 0xA4 System.Int32 HeroMaxFightSkillNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroMaxFightSkillNum", "System.Int32")]
            public static partial System.Int32 HERO_MAX_FIGHT_SKILL_NUM { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 HeroMaxLivingSkillNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroMaxLivingSkillNum", "System.Int32")]
            public static partial System.Int32 HERO_MAX_LIVING_SKILL_NUM { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Single BigMapWidthHalf
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BigMapWidthHalf", "System.Single")]
            public static partial System.Single BIG_MAP_WIDTH_HALF { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Single BigMapHeightHalf
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BigMapHeightHalf", "System.Single")]
            public static partial System.Single BIG_MAP_HEIGHT_HALF { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Single BigMapVectorScale
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BigMapVectorScale", "System.Single")]
            public static partial System.Single BIG_MAP_VECTOR_SCALE { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Int32 TempHeroIDStart
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TempHeroIDStart", "System.Int32")]
            public static partial System.Int32 TEMP_HERO_ID_START { get; set; } 
*/

            /// <summary>
            /// 0xBC System.Int32 SummonSkillIDStart
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SummonSkillIDStart", "System.Int32")]
            public static partial System.Int32 SUMMON_SKILL_ID_START { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Single BaseTravelSpeed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BaseTravelSpeed", "System.Single")]
            public static partial System.Single BASE_TRAVEL_SPEED { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Single BaseTravelTimeScale
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BaseTravelTimeScale", "System.Single")]
            public static partial System.Single BASE_TRAVEL_TIME_SCALE { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Single BuildingUpgradeAddProduceRatio
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuildingUpgradeAddProduceRatio", "System.Single")]
            public static partial System.Single BUILDING_UPGRADE_ADD_PRODUCE_RATIO { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Single CrimeBadFame
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CrimeBadFame", "System.Single")]
            public static partial System.Single CRIME_BAD_FAME { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Single RestBaseRecoverRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RestBaseRecoverRate", "System.Single")]
            public static partial System.Single REST_BASE_RECOVER_RATE { get; set; } 
*/

            /// <summary>
            /// 0xD4 System.Single NormalBaseRecoverRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NormalBaseRecoverRate", "System.Single")]
            public static partial System.Single NORMAL_BASE_RECOVER_RATE { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<System.Int32> AutoSkillAttriNeedNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AutoSkillAttriNeedNum", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint AUTO_SKILL_ATTRI_NEED_NUM { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Collections.Generic.List<System.Single> MaxSkillNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxSkillNum", "System.Collections.Generic.List<System.Single>")]
            public static partial nint MAX_SKILL_NUM { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Single CureInjuryToFavorRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CureInjuryToFavorRate", "System.Single")]
            public static partial System.Single CURE_INJURY_TO_FAVOR_RATE { get; set; } 
*/

            /// <summary>
            /// 0xEC UnityEngine.Vector3 FlipXScale
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FlipXScale", "UnityEngine.Vector3")]
            public static partial UnityEngine.Vector3 FLIP_X_SCALE { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Single AutoPracticeExpRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AutoPracticeExpRate", "System.Single")]
            public static partial System.Single AUTO_PRACTICE_EXP_RATE { get; set; } 
*/

            /// <summary>
            /// 0xFC System.Int32 MaxInternalSkillSelfStudyLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxInternalSkillSelfStudyLv", "System.Int32")]
            public static partial System.Int32 MAX_INTERNAL_SKILL_SELF_STUDY_LV { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32 MaxFightSkillSelfStudyLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxFightSkillSelfStudyLv", "System.Int32")]
            public static partial System.Int32 MAX_FIGHT_SKILL_SELF_STUDY_LV { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Collections.Generic.List<System.Int32> NoFemaleForce
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NoFemaleForce", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint NO_FEMALE_FORCE { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Collections.Generic.List<System.String> SpeWeakHeroName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SpeWeakHeroName", "System.Collections.Generic.List<System.String>")]
            public static partial nint SPE_WEAK_HERO_NAME { get; set; } 
*/

            /// <summary>
            /// 0x118 System.String leftFootBone
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("leftFootBone", "System.String")]
            public static partial nint LEFT_FOOT_BONE { get; set; } 
*/

            /// <summary>
            /// 0x120 System.String rightFootBone
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rightFootBone", "System.String")]
            public static partial nint RIGHT_FOOT_BONE { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Collections.Generic.List<System.String> HorseFootStepEvent
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HorseFootStepEvent", "System.Collections.Generic.List<System.String>")]
            public static partial nint HORSE_FOOT_STEP_EVENT { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<System.String> HorseFootStepTargetBone
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HorseFootStepTargetBone", "System.Collections.Generic.List<System.String>")]
            public static partial nint HORSE_FOOT_STEP_TARGET_BONE { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Collections.Generic.List<System.String> FacePartName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FacePartName", "System.Collections.Generic.List<System.String>")]
            public static partial nint FACE_PART_NAME { get; set; } 
*/

            /// <summary>
            /// 0x140 System.Collections.Generic.List<System.String> FaceSlotName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FaceSlotName", "System.Collections.Generic.List<System.String>")]
            public static partial nint FACE_SLOT_NAME { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Single StealItemBadFameValueRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("StealItemBadFameValueRate", "System.Single")]
            public static partial System.Single STEAL_ITEM_BAD_FAME_VALUE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x14C System.Single RobItemBadFameValueRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RobItemBadFameValueRate", "System.Single")]
            public static partial System.Single ROB_ITEM_BAD_FAME_VALUE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Int32 BattleMapCol
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleMapCol", "System.Int32")]
            public static partial System.Int32 BATTLE_MAP_COL { get; set; } 
*/

            /// <summary>
            /// 0x154 System.Int32 BattleMapRow
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleMapRow", "System.Int32")]
            public static partial System.Int32 BATTLE_MAP_ROW { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Int32 MaxAreaMapCol
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxAreaMapCol", "System.Int32")]
            public static partial System.Int32 MAX_AREA_MAP_COL { get; set; } 
*/

            /// <summary>
            /// 0x15C System.Int32 MaxAreaMapRow
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxAreaMapRow", "System.Int32")]
            public static partial System.Int32 MAX_AREA_MAP_ROW { get; set; } 
*/

            /// <summary>
            /// 0x160 System.Int32 MaxExploreMapCol
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxExploreMapCol", "System.Int32")]
            public static partial System.Int32 MAX_EXPLORE_MAP_COL { get; set; } 
*/

            /// <summary>
            /// 0x164 System.Int32 MaxExploreMapRow
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxExploreMapRow", "System.Int32")]
            public static partial System.Int32 MAX_EXPLORE_MAP_ROW { get; set; } 
*/

            /// <summary>
            /// 0x168 System.Single HorseSprintLast
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HorseSprintLast", "System.Single")]
            public static partial System.Single HORSE_SPRINT_LAST { get; set; } 
*/

            /// <summary>
            /// 0x16C System.Single HorseSprintCd
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HorseSprintCd", "System.Single")]
            public static partial System.Single HORSE_SPRINT_CD { get; set; } 
*/

            /// <summary>
            /// 0x170 System.Int32 ResourcePointFightMaxHeroNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ResourcePointFightMaxHeroNum", "System.Int32")]
            public static partial System.Int32 RESOURCE_POINT_FIGHT_MAX_HERO_NUM { get; set; } 
*/

            /// <summary>
            /// 0x174 System.Int32 MaxInfoCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxInfoCount", "System.Int32")]
            public static partial System.Int32 MAX_INFO_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x178 System.Single MaxFightMovePower
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxFightMovePower", "System.Single")]
            public static partial System.Single MAX_FIGHT_MOVE_POWER { get; set; } 
*/

            /// <summary>
            /// 0x180 System.String LabelPositiveColor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LabelPositiveColor", "System.String")]
            public static partial nint LABEL_POSITIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x188 System.String LabelDarkPositiveColor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LabelDarkPositiveColor", "System.String")]
            public static partial nint LABEL_DARK_POSITIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x190 UnityEngine.Color PositiveColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PositiveColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color POSITIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1A0 UnityEngine.Color DarkPositiveColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DarkPositiveColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color DARK_POSITIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1B0 System.String LabelNegativeColor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LabelNegativeColor", "System.String")]
            public static partial nint LABEL_NEGATIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1B8 System.String LabelDarkNegativeColor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LabelDarkNegativeColor", "System.String")]
            public static partial nint LABEL_DARK_NEGATIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1C0 UnityEngine.Color NegativeColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NegativeColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color NEGATIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1D0 UnityEngine.Color DarkNegativeColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DarkNegativeColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color DARK_NEGATIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1E0 System.String LabelZeroColor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LabelZeroColor", "System.String")]
            public static partial nint LABEL_ZERO_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1E8 UnityEngine.Color ActiveColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActiveColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color ACTIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x1F8 UnityEngine.Color DisactiveColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DisactiveColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color DISACTIVE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x208 UnityEngine.Color DarkestSkinColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DarkestSkinColor", "UnityEngine.Color")]
            public static partial UnityEngine.Color DARKEST_SKIN_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x218 System.Collections.Generic.List<System.String> InjuryName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("InjuryName", "System.Collections.Generic.List<System.String>")]
            public static partial nint INJURY_NAME { get; set; } 
*/

            /// <summary>
            /// 0x220 System.Collections.Generic.List<UnityEngine.Color> InjuryColor
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<UnityEngine.Color></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("InjuryColor", "System.Collections.Generic.List<UnityEngine.Color>")]
            public static partial nint INJURY_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x228 System.Collections.Generic.List<System.String> DirectionName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DirectionName", "System.Collections.Generic.List<System.String>")]
            public static partial nint DIRECTION_NAME { get; set; } 
*/

            /// <summary>
            /// 0x230 System.Collections.Generic.List<System.String> SeasonName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SeasonName", "System.Collections.Generic.List<System.String>")]
            public static partial nint SEASON_NAME { get; set; } 
*/

            /// <summary>
            /// 0x238 System.Collections.Generic.List<System.String> HeroForceLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroForceLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint HERO_FORCE_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x240 System.Collections.Generic.List<System.String> HeroGovernLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroGovernLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint HERO_GOVERN_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x248 System.Collections.Generic.List<System.String> HeroHornorLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroHornorLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint HERO_HORNOR_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x250 System.Collections.Generic.List<System.String> HeroGovernLvType
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroGovernLvType", "System.Collections.Generic.List<System.String>")]
            public static partial nint HERO_GOVERN_LV_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x258 System.Collections.Generic.List<System.Int32> HeroGovernUpgradeNeed
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroGovernUpgradeNeed", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint HERO_GOVERN_UPGRADE_NEED { get; set; } 
*/

            /// <summary>
            /// 0x260 System.Collections.Generic.List<System.String> HeroFreeForceLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroFreeForceLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint HERO_FREE_FORCE_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x268 System.Collections.Generic.List<System.String> HeroBadForceLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HeroBadForceLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint HERO_BAD_FORCE_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x270 System.Collections.Generic.List<System.String> MartialClubLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MartialClubLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint MARTIAL_CLUB_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x278 System.Collections.Generic.List<System.String> TextType
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TextType", "System.Collections.Generic.List<System.String>")]
            public static partial nint TEXT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x280 System.Collections.Generic.List<System.String> AreaTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AreaTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint AREA_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x288 System.Collections.Generic.List<System.Single> AreaSafeRangeRate
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AreaSafeRangeRate", "System.Collections.Generic.List<System.Single>")]
            public static partial nint AREA_SAFE_RANGE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x290 System.Collections.Generic.List<System.String> ResourceName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ResourceName", "System.Collections.Generic.List<System.String>")]
            public static partial nint RESOURCE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x298 System.Collections.Generic.List<System.Single> ResourceValue
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ResourceValue", "System.Collections.Generic.List<System.Single>")]
            public static partial nint RESOURCE_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x2A0 System.Collections.Generic.List<System.String> BattleTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint BATTLE_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x2A8 System.Collections.Generic.List<System.String> BattleTypeDescribe
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleTypeDescribe", "System.Collections.Generic.List<System.String>")]
            public static partial nint BATTLE_TYPE_DESCRIBE { get; set; } 
*/

            /// <summary>
            /// 0x2B0 System.Collections.Generic.List<System.String> MissionSourceTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MissionSourceTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint MISSION_SOURCE_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x2B8 UnityEngine.Color[] MissionColor
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Color[]"]
            /// </summary>
            /// <returns>class UnityEngine.Color[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MissionColor", "UnityEngine.Color[]")]
            public static partial nint MISSION_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x2C0 System.Collections.Generic.List<System.String> AttriName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttriName", "System.Collections.Generic.List<System.String>")]
            public static partial nint ATTRI_NAME { get; set; } 
*/

            /// <summary>
            /// 0x2C8 System.Collections.Generic.List<System.String> FightSkillName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FightSkillName", "System.Collections.Generic.List<System.String>")]
            public static partial nint FIGHT_SKILL_NAME { get; set; } 
*/

            /// <summary>
            /// 0x2D0 System.Collections.Generic.List<System.String> LivingSkillName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LivingSkillName", "System.Collections.Generic.List<System.String>")]
            public static partial nint LIVING_SKILL_NAME { get; set; } 
*/

            /// <summary>
            /// 0x2D8 System.Collections.Generic.List<System.String> LivingSkillDescribe
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LivingSkillDescribe", "System.Collections.Generic.List<System.String>")]
            public static partial nint LIVING_SKILL_DESCRIBE { get; set; } 
*/

            /// <summary>
            /// 0x2E0 System.Collections.Generic.List<System.String> ForceLvNewFucDescribe
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ForceLvNewFucDescribe", "System.Collections.Generic.List<System.String>")]
            public static partial nint FORCE_LV_NEW_FUC_DESCRIBE { get; set; } 
*/

            /// <summary>
            /// 0x2E8 System.Collections.Generic.List<System.Int32> WeaponLvMulti
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WeaponLvMulti", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint WEAPON_LV_MULTI { get; set; } 
*/

            /// <summary>
            /// 0x2F0 System.Collections.Generic.List<System.String> ItemTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ItemTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint ITEM_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x2F8 System.Collections.Generic.List<System.String> EquipmentTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipmentTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint EQUIPMENT_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x300 System.Collections.Generic.List<System.String> DecorationTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DecorationTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint DECORATION_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x308 System.Collections.Generic.List<System.String> FoodTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint FOOD_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x310 System.Collections.Generic.List<System.String> EquipLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint EQUIP_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x318 System.Collections.Generic.List<System.String> SkillLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint SKILL_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x320 System.Collections.Generic.List<System.String> BookRareLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BookRareLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint BOOK_RARE_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x328 System.Collections.Generic.List<System.String> TreasureRareLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TreasureRareLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint TREASURE_RARE_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x330 System.Collections.Generic.List<System.String> TreasureTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TreasureTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint TREASURE_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x338 System.String[,] TreasureItemName
            /// class ["mscorlib.dll"."System"."String[,]"]
            /// </summary>
            /// <returns>class System.String[,]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TreasureItemName", "System.String[,]")]
            public static partial nint TREASURE_ITEM_NAME { get; set; } 
*/

            /// <summary>
            /// 0x340 System.Collections.Generic.List<System.String> TreasureValueLvTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TreasureValueLvTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint TREASURE_VALUE_LV_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x348 System.Collections.Generic.List<System.String> TreasureValueLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TreasureValueLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint TREASURE_VALUE_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x350 System.Collections.Generic.List<System.String> TreasureRareLvTalkText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TreasureRareLvTalkText", "System.Collections.Generic.List<System.String>")]
            public static partial nint TREASURE_RARE_LV_TALK_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x358 System.Collections.Generic.List<System.String> MaterialTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaterialTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint MATERIAL_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x360 System.Collections.Generic.List<System.String> HorseTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HorseTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint HORSE_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x368 System.Collections.Generic.List<System.String> EnemyRobberTalkText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EnemyRobberTalkText", "System.Collections.Generic.List<System.String>")]
            public static partial nint ENEMY_ROBBER_TALK_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x370 System.Collections.Generic.List<System.String> BodyPointName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BodyPointName", "System.Collections.Generic.List<System.String>")]
            public static partial nint BODY_POINT_NAME { get; set; } 
*/

            /// <summary>
            /// 0x378 System.Collections.Generic.List<System.Int32> MoveRangeNeedAttriNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MoveRangeNeedAttriNum", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint MOVE_RANGE_NEED_ATTRI_NUM { get; set; } 
*/

            /// <summary>
            /// 0x380 System.Collections.Generic.List<System.String> AttriRatioString
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttriRatioString", "System.Collections.Generic.List<System.String>")]
            public static partial nint ATTRI_RATIO_STRING { get; set; } 
*/

            /// <summary>
            /// 0x388 System.Collections.Generic.List<System.Int32> AttriLvNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttriLvNum", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint ATTRI_LV_NUM { get; set; } 
*/

            /// <summary>
            /// 0x390 System.Collections.Generic.List<System.Int32> AreaLabelFontSize
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AreaLabelFontSize", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint AREA_LABEL_FONT_SIZE { get; set; } 
*/

            /// <summary>
            /// 0x398 System.Collections.Generic.List<System.String> CraftTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CraftTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint CRAFT_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x3A0 System.Collections.Generic.List<System.String> CraftResourceName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CraftResourceName", "System.Collections.Generic.List<System.String>")]
            public static partial nint CRAFT_RESOURCE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x3A8 System.Collections.Generic.List<System.String> EnhanceTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EnhanceTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint ENHANCE_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x3B0 System.Collections.Generic.List<System.String> CraftPoisonTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CraftPoisonTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint CRAFT_POISON_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x3B8 System.Collections.Generic.List<System.String> BookWriterTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BookWriterTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint BOOK_WRITER_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x3C0 System.Collections.Generic.List<System.String> ChaosText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChaosText", "System.Collections.Generic.List<System.String>")]
            public static partial nint CHAOS_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x3C8 System.Collections.Generic.List<System.String> EvilText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EvilText", "System.Collections.Generic.List<System.String>")]
            public static partial nint EVIL_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x3D0 System.Collections.Generic.List<System.String> NatureText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NatureText", "System.Collections.Generic.List<System.String>")]
            public static partial nint NATURE_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x3D8 System.Collections.Generic.List<System.String> TalentText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TalentText", "System.Collections.Generic.List<System.String>")]
            public static partial nint TALENT_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x3E0 System.Collections.Generic.List<System.String> ForceFocusTypeName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ForceFocusTypeName", "System.Collections.Generic.List<System.String>")]
            public static partial nint FORCE_FOCUS_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x3E8 System.Collections.Generic.List<System.String> BattleScoreText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleScoreText", "System.Collections.Generic.List<System.String>")]
            public static partial nint BATTLE_SCORE_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x3F0 System.Collections.Generic.List<System.String> BranchDefenceTypeText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BranchDefenceTypeText", "System.Collections.Generic.List<System.String>")]
            public static partial nint BRANCH_DEFENCE_TYPE_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x3F8 System.Single EquipTotalWeight
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipTotalWeight", "System.Single")]
            public static partial System.Single EQUIP_TOTAL_WEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x400 System.Collections.Generic.List<System.Single> EquipBaseWeight
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipBaseWeight", "System.Collections.Generic.List<System.Single>")]
            public static partial nint EQUIP_BASE_WEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x408 System.Collections.Generic.List<System.String> EquipmentWeightLvName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipmentWeightLvName", "System.Collections.Generic.List<System.String>")]
            public static partial nint EQUIPMENT_WEIGHT_LV_NAME { get; set; } 
*/

            /// <summary>
            /// 0x410 System.Collections.Generic.List<System.Single> EquipWeightLvSpeedMulti
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EquipWeightLvSpeedMulti", "System.Collections.Generic.List<System.Single>")]
            public static partial nint EQUIP_WEIGHT_LV_SPEED_MULTI { get; set; } 
*/

            /// <summary>
            /// 0x418 System.Collections.Generic.List<System.String> PartPostureName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PartPostureName", "System.Collections.Generic.List<System.String>")]
            public static partial nint PART_POSTURE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x420 System.Collections.Generic.List<HeroSpeAddDataType> PartPostureChangeSpeAdd
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroSpeAddDataType></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PartPostureChangeSpeAdd", "System.Collections.Generic.List<HeroSpeAddDataType>")]
            public static partial nint PART_POSTURE_CHANGE_SPE_ADD { get; set; } 
*/

            /// <summary>
            /// 0x428 System.Collections.Generic.List<System.Collections.Generic.List<HeroSpeAddDataType>> PartPostureEmptySpeAdd
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<HeroSpeAddDataType>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PartPostureEmptySpeAdd", "System.Collections.Generic.List<System.Collections.Generic.List<HeroSpeAddDataType>>")]
            public static partial nint PART_POSTURE_EMPTY_SPE_ADD { get; set; } 
*/

            /// <summary>
            /// 0x430 System.Collections.Generic.List<System.String> AreaStateName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AreaStateName", "System.Collections.Generic.List<System.String>")]
            public static partial nint AREA_STATE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x438 System.Collections.Generic.List<LivingSkillType> AddAreaStateLivingSkillType
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<LivingSkillType></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddAreaStateLivingSkillType", "System.Collections.Generic.List<LivingSkillType>")]
            public static partial nint ADD_AREA_STATE_LIVING_SKILL_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x440 System.Collections.Generic.List<LivingSkillType> ReduceAreaStateLivingSkillType
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<LivingSkillType></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ReduceAreaStateLivingSkillType", "System.Collections.Generic.List<LivingSkillType>")]
            public static partial nint REDUCE_AREA_STATE_LIVING_SKILL_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x448 System.Collections.Generic.List<System.Collections.Generic.List<System.Single>> SkillChangePowerRate
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Single>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillChangePowerRate", "System.Collections.Generic.List<System.Collections.Generic.List<System.Single>>")]
            public static partial nint SKILL_CHANGE_POWER_RATE { get; set; } 
*/

            /// <summary>
            /// 0x450 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> AreaObstacleNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AreaObstacleNum", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
            public static partial nint AREA_OBSTACLE_NUM { get; set; } 
*/

            /// <summary>
            /// 0x458 System.Collections.Generic.List<System.Single> BookStorageRateLvAddRate
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BookStorageRateLvAddRate", "System.Collections.Generic.List<System.Single>")]
            public static partial nint BOOK_STORAGE_RATE_LV_ADD_RATE { get; set; } 
*/

            /// <summary>
            /// 0x460 System.Collections.Generic.List<System.Int32> SkillBreakThroughDay
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillBreakThroughDay", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint SKILL_BREAK_THROUGH_DAY { get; set; } 
*/

            /// <summary>
            /// 0x468 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> SkillObstacleLv
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillObstacleLv", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
            public static partial nint SKILL_OBSTACLE_LV { get; set; } 
*/

            /// <summary>
            /// 0x470 System.Collections.Generic.List<System.Single> BreakThroughRareRate
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BreakThroughRareRate", "System.Collections.Generic.List<System.Single>")]
            public static partial nint BREAK_THROUGH_RARE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x478 System.Collections.Generic.List<System.Int32> AvailableBeardID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AvailableBeardID", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint AVAILABLE_BEARD_ID { get; set; } 
*/

            /// <summary>
            /// 0x480 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> NoRandomMaleFaceID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NoRandomMaleFaceID", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
            public static partial nint NO_RANDOM_MALE_FACE_ID { get; set; } 
*/

            /// <summary>
            /// 0x488 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> NoRandomFemaleFaceID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NoRandomFemaleFaceID", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
            public static partial nint NO_RANDOM_FEMALE_FACE_ID { get; set; } 
*/

            /// <summary>
            /// 0x490 System.Collections.Generic.List<System.Collections.Generic.List<System.String>> CheckReplaceSpeEffectList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.String>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CheckReplaceSpeEffectList", "System.Collections.Generic.List<System.Collections.Generic.List<System.String>>")]
            public static partial nint CHECK_REPLACE_SPE_EFFECT_LIST { get; set; } 
*/

            /// <summary>
            /// 0x498 System.Collections.Generic.List<System.String> FavorLvText
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FavorLvText", "System.Collections.Generic.List<System.String>")]
            public static partial nint FAVOR_LV_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x4A0 System.Collections.Generic.List<System.Single> CenterBuildingUpgradePeopleLimit
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CenterBuildingUpgradePeopleLimit", "System.Collections.Generic.List<System.Single>")]
            public static partial nint CENTER_BUILDING_UPGRADE_PEOPLE_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x4A8 System.Collections.Generic.List<System.Single> CenterBuildingUpgradeHeroLimit
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CenterBuildingUpgradeHeroLimit", "System.Collections.Generic.List<System.Single>")]
            public static partial nint CENTER_BUILDING_UPGRADE_HERO_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x4B0 System.Collections.Generic.List<System.Int32> StudyNewSkillCostFavor
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("StudyNewSkillCostFavor", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint STUDY_NEW_SKILL_COST_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x4B8 System.Collections.Generic.List<System.Int32> TeachNewSkillAddFavor
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TeachNewSkillAddFavor", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint TEACH_NEW_SKILL_ADD_FAVOR { get; set; } 
*/

            /// <summary>
            /// 0x4C0 UnityEngine.Quaternion leftRotation
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Quaternion"]
            /// </summary>
            /// <returns>struct UnityEngine.Quaternion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("leftRotation", "UnityEngine.Quaternion")]
            public static partial UnityEngine.Quaternion LEFT_ROTATION { get; set; } 
*/

            /// <summary>
            /// 0x4D0 System.Collections.Generic.List<System.Single> BattleTypeAutoGetExpRate
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleTypeAutoGetExpRate", "System.Collections.Generic.List<System.Single>")]
            public static partial nint BATTLE_TYPE_AUTO_GET_EXP_RATE { get; set; } 
*/

            /// <summary>
            /// 0x4D8 System.Collections.Generic.List<System.Single> BattleTypeGetFameRate
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleTypeGetFameRate", "System.Collections.Generic.List<System.Single>")]
            public static partial nint BATTLE_TYPE_GET_FAME_RATE { get; set; } 
*/

            /// <summary>
            /// 0x4E0 UnityEngine.AudioSource heroSoundAudioSource
            /// class ["UnityEngine.AudioModule.dll"."UnityEngine"."AudioSource"]
            /// </summary>
            /// <returns>class UnityEngine.AudioSource</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroSoundAudioSource", "UnityEngine.AudioSource")]
            public static partial nint HERO_SOUND_AUDIO_SOURCE { get; set; } 
*/

            /// <summary>
            /// 0x4E8 UnityEngine.Color[] amountColors
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Color[]"]
            /// </summary>
            /// <returns>class UnityEngine.Color[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("amountColors", "UnityEngine.Color[]")]
            public static partial nint AMOUNT_COLORS { get; set; } 
*/

            /// <summary>
            /// 0x4F0 System.Collections.Generic.List<System.Int32> CheckSpeForceIcon
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CheckSpeForceIcon", "System.Collections.Generic.List<System.Int32>")]
            public static partial nint CHECK_SPE_FORCE_ICON { get; set; } 
*/

            /// <summary>
            /// 0x4F8 System.Collections.Generic.List<System.String> CheckHideTag
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CheckHideTag", "System.Collections.Generic.List<System.String>")]
            public static partial nint CHECK_HIDE_TAG { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GlobalData"]
        /// </summary>
        partial struct Ptr_GlobalData
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
            /// static  UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "prefab">class UnityEngine.GameObject</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddChild", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 1)]
            public static partial nint ADD_CHILD(nint parent, nint prefab); 
*/
            /// <summary>
            /// static  UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab, System.Boolean autoAbove)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "prefab">class UnityEngine.GameObject</param>
            /// <param name = "autoAbove">struct System.Boolean</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddChild", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint ADD_CHILD(nint parent, nint prefab, System.Boolean autoAbove); 
*/
            /// <summary>
            /// static  UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab, UnityEngine.Vector3 localScale, System.Boolean autoAbove)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "prefab">class UnityEngine.GameObject</param>
            /// <param name = "localScale">struct UnityEngine.Vector3</param>
            /// <param name = "autoAbove">struct System.Boolean</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddChild", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public static partial nint ADD_CHILD(nint parent, nint prefab, UnityEngine.Vector3 localScale, System.Boolean autoAbove); 
*/
            /// <summary>
            /// static  UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab, UnityEngine.Vector3 localPosition)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "prefab">class UnityEngine.GameObject</param>
            /// <param name = "localPosition">struct UnityEngine.Vector3</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddChild", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            public static partial nint ADD_CHILD(nint parent, nint prefab, UnityEngine.Vector3 localPosition); 
*/
            /// <summary>
            /// static  UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab, UnityEngine.Vector3 localPosition, UnityEngine.Vector3 localScale)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "prefab">class UnityEngine.GameObject</param>
            /// <param name = "localPosition">struct UnityEngine.Vector3</param>
            /// <param name = "localScale">struct UnityEngine.Vector3</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddChild", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 3)]
            public static partial nint ADD_CHILD(nint parent, nint prefab, UnityEngine.Vector3 localPosition, UnityEngine.Vector3 localScale); 
*/
            /// <summary>
            /// static  UnityEngine.GameObject AddSprite(UnityEngine.GameObject parent, System.String objName, UnityEngine.Sprite sprite, System.Nullable<UnityEngine.Vector3> localPosition, System.Nullable<UnityEngine.Vector3> localScale)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "objName">class System.String</param>
            /// <param name = "sprite">class UnityEngine.Sprite</param>
            /// <param name = "localPosition">struct System.Nullable<UnityEngine.Vector3></param>
            /// <param name = "localScale">struct System.Nullable<UnityEngine.Vector3></param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSprite", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Sprite", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<UnityEngine.Vector3>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Nullable<UnityEngine.Vector3>", 4)]
            public static partial nint ADD_SPRITE(nint parent, nint objName, nint sprite, System.Nullable<UnityEngine.Vector3> localPosition, System.Nullable<UnityEngine.Vector3> localScale); 
*/
            /// <summary>
            /// static  System.Void AutoSetWindowResolution()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoSetWindowResolution", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void AUTO_SET_WINDOW_RESOLUTION(); 
*/
            /// <summary>
            /// static  System.Single CaculateWinRate(HeroData hero0, HeroData hero1, System.Boolean includeTeamMate)
            /// </summary>
            /// <param name = "hero0">class HeroData</param>
            /// <param name = "hero1">class HeroData</param>
            /// <param name = "includeTeamMate">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CaculateWinRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial System.Single CACULATE_WIN_RATE(nint hero0, nint hero1, System.Boolean includeTeamMate); 
*/
            /// <summary>
            /// static  System.Single CaculateWinRate(System.Single team0FightScore, System.Single team1FightScore)
            /// </summary>
            /// <param name = "team0FightScore">struct System.Single</param>
            /// <param name = "team1FightScore">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CaculateWinRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial System.Single CACULATE_WIN_RATE(System.Single team0FightScore, System.Single team1FightScore); 
*/
            /// <summary>
            /// static  System.Int32 CaculateWinTeam(System.Single team0FightScore, System.Single team1FightScore)
            /// </summary>
            /// <param name = "team0FightScore">struct System.Single</param>
            /// <param name = "team1FightScore">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CaculateWinTeam", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial System.Int32 CACULATE_WIN_TEAM(System.Single team0FightScore, System.Single team1FightScore); 
*/
            /// <summary>
            /// static  System.Boolean CheckNeedHideTag(System.String tagName)
            /// </summary>
            /// <param name = "tagName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNeedHideTag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial System.Boolean CHECK_NEED_HIDE_TAG(nint tagName); 
*/
            /// <summary>
            /// static  System.String ConvertNumToChinese(System.Int32 input)
            /// </summary>
            /// <param name = "input">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertNumToChinese", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint CONVERT_NUM_TO_CHINESE(System.Int32 input); 
*/
            /// <summary>
            /// static  System.Single CountArmorDamageRate(System.Single armor)
            /// </summary>
            /// <param name = "armor">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CountArmorDamageRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial System.Single COUNT_ARMOR_DAMAGE_RATE(System.Single armor); 
*/
            /// <summary>
            /// static  System.Void DeleteAllChild(UnityEngine.GameObject targetObj)
            /// </summary>
            /// <param name = "targetObj">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteAllChild", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public static partial void DELETE_ALL_CHILD(nint targetObj); 
*/
            /// <summary>
            /// static  System.Void DeleteAllNull(System.Collections.Generic.List<UnityEngine.GameObject> targetObj)
            /// </summary>
            /// <param name = "targetObj">class System.Collections.Generic.List<UnityEngine.GameObject></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteAllNull", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.GameObject>", 0)]
            public static partial void DELETE_ALL_NULL(nint targetObj); 
*/
            /// <summary>
            /// static  System.Void DestroyAll(System.Collections.Generic.List<UnityEngine.GameObject> targetObj)
            /// </summary>
            /// <param name = "targetObj">class System.Collections.Generic.List<UnityEngine.GameObject></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.GameObject>", 0)]
            public static partial void DESTROY_ALL(nint targetObj); 
*/
            /// <summary>
            /// static  System.Void DoTweenSkeletonAlpha(Spine.Unity.SkeletonAnimation targetSkeleton, System.Single startAlpha, System.Single targetAlpha, System.Single time)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <param name = "startAlpha">struct System.Single</param>
            /// <param name = "targetAlpha">struct System.Single</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoTweenSkeletonAlpha", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public static partial void DO_TWEEN_SKELETON_ALPHA(nint targetSkeleton, System.Single startAlpha, System.Single targetAlpha, System.Single time); 
*/
            /// <summary>
            /// static  System.Void DoTweenTextValue(UnityEngine.UI.Text targetText, System.Single targetValue, System.Single time)
            /// </summary>
            /// <param name = "targetText">class UnityEngine.UI.Text</param>
            /// <param name = "targetValue">struct System.Single</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoTweenTextValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.UI.Text", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial void DO_TWEEN_TEXT_VALUE(nint targetText, System.Single targetValue, System.Single time); 
*/
            /// <summary>
            /// static  System.String GenerateChangeColorText(System.String name, System.Single num)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "num">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateChangeColorText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial nint GENERATE_CHANGE_COLOR_TEXT(nint name, System.Single num); 
*/
            /// <summary>
            /// static  System.String GenerateChangeColorText(System.String name, System.Single num, System.Boolean reverse)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "reverse">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateChangeColorText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint GENERATE_CHANGE_COLOR_TEXT(nint name, System.Single num, System.Boolean reverse); 
*/
            /// <summary>
            /// static  System.String GenerateRareLvColorText(System.String text, System.Int32 rareLv)
            /// </summary>
            /// <param name = "text">class System.String</param>
            /// <param name = "rareLv">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateRareLvColorText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GENERATE_RARE_LV_COLOR_TEXT(nint text, System.Int32 rareLv); 
*/
            /// <summary>
            /// static  Spine.Unity.SkeletonAnimation GenerateSkeletonAnimation(UnityEngine.GameObject _parent, System.String _resourceName, UnityEngine.Vector3 _scale, System.String _anim, System.Boolean _loop, System.String _skin)
            /// </summary>
            /// <param name = "_parent">class UnityEngine.GameObject</param>
            /// <param name = "_resourceName">class System.String</param>
            /// <param name = "_scale">struct UnityEngine.Vector3</param>
            /// <param name = "_anim">class System.String</param>
            /// <param name = "_loop">struct System.Boolean</param>
            /// <param name = "_skin">class System.String</param>
            /// <returns>class Spine.Unity.SkeletonAnimation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateSkeletonAnimation", "Spine.Unity.SkeletonAnimation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 5)]
            public static partial nint GENERATE_SKELETON_ANIMATION(nint _parent, nint _resourceName, UnityEngine.Vector3 _scale, nint _anim, System.Boolean _loop, nint _skin); 
*/
            /// <summary>
            /// static  Spine.Unity.SkeletonAnimation GenerateSkeletonAnimation(UnityEngine.GameObject _parent, Spine.Unity.SkeletonDataAsset _skeletonDataAsset, UnityEngine.Vector3 _scale, System.String _anim, System.Boolean _loop, System.String _skin)
            /// </summary>
            /// <param name = "_parent">class UnityEngine.GameObject</param>
            /// <param name = "_skeletonDataAsset">class Spine.Unity.SkeletonDataAsset</param>
            /// <param name = "_scale">struct UnityEngine.Vector3</param>
            /// <param name = "_anim">class System.String</param>
            /// <param name = "_loop">struct System.Boolean</param>
            /// <param name = "_skin">class System.String</param>
            /// <returns>class Spine.Unity.SkeletonAnimation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateSkeletonAnimation", "Spine.Unity.SkeletonAnimation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonDataAsset", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 5)]
            public static partial nint GENERATE_SKELETON_ANIMATION(nint _parent, nint _skeletonDataAsset, UnityEngine.Vector3 _scale, nint _anim, System.Boolean _loop, nint _skin); 
*/
            /// <summary>
            /// static  Spine.Unity.SkeletonGraphic GenerateSkeletonGraphic(UnityEngine.GameObject _parent, System.String _resourceName, UnityEngine.Vector3 _scale, System.String _anim, System.Boolean _loop, System.String _skin)
            /// </summary>
            /// <param name = "_parent">class UnityEngine.GameObject</param>
            /// <param name = "_resourceName">class System.String</param>
            /// <param name = "_scale">struct UnityEngine.Vector3</param>
            /// <param name = "_anim">class System.String</param>
            /// <param name = "_loop">struct System.Boolean</param>
            /// <param name = "_skin">class System.String</param>
            /// <returns>class Spine.Unity.SkeletonGraphic</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateSkeletonGraphic", "Spine.Unity.SkeletonGraphic", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 5)]
            public static partial nint GENERATE_SKELETON_GRAPHIC(nint _parent, nint _resourceName, UnityEngine.Vector3 _scale, nint _anim, System.Boolean _loop, nint _skin); 
*/
            /// <summary>
            /// static  Spine.Unity.SkeletonGraphic GenerateSkeletonGraphic(UnityEngine.GameObject _parent, Spine.Unity.SkeletonDataAsset _skeletonDataAsset, UnityEngine.Vector3 _scale, System.String _anim, System.Boolean _loop, System.String _skin)
            /// </summary>
            /// <param name = "_parent">class UnityEngine.GameObject</param>
            /// <param name = "_skeletonDataAsset">class Spine.Unity.SkeletonDataAsset</param>
            /// <param name = "_scale">struct UnityEngine.Vector3</param>
            /// <param name = "_anim">class System.String</param>
            /// <param name = "_loop">struct System.Boolean</param>
            /// <param name = "_skin">class System.String</param>
            /// <returns>class Spine.Unity.SkeletonGraphic</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateSkeletonGraphic", "Spine.Unity.SkeletonGraphic", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonDataAsset", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 5)]
            public static partial nint GENERATE_SKELETON_GRAPHIC(nint _parent, nint _skeletonDataAsset, UnityEngine.Vector3 _scale, nint _anim, System.Boolean _loop, nint _skin); 
*/
            /// <summary>
            /// static  UnityEngine.Color GetAmountColor(System.Single val, System.Single alpha)
            /// </summary>
            /// <param name = "val">struct System.Single</param>
            /// <param name = "alpha">struct System.Single</param>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAmountColor", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Color GET_AMOUNT_COLOR(System.Single val, System.Single alpha); 
*/
            /// <summary>
            /// static  System.Int32 GetAttriLv(System.Single targetNum)
            /// </summary>
            /// <param name = "targetNum">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttriLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial System.Int32 GET_ATTRI_LV(System.Single targetNum); 
*/
            /// <summary>
            /// static  System.String GetBaseAttriName(BaseAttriType targetAttri)
            /// </summary>
            /// <param name = "targetAttri">enum BaseAttriType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseAttriName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseAttriType", 0)]
            public static partial nint GET_BASE_ATTRI_NAME(BaseAttriType targetAttri); 
*/
            /// <summary>
            /// static  System.String GetChaosText(System.Single chaos)
            /// </summary>
            /// <param name = "chaos">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChaosText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial nint GET_CHAOS_TEXT(System.Single chaos); 
*/
            /// <summary>
            /// static  System.String GetChinese(System.String targetText)
            /// </summary>
            /// <param name = "targetText">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChinese", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial nint GET_CHINESE(nint targetText); 
*/
            /// <summary>
            /// static  System.Char GetChineseNumText(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Char</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChineseNumText", "System.Char", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Char GET_CHINESE_NUM_TEXT(System.Int32 id); 
*/
            /// <summary>
            /// static  System.String GetDifficultyStarString(System.Single difficulty)
            /// </summary>
            /// <param name = "difficulty">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDifficultyStarString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial nint GET_DIFFICULTY_STAR_STRING(System.Single difficulty); 
*/
            /// <summary>
            /// static  System.String GetEvilText(System.Single evil)
            /// </summary>
            /// <param name = "evil">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEvilText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial nint GET_EVIL_TEXT(System.Single evil); 
*/
            /// <summary>
            /// static  System.String GetFavorText(System.Single favor)
            /// </summary>
            /// <param name = "favor">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFavorText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial nint GET_FAVOR_TEXT(System.Single favor); 
*/
            /// <summary>
            /// static  System.String GetForceFavorLvText(System.Single favorNum)
            /// </summary>
            /// <param name = "favorNum">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceFavorLvText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial nint GET_FORCE_FAVOR_LV_TEXT(System.Single favorNum); 
*/
            /// <summary>
            /// static  System.String GetForceIconName(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceIconName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_FORCE_ICON_NAME(System.Int32 id); 
*/
            /// <summary>
            /// static  System.Int32 GetGovernSalary(System.Int32 lv)
            /// </summary>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGovernSalary", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Int32 GET_GOVERN_SALARY(System.Int32 lv); 
*/
            /// <summary>
            /// static  System.String GetHobbyString(System.Int32 hobby)
            /// </summary>
            /// <param name = "hobby">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHobbyString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_HOBBY_STRING(System.Int32 hobby); 
*/
            /// <summary>
            /// static  System.String GetInjuryIconName(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInjuryIconName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_INJURY_ICON_NAME(System.Int32 id); 
*/
            /// <summary>
            /// static  System.String GetItemTypeString(System.Int32 type, System.Int32 littleType)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "littleType">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemTypeString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_ITEM_TYPE_STRING(System.Int32 type, System.Int32 littleType); 
*/
            /// <summary>
            /// static  System.String GetItemTypeString(ItemType type, System.Int32 littleType)
            /// </summary>
            /// <param name = "type">enum ItemType</param>
            /// <param name = "littleType">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemTypeString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_ITEM_TYPE_STRING(ItemType type, System.Int32 littleType); 
*/
            /// <summary>
            /// static  System.Boolean GetKey(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            public static partial System.Boolean GET_KEY(UnityEngine.KeyCode key); 
*/
            /// <summary>
            /// static  System.Boolean GetKeyDown(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyDown", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            public static partial System.Boolean GET_KEY_DOWN(UnityEngine.KeyCode key); 
*/
            /// <summary>
            /// static  System.Boolean GetKeyUp(UnityEngine.KeyCode key)
            /// </summary>
            /// <param name = "key">enum UnityEngine.KeyCode</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKeyUp", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.KeyCode", 0)]
            public static partial System.Boolean GET_KEY_UP(UnityEngine.KeyCode key); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<HeroData> GetMaxForceLvHero(System.Collections.Generic.List<HeroData> source, System.Int32 maxNum)
            /// </summary>
            /// <param name = "source">class System.Collections.Generic.List<HeroData></param>
            /// <param name = "maxNum">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxForceLvHero", "System.Collections.Generic.List<HeroData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<HeroData>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_MAX_FORCE_LV_HERO(nint source, System.Int32 maxNum); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<HeroData> GetMaxForceLvHero(System.Collections.Generic.List<HeroData> source, System.Int32 maxNum, System.Int32 maxLv)
            /// </summary>
            /// <param name = "source">class System.Collections.Generic.List<HeroData></param>
            /// <param name = "maxNum">struct System.Int32</param>
            /// <param name = "maxLv">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxForceLvHero", "System.Collections.Generic.List<HeroData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<HeroData>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public static partial nint GET_MAX_FORCE_LV_HERO(nint source, System.Int32 maxNum, System.Int32 maxLv); 
*/
            /// <summary>
            /// static  System.String GetNumText(System.Int32 num)
            /// </summary>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNumText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_NUM_TEXT(System.Int32 num); 
*/
            /// <summary>
            /// static  System.Int32 GetRandomBreakThroughRateLv(System.Int32 skillRareLv)
            /// </summary>
            /// <param name = "skillRareLv">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomBreakThroughRateLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Int32 GET_RANDOM_BREAK_THROUGH_RATE_LV(System.Int32 skillRareLv); 
*/
            /// <summary>
            /// static  System.String GetRequireTypeText(ChoiceRequirementType targetType)
            /// </summary>
            /// <param name = "targetType">enum ChoiceRequirementType</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRequireTypeText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ChoiceRequirementType", 0)]
            public static partial nint GET_REQUIRE_TYPE_TEXT(ChoiceRequirementType targetType); 
*/
            /// <summary>
            /// static  System.String GetResourceDescribe(System.Collections.Generic.List<ResourceData> resourceDatas, ResourceDescribeType describeType, System.Boolean newLine)
            /// </summary>
            /// <param name = "resourceDatas">class System.Collections.Generic.List<ResourceData></param>
            /// <param name = "describeType">enum ResourceDescribeType</param>
            /// <param name = "newLine">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourceDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourceDescribeType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint GET_RESOURCE_DESCRIBE(nint resourceDatas, ResourceDescribeType describeType, System.Boolean newLine); 
*/
            /// <summary>
            /// static  System.String GetResourceDescribe(System.Collections.Generic.List<ResourceData> resourceDatas)
            /// </summary>
            /// <param name = "resourceDatas">class System.Collections.Generic.List<ResourceData></param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourceDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
            public static partial nint GET_RESOURCE_DESCRIBE(nint resourceDatas); 
*/
            /// <summary>
            /// static  System.String GetResourceDescribe(System.Collections.Generic.List<System.Single> resourceDatas, ResourceDescribeType describeType, System.Boolean newLine)
            /// </summary>
            /// <param name = "resourceDatas">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "describeType">enum ResourceDescribeType</param>
            /// <param name = "newLine">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourceDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourceDescribeType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint GET_RESOURCE_DESCRIBE(nint resourceDatas, ResourceDescribeType describeType, System.Boolean newLine); 
*/
            /// <summary>
            /// static  System.String GetResourceDescribe(System.Collections.Generic.List<System.Single> resourceDatas)
            /// </summary>
            /// <param name = "resourceDatas">class System.Collections.Generic.List<System.Single></param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourceDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            public static partial nint GET_RESOURCE_DESCRIBE(nint resourceDatas); 
*/
            /// <summary>
            /// static  System.String GetResourceDescribe(ResourceData resourceData)
            /// </summary>
            /// <param name = "resourceData">class ResourceData</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourceDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourceData", 0)]
            public static partial nint GET_RESOURCE_DESCRIBE(nint resourceData); 
*/
            /// <summary>
            /// static  System.Single GetResourceTotalValue(System.Collections.Generic.List<ResourceData> resources)
            /// </summary>
            /// <param name = "resources">class System.Collections.Generic.List<ResourceData></param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourceTotalValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
            public static partial System.Single GET_RESOURCE_TOTAL_VALUE(nint resources); 
*/
            /// <summary>
            /// static  System.Single GetTotalFightScore(System.Collections.Generic.List<HeroData> heroList, System.Boolean includeTeamMate)
            /// </summary>
            /// <param name = "heroList">class System.Collections.Generic.List<HeroData></param>
            /// <param name = "includeTeamMate">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalFightScore", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<HeroData>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial System.Single GET_TOTAL_FIGHT_SCORE(nint heroList, System.Boolean includeTeamMate); 
*/
            /// <summary>
            /// static  System.String InsertEnter(System.String input)
            /// </summary>
            /// <param name = "input">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InsertEnter", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial nint INSERT_ENTER(nint input); 
*/
            /// <summary>
            /// static  System.String InsertFormat(System.String input, System.Int32 interval, System.String value)
            /// </summary>
            /// <param name = "input">class System.String</param>
            /// <param name = "interval">struct System.Int32</param>
            /// <param name = "value">class System.String</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InsertFormat", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public static partial nint INSERT_FORMAT(nint input, System.Int32 interval, nint value); 
*/
            /// <summary>
            /// static  System.Boolean IsInputing()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInputing", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean IS_INPUTING(); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<System.Single> ListAdd(System.Collections.Generic.List<System.Single> a, System.Collections.Generic.List<System.Single> b)
            /// </summary>
            /// <param name = "a">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "b">class System.Collections.Generic.List<System.Single></param>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListAdd", "System.Collections.Generic.List<System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 1)]
            public static partial nint LIST_ADD(nint a, nint b); 
*/
            /// <summary>
            /// static  System.Void ListAddTo(System.Collections.Generic.List<System.Single> a, System.Collections.Generic.List<System.Single> b)
            /// </summary>
            /// <param name = "a">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "b">class System.Collections.Generic.List<System.Single></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListAddTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 1)]
            public static partial void LIST_ADD_TO(nint a, nint b); 
*/
            /// <summary>
            /// static  System.Single ListAverage(System.Collections.Generic.List<System.Int32> targetList)
            /// </summary>
            /// <param name = "targetList">class System.Collections.Generic.List<System.Int32></param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListAverage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 0)]
            public static partial System.Single LIST_AVERAGE(nint targetList); 
*/
            /// <summary>
            /// static  System.Boolean ListContain(System.Collections.Generic.List<System.Int32> ListFather, System.Collections.Generic.List<System.Int32> ListSon)
            /// </summary>
            /// <param name = "ListFather">class System.Collections.Generic.List<System.Int32></param>
            /// <param name = "ListSon">class System.Collections.Generic.List<System.Int32></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListContain", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 1)]
            public static partial System.Boolean LIST_CONTAIN(nint ListFather, nint ListSon); 
*/
            /// <summary>
            /// static  System.Boolean ListEqual(System.Collections.Generic.List<System.Int32> list1, System.Collections.Generic.List<System.Int32> list2)
            /// </summary>
            /// <param name = "list1">class System.Collections.Generic.List<System.Int32></param>
            /// <param name = "list2">class System.Collections.Generic.List<System.Int32></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListEqual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 1)]
            public static partial System.Boolean LIST_EQUAL(nint list1, nint list2); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<System.Single> ListMinus(System.Collections.Generic.List<System.Single> a, System.Collections.Generic.List<System.Single> b)
            /// </summary>
            /// <param name = "a">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "b">class System.Collections.Generic.List<System.Single></param>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListMinus", "System.Collections.Generic.List<System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 1)]
            public static partial nint LIST_MINUS(nint a, nint b); 
*/
            /// <summary>
            /// static  System.Void ListMinusTo(System.Collections.Generic.List<System.Single> a, System.Collections.Generic.List<System.Single> b)
            /// </summary>
            /// <param name = "a">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "b">class System.Collections.Generic.List<System.Single></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListMinusTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 1)]
            public static partial void LIST_MINUS_TO(nint a, nint b); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<System.Single> ListMulti(System.Collections.Generic.List<System.Single> a, System.Single b)
            /// </summary>
            /// <param name = "a">class System.Collections.Generic.List<System.Single></param>
            /// <param name = "b">struct System.Single</param>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListMulti", "System.Collections.Generic.List<System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial nint LIST_MULTI(nint a, System.Single b); 
*/
            /// <summary>
            /// static  System.Void ListRandomRemove(System.Collections.Generic.List<System.Int32> targetList, System.Int32 num)
            /// </summary>
            /// <param name = "targetList">class System.Collections.Generic.List<System.Int32></param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ListRandomRemove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial void LIST_RANDOM_REMOVE(nint targetList, System.Int32 num); 
*/
            /// <summary>
            /// static  UnityEngine.Vector2 LoadVector2(System.String vector2String)
            /// </summary>
            /// <param name = "vector2String">class System.String</param>
            /// <returns>struct UnityEngine.Vector2</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadVector2", "UnityEngine.Vector2", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public static partial UnityEngine.Vector2 LOAD_VECTOR2(nint vector2String); 
*/
            /// <summary>
            /// static  System.Void MakeUIPixelPerfect(UnityEngine.GameObject target)
            /// </summary>
            /// <param name = "target">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MakeUIPixelPerfect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public static partial void MAKE_UI_PIXEL_PERFECT(nint target); 
*/
            /// <summary>
            /// static  System.Int32 ManageHeroAutoFight(FightMatchCouple fightMatchCouple, BattleType battleType, System.Single attackTeamScoreRate)
            /// </summary>
            /// <param name = "fightMatchCouple">class FightMatchCouple</param>
            /// <param name = "battleType">enum BattleType</param>
            /// <param name = "attackTeamScoreRate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageHeroAutoFight", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FightMatchCouple", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BattleType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial System.Int32 MANAGE_HERO_AUTO_FIGHT(nint fightMatchCouple, BattleType battleType, System.Single attackTeamScoreRate); 
*/
            /// <summary>
            /// static  System.Int32 ManageHeroAutoFight(FightMatchCouple fightMatchCouple, BattleType battleType, System.Boolean includeTeamMate, System.Single attackTeamScoreRate)
            /// </summary>
            /// <param name = "fightMatchCouple">class FightMatchCouple</param>
            /// <param name = "battleType">enum BattleType</param>
            /// <param name = "includeTeamMate">struct System.Boolean</param>
            /// <param name = "attackTeamScoreRate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageHeroAutoFight", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FightMatchCouple", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BattleType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public static partial System.Int32 MANAGE_HERO_AUTO_FIGHT(nint fightMatchCouple, BattleType battleType, System.Boolean includeTeamMate, System.Single attackTeamScoreRate); 
*/
            /// <summary>
            /// static  UnityEngine.AudioSource PlayHeroSound(UnityEngine.AudioClip clip, System.Single volume, System.Single pitch)
            /// </summary>
            /// <param name = "clip">class UnityEngine.AudioClip</param>
            /// <param name = "volume">struct System.Single</param>
            /// <param name = "pitch">struct System.Single</param>
            /// <returns>class UnityEngine.AudioSource</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayHeroSound", "UnityEngine.AudioSource", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.AudioClip", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public static partial nint PLAY_HERO_SOUND(nint clip, System.Single volume, System.Single pitch); 
*/
            /// <summary>
            /// static  System.Single RandomRange(System.Single minValue, System.Single maxValue)
            /// </summary>
            /// <param name = "minValue">struct System.Single</param>
            /// <param name = "maxValue">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomRange", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial System.Single RANDOM_RANGE(System.Single minValue, System.Single maxValue); 
*/
            /// <summary>
            /// static  System.Int32 RandomRange(System.Int32 minValue, System.Int32 maxValue)
            /// </summary>
            /// <param name = "minValue">struct System.Int32</param>
            /// <param name = "maxValue">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomRange", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial System.Int32 RANDOM_RANGE(System.Int32 minValue, System.Int32 maxValue); 
*/
            /// <summary>
            /// static  System.Double RandomRangeDouble()
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomRangeDouble", "System.Double", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Double RANDOM_RANGE_DOUBLE(); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<System.String> RemoveEmptyString(System.Collections.Generic.List<System.String> targetList)
            /// </summary>
            /// <param name = "targetList">class System.Collections.Generic.List<System.String></param>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveEmptyString", "System.Collections.Generic.List<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            public static partial nint REMOVE_EMPTY_STRING(nint targetList); 
*/
            /// <summary>
            /// static  System.String ReplaceSpeString(System.String targetText, System.Int32 sourceHeroID)
            /// </summary>
            /// <param name = "targetText">class System.String</param>
            /// <param name = "sourceHeroID">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReplaceSpeString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint REPLACE_SPE_STRING(nint targetText, System.Int32 sourceHeroID); 
*/
            /// <summary>
            /// static  UnityEngine.Color SetColorAlpha(UnityEngine.Color target, System.Single alpha)
            /// </summary>
            /// <param name = "target">struct UnityEngine.Color</param>
            /// <param name = "alpha">struct System.Single</param>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetColorAlpha", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Color SET_COLOR_ALPHA(UnityEngine.Color target, System.Single alpha); 
*/
            /// <summary>
            /// static  System.Void SetFullScreen(System.Boolean fullScreen)
            /// </summary>
            /// <param name = "fullScreen">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetFullScreen", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial void SET_FULL_SCREEN(System.Boolean fullScreen); 
*/
            /// <summary>
            /// static  System.Void SetParticleColor(UnityEngine.GameObject particle, UnityEngine.Color targetColor)
            /// </summary>
            /// <param name = "particle">class UnityEngine.GameObject</param>
            /// <param name = "targetColor">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetParticleColor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 1)]
            public static partial void SET_PARTICLE_COLOR(nint particle, UnityEngine.Color targetColor); 
*/
            /// <summary>
            /// static  System.Void SetResolution(System.Int32 width, System.Int32 height, System.Boolean fullScreen)
            /// </summary>
            /// <param name = "width">struct System.Int32</param>
            /// <param name = "height">struct System.Int32</param>
            /// <param name = "fullScreen">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetResolution", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial void SET_RESOLUTION(System.Int32 width, System.Int32 height, System.Boolean fullScreen); 
*/
            /// <summary>
            /// static  System.Void SetSkeletonAnimationFromRandomStart(Spine.Unity.SkeletonAnimation skeletonAnimation, System.Int32 trackID, System.String animationName, System.Boolean loop)
            /// </summary>
            /// <param name = "skeletonAnimation">class Spine.Unity.SkeletonAnimation</param>
            /// <param name = "trackID">struct System.Int32</param>
            /// <param name = "animationName">class System.String</param>
            /// <param name = "loop">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonAnimationFromRandomStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public static partial void SET_SKELETON_ANIMATION_FROM_RANDOM_START(nint skeletonAnimation, System.Int32 trackID, nint animationName, System.Boolean loop); 
*/
            /// <summary>
            /// static  System.Void SetSkeletonAnimationFromRandomStart(Spine.Unity.SkeletonGraphic skeletonAnimation, System.Int32 trackID, System.String animationName, System.Boolean loop)
            /// </summary>
            /// <param name = "skeletonAnimation">class Spine.Unity.SkeletonGraphic</param>
            /// <param name = "trackID">struct System.Int32</param>
            /// <param name = "animationName">class System.String</param>
            /// <param name = "loop">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonAnimationFromRandomStart", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonGraphic", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public static partial void SET_SKELETON_ANIMATION_FROM_RANDOM_START(nint skeletonAnimation, System.Int32 trackID, nint animationName, System.Boolean loop); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 SetZ(UnityEngine.Vector3 target, System.Single zPos)
            /// </summary>
            /// <param name = "target">struct UnityEngine.Vector3</param>
            /// <param name = "zPos">struct System.Single</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetZ", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial UnityEngine.Vector3 SET_Z(UnityEngine.Vector3 target, System.Single zPos); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 SetZToZero(UnityEngine.Vector3 target)
            /// </summary>
            /// <param name = "target">struct UnityEngine.Vector3</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetZToZero", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public static partial UnityEngine.Vector3 SET_Z_TO_ZERO(UnityEngine.Vector3 target); 
*/
            /// <summary>
            /// static  System.Int32 SortByName(UnityEngine.Transform a, UnityEngine.Transform b)
            /// </summary>
            /// <param name = "a">class UnityEngine.Transform</param>
            /// <param name = "b">class UnityEngine.Transform</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortByName", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial System.Int32 SORT_BY_NAME(nint a, nint b); 
*/
            /// <summary>
            /// static  System.Void SortChild(UnityEngine.GameObject parent)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortChild", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public static partial void SORT_CHILD(nint parent); 
*/
            /// <summary>
            /// static  System.Collections.Generic.List<HeroData> SortHeroList(System.Collections.Generic.List<HeroData> source, HeroListSortType sortType)
            /// </summary>
            /// <param name = "source">class System.Collections.Generic.List<HeroData></param>
            /// <param name = "sortType">enum HeroListSortType</param>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SortHeroList", "System.Collections.Generic.List<HeroData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<HeroData>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroListSortType", 1)]
            public static partial nint SORT_HERO_LIST(nint source, HeroListSortType sortType); 
*/
            /// <summary>
            /// static  UnityEngine.Vector3 TransformScreenDeltaToLocalDelta(UnityEngine.Vector2 delta, UnityEngine.GameObject targetObj)
            /// </summary>
            /// <param name = "delta">struct UnityEngine.Vector2</param>
            /// <param name = "targetObj">class UnityEngine.GameObject</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TransformScreenDeltaToLocalDelta", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector2", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 1)]
            public static partial UnityEngine.Vector3 TRANSFORM_SCREEN_DELTA_TO_LOCAL_DELTA(UnityEngine.Vector2 delta, nint targetObj); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}