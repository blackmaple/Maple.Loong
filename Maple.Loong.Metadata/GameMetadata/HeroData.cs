using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HeroData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HeroData>, Ptr_HeroData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "HeroData", "HeroData")]
    public partial class HeroData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HeroData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HeroData(System.IntPtr ptr) => new Ptr_HeroData(ptr);
            public static implicit operator System.IntPtr(Ptr_HeroData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_HeroData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroData"]
        /// </summary>
        partial struct Ptr_HeroData
        {
            ///// <summary>
            ///// 0x10 System.Boolean isSummon
            ///// struct ["mscorlib.dll"."System"."Boolean"]
            ///// </summary>
            ///// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isSummon", "System.Boolean")]
            //public partial ref System.Boolean IS_SUMMON { get; }


            ///// <summary>
            ///// 0x14 System.Single summonID
            ///// struct ["mscorlib.dll"."System"."Single"]
            ///// </summary>
            ///// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonID", "System.Single")]
            //public partial ref System.Single SUMMON_ID { get; }


            ///// <summary>
            ///// 0x18 System.Single summonLv
            ///// struct ["mscorlib.dll"."System"."Single"]
            ///// </summary>
            ///// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonLv", "System.Single")]
            //public partial ref System.Single SUMMON_LV { get; }


            ///// <summary>
            ///// 0x1C System.Int32 summonMoveRange
            ///// struct ["mscorlib.dll"."System"."Int32"]
            ///// </summary>
            ///// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonMoveRange", "System.Int32")]
            //public partial ref System.Int32 SUMMON_MOVE_RANGE { get; }


            ///// <summary>
            ///// 0x20 System.Boolean summonControlable
            ///// struct ["mscorlib.dll"."System"."Boolean"]
            ///// </summary>
            ///// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonControlable", "System.Boolean")]
            //public partial ref System.Boolean SUMMON_CONTROLABLE { get; }


            ///// <summary>
            ///// 0x21 System.Boolean interestingStar
            ///// struct ["mscorlib.dll"."System"."Boolean"]
            ///// </summary>
            ///// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("interestingStar", "System.Boolean")]
            //public partial ref System.Boolean INTERESTING_STAR { get; }


            ///// <summary>
            ///// 0x24 System.Single manageAiHour
            ///// struct ["mscorlib.dll"."System"."Single"]
            ///// </summary>
            ///// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("manageAiHour", "System.Single")]
            //public partial ref System.Single MANAGE_AI_HOUR { get; }


            ///// <summary>
            ///// 0x28 System.Boolean dailyAIManaged
            ///// struct ["mscorlib.dll"."System"."Boolean"]
            ///// </summary>
            ///// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dailyAIManaged", "System.Boolean")]
            //public partial ref System.Boolean DAILY_AI_MANAGED { get; }


            ///// <summary>
            ///// 0x30 HeroAIData heroAIData
            ///// class ["Assembly-CSharp.dll".""."HeroAIData"]
            ///// </summary>
            ///// <returns>class HeroAIData</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroAIData", "HeroAIData")]
            //public partial ref nint HERO_AI_DATA { get; }


            ///// <summary>
            ///// 0x38 HeroAIData heroAIDataArriveTargetRecord
            ///// class ["Assembly-CSharp.dll".""."HeroAIData"]
            ///// </summary>
            ///// <returns>class HeroAIData</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroAIDataArriveTargetRecord", "HeroAIData")]
            //public partial ref nint HERO_AI_DATA_ARRIVE_TARGET_RECORD { get; }


            ///// <summary>
            ///// 0x40 HeroAISettingData heroAISettingData
            ///// class ["Assembly-CSharp.dll".""."HeroAISettingData"]
            ///// </summary>
            ///// <returns>class HeroAISettingData</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroAISettingData", "HeroAISettingData")]
            //public partial ref nint HERO_AI_SETTING_DATA { get; }


            /// <summary>
            /// 0x48 System.Int32 heroID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroID", "System.Int32")]
            public partial ref System.Int32 HERO_ID { get; }


            // /// <summary>
            // /// 0x4C System.Boolean speHero
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            // [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speHero", "System.Boolean")]
            // public partial ref System.Boolean SPE_HERO { get; }


            // /// <summary>
            // /// 0x4D System.Boolean tempPlotHero
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            // [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tempPlotHero", "System.Boolean")]
            // public partial ref System.Boolean TEMP_PLOT_HERO { get; }


            // /// <summary>
            // /// 0x4E System.Boolean recruitAble
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            // [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("recruitAble", "System.Boolean")]
            // public partial ref System.Boolean RECRUIT_ABLE { get; }


            // /// <summary>
            // /// 0x4F System.Boolean loveAble
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            // [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("loveAble", "System.Boolean")]
            // public partial ref System.Boolean LOVE_ABLE { get; }


            // /// <summary>
            // /// 0x50 System.Boolean hide
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hide", "System.Boolean")]
            //public partial ref System.Boolean HIDE { get; } 


            // /// <summary>
            // /// 0x51 System.Boolean dead
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dead", "System.Boolean")]
            //public partial ref System.Boolean DEAD { get; } 


            /// <summary>
            /// 0x58 System.String heroName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroName", "System.String")]
            public partial ref PMonoString HERO_NAME { get; }


            /// <summary>
            /// 0x60 System.String heroFamilyName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroFamilyName", "System.String")]
            public partial ref PMonoString HERO_FAMILY_NAME { get; }


            /// <summary>
            /// 0x68 System.String heroNickName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroNickName", "System.String")]
            public partial ref PMonoString HERO_NICK_NAME { get; }


            // /// <summary>
            // /// 0x70 System.Boolean isFemale
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isFemale", "System.Boolean")]
            //public partial ref System.Boolean IS_FEMALE { get; } 


            // /// <summary>
            // /// 0x74 System.Int32 belongForceID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("belongForceID", "System.Int32")]
            //public partial ref System.Int32 BELONG_FORCE_ID { get; } 


            // /// <summary>
            // /// 0x78 System.Int32 skillForceID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillForceID", "System.Int32")]
            //public partial ref System.Int32 SKILL_FORCE_ID { get; } 


            // /// <summary>
            // /// 0x7C System.Boolean outsideForce
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("outsideForce", "System.Boolean")]
            //public partial ref System.Boolean OUTSIDE_FORCE { get; } 


            // /// <summary>
            // /// 0x80 System.Int32 forceJobType
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceJobType", "System.Int32")]
            //public partial ref System.Int32 FORCE_JOB_TYPE { get; } 


            // /// <summary>
            // /// 0x84 System.Int32 forceJobID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceJobID", "System.Int32")]
            //public partial ref System.Int32 FORCE_JOB_ID { get; } 


            // /// <summary>
            // /// 0x88 System.Single thisMonthContribution
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisMonthContribution", "System.Single")]
            //public partial ref System.Single THIS_MONTH_CONTRIBUTION { get; } 


            // /// <summary>
            // /// 0x8C System.Single lastMonthContribution
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastMonthContribution", "System.Single")]
            //public partial ref System.Single LAST_MONTH_CONTRIBUTION { get; } 


            // /// <summary>
            // /// 0x90 System.Single thisYearContribution
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("thisYearContribution", "System.Single")]
            //public partial ref System.Single THIS_YEAR_CONTRIBUTION { get; } 


            // /// <summary>
            // /// 0x94 System.Single lastYearContribution
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastYearContribution", "System.Single")]
            //public partial ref System.Single LAST_YEAR_CONTRIBUTION { get; } 


            // /// <summary>
            // /// 0x98 System.Single lastFightContribution
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastFightContribution", "System.Single")]
            //public partial ref System.Single LAST_FIGHT_CONTRIBUTION { get; } 


            // /// <summary>
            // /// 0x9C System.Boolean isLeader
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isLeader", "System.Boolean")]
            //public partial ref System.Boolean IS_LEADER { get; } 


            // /// <summary>
            // /// 0xA0 System.Int32 heroForceLv
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroForceLv", "System.Int32")]
            //public partial ref System.Int32 HERO_FORCE_LV { get; } 


            // /// <summary>
            // /// 0xA4 System.Single heroStrengthLv
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroStrengthLv", "System.Single")]
            //public partial ref System.Single HERO_STRENGTH_LV { get; } 


            // /// <summary>
            // /// 0xA8 System.Int32 atAreaID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("atAreaID", "System.Int32")]
            //public partial ref System.Int32 AT_AREA_ID { get; } 


            // /// <summary>
            // /// 0xB0 BigMapPos bigMapPos
            // /// class ["Assembly-CSharp.dll".""."BigMapPos"]
            // /// </summary>
            // /// <returns>class BigMapPos</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bigMapPos", "BigMapPos")]
            //public partial ref nint BIG_MAP_POS { get; } 


            // /// <summary>
            // /// 0xB8 System.Boolean inSafeArea
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("inSafeArea", "System.Boolean")]
            //public partial ref System.Boolean IN_SAFE_AREA { get; } 


            // /// <summary>
            // /// 0xB9 System.Boolean inPrison
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("inPrison", "System.Boolean")]
            //public partial ref System.Boolean IN_PRISON { get; } 


            /// <summary>
            /// 0xBC System.Int32 age
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("age", "System.Int32")]
            public partial ref System.Int32 AGE { get; }


            // /// <summary>
            // /// 0xC0 System.Int32 generation
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("generation", "System.Int32")]
            //public partial ref System.Int32 GENERATION { get; } 


            // /// <summary>
            // /// 0xC4 System.Single voicePitch
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("voicePitch", "System.Single")]
            //public partial ref System.Single VOICE_PITCH { get; } 


            // /// <summary>
            // /// 0xC8 HeroFaceData faceData
            // /// class ["Assembly-CSharp.dll".""."HeroFaceData"]
            // /// </summary>
            // /// <returns>class HeroFaceData</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("faceData", "HeroFaceData")]
            //public partial ref nint FACE_DATA { get; } 


            // /// <summary>
            // /// 0xD0 System.Single skinColorDark
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinColorDark", "System.Single")]
            //public partial ref System.Single SKIN_COLOR_DARK { get; } 


            // /// <summary>
            // /// 0xD4 System.Int32 defaultSkinID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defaultSkinID", "System.Int32")]
            //public partial ref System.Int32 DEFAULT_SKIN_ID { get; } 


            // /// <summary>
            // /// 0xD8 System.Int32 skinID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinID", "System.Int32")]
            //public partial ref System.Int32 SKIN_ID { get; } 


            // /// <summary>
            // /// 0xDC System.Int32 skinLv
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinLv", "System.Int32")]
            //public partial ref System.Int32 SKIN_LV { get; } 


            // /// <summary>
            // /// 0xE0 System.Int32 changeSkinCd
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("changeSkinCd", "System.Int32")]
            //public partial ref System.Int32 CHANGE_SKIN_CD { get; } 


            // /// <summary>
            // /// 0xE4 System.Boolean playerSetSkin
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerSetSkin", "System.Boolean")]
            //public partial ref System.Boolean PLAYER_SET_SKIN { get; } 


            // /// <summary>
            // /// 0xE8 System.Int32 setSkinID
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("setSkinID", "System.Int32")]
            //public partial ref System.Int32 SET_SKIN_ID { get; } 


            // /// <summary>
            // /// 0xEC System.Int32 setSkinLv
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("setSkinLv", "System.Int32")]
            //public partial ref System.Int32 SET_SKIN_LV { get; } 


            // /// <summary>
            // /// 0xF0 System.Collections.Generic.List<System.Int32> kungfuSkillFocus
            // /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            // /// </summary>
            // /// <returns>class System.Collections.Generic.List<System.Int32></returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kungfuSkillFocus", "System.Collections.Generic.List<System.Int32>")]
            //public partial ref nint KUNGFU_SKILL_FOCUS { get; } 


            // /// <summary>
            // /// 0xF8 System.Collections.Generic.List<System.Int32> livingSkillFocus
            // /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            // /// </summary>
            // /// <returns>class System.Collections.Generic.List<System.Int32></returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("livingSkillFocus", "System.Collections.Generic.List<System.Int32>")]
            //public partial ref nint LIVING_SKILL_FOCUS { get; } 


            /// <summary>
            /// 0x100 System.Collections.Generic.List<System.String> goodKungfuSkillName
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("goodKungfuSkillName", "System.Collections.Generic.List<System.String>")]
            //public partial ref nint GOOD_KUNGFU_SKILL_NAME { get; } 


            /// <summary>
            /// 0x108 System.Collections.Generic.List<System.Int32> preferWeaponType
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("preferWeaponType", "System.Collections.Generic.List<System.Int32>")]
            //public partial ref nint PREFER_WEAPON_TYPE { get; } 


            /// <summary>
            /// 0x110 System.Boolean haveMeet
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveMeet", "System.Boolean")]
            //public partial ref System.Boolean HAVE_MEET { get; } 


            /// <summary>
            /// 0x114 System.Single favor
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("favor", "System.Single")]
            //public partial ref System.Single FAVOR { get; } 


            /// <summary>
            /// 0x118 System.Collections.Generic.List<System.Single> baseAttri
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("baseAttri", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> BASE_ATTRI { get; }


            /// <summary>
            /// 0x120 System.Collections.Generic.List<System.Single> maxAttri
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxAttri", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> MAX_ATTRI { get; }


            /// <summary>
            /// 0x128 System.Collections.Generic.List<System.Single> totalAttri
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalAttri", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> TOTAL_ATTRI { get; }


            /// <summary>
            /// 0x130 System.Collections.Generic.List<System.Single> baseFightSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("baseFightSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> BASE_FIGHT_SKILL { get; }


            /// <summary>
            /// 0x138 System.Collections.Generic.List<System.Single> maxFightSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxFightSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> MAX_FIGHT_SKILL { get; }


            /// <summary>
            /// 0x140 System.Collections.Generic.List<System.Single> totalFightSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalFightSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> TOTAL_FIGHT_SKILL { get; }


            /// <summary>
            /// 0x148 System.Collections.Generic.List<System.Single> baseLivingSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("baseLivingSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> BASE_LIVING_SKILL { get; }


            /// <summary>
            /// 0x150 System.Collections.Generic.List<System.Single> maxLivingSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxLivingSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> MAX_LIVING_SKILL { get; }


            /// <summary>
            /// 0x158 System.Collections.Generic.List<System.Single> totalLivingSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalLivingSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> TOTAL_LIVING_SKILL { get; }


            /// <summary>
            /// 0x160 System.Collections.Generic.List<System.Single> expLivingSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("expLivingSkill", "System.Collections.Generic.List<System.Single>")]
            public partial SysPtrList<Single> EXP_LIVING_SKILL { get; }


            // /// <summary>
            // /// 0x168 System.Single hp
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Single")]
            public partial ref System.Single HP { get; }


            // /// <summary>
            // /// 0x16C System.Single maxhp
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxhp", "System.Single")]
            public partial ref System.Single MAXHP { get; }


            // /// <summary>
            // /// 0x170 System.Single realMaxHp
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("realMaxHp", "System.Single")]
            public partial ref System.Single REAL_MAX_HP { get; }


            // /// <summary>
            // /// 0x174 System.Single power
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("power", "System.Single")]
            public partial ref System.Single POWER { get; }


            // /// <summary>
            // /// 0x178 System.Single maxPower
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxPower", "System.Single")]
            public partial ref System.Single MAX_POWER { get; }


            // /// <summary>
            // /// 0x17C System.Single realMaxPower
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("realMaxPower", "System.Single")]
            public partial ref System.Single REAL_MAX_POWER { get; }


            /// <summary>
            /// 0x180 System.Single mana
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mana", "System.Single")]
            public partial ref System.Single MANA { get; }


            /// <summary>
            /// 0x184 System.Single maxMana
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxMana", "System.Single")]
            public partial ref System.Single MAX_MANA { get; }


            /// <summary>
            /// 0x188 System.Single realMaxMana
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("realMaxMana", "System.Single")]
            public partial ref System.Single REAL_MAX_MANA { get; }


            /// <summary>
            /// 0x18C System.Single armor
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("armor", "System.Single")]
            public partial ref System.Single ARMOR { get; }


            /// <summary>
            /// 0x190 System.Single externalInjury
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("externalInjury", "System.Single")]
            public partial ref System.Single EXTERNAL_INJURY { get; }


            /// <summary>
            /// 0x194 System.Single internalInjury
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("internalInjury", "System.Single")]
            public partial ref System.Single INTERNAL_INJURY { get; }


            /// <summary>
            /// 0x198 System.Single poisonInjury
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("poisonInjury", "System.Single")]
            public partial ref System.Single POISON_INJURY { get; }


            // /// <summary>
            // /// 0x19C System.Boolean isGovern
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isGovern", "System.Boolean")]
            //public partial ref System.Boolean IS_GOVERN { get; } 


            // /// <summary>
            // /// 0x1A0 System.Int32 governLv
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("governLv", "System.Int32")]
            //public partial ref System.Int32 GOVERN_LV { get; } 


            // /// <summary>
            // /// 0x1A4 System.Single governContribution
            // /// struct ["mscorlib.dll"."System"."Single"]
            // /// </summary>
            // /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("governContribution", "System.Single")]
            //public partial ref System.Single GOVERN_CONTRIBUTION { get; } 


            // /// <summary>
            // /// 0x1A8 System.Boolean isHornord
            // /// struct ["mscorlib.dll"."System"."Boolean"]
            // /// </summary>
            // /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isHornord", "System.Boolean")]
            //public partial ref System.Boolean IS_HORNORD { get; } 


            // /// <summary>
            // /// 0x1AC System.Int32 hornorLv
            // /// struct ["mscorlib.dll"."System"."Int32"]
            // /// </summary>
            // /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hornorLv", "System.Int32")]
            //public partial ref System.Int32 HORNOR_LV { get; } 


            /// <summary>
            /// 0x1B0 System.Single forceContribution
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceContribution", "System.Single")]
            //public partial ref System.Single FORCE_CONTRIBUTION { get; } 


            /// <summary>
            /// 0x1B4 System.Single fame
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fame", "System.Single")]
            //public partial ref System.Single FAME { get; } 


            /// <summary>
            /// 0x1B8 System.Single badFame
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("badFame", "System.Single")]
            //public partial ref System.Single BAD_FAME { get; } 


            /// <summary>
            /// 0x1BC System.Single loyal
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("loyal", "System.Single")]
            //public partial ref System.Single LOYAL { get; } 


            /// <summary>
            /// 0x1C0 System.Single evil
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("evil", "System.Single")]
            //public partial ref System.Single EVIL { get; } 


            /// <summary>
            /// 0x1C4 System.Single chaos
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chaos", "System.Single")]
            //public partial ref System.Single CHAOS { get; } 


            /// <summary>
            /// 0x1C8 System.Int32 nature
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nature", "System.Int32")]
            //public partial ref System.Int32 NATURE { get; } 


            /// <summary>
            /// 0x1CC System.Int32 talent
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("talent", "System.Int32")]
            //public partial ref System.Int32 TALENT { get; } 


            /// <summary>
            /// 0x1D0 System.Collections.Generic.List<System.Int32> hobby
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hobby", "System.Collections.Generic.List<System.Int32>")]
            //public partial ref nint HOBBY { get; } 


            /// <summary>
            /// 0x1D8 System.Boolean rest
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rest", "System.Boolean")]
            //public partial ref System.Boolean REST { get; } 


            /// <summary>
            /// 0x1D9 System.Boolean cure
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cure", "System.Boolean")]
            //public partial ref System.Boolean CURE { get; } 


            /// <summary>
            /// 0x1DC System.Int32 salary
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("salary", "System.Int32")]
            //public partial ref System.Int32 SALARY { get; } 


            /// <summary>
            /// 0x1E0 System.Int32 population
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("population", "System.Int32")]
            //public partial ref System.Int32 POPULATION { get; } 


            /// <summary>
            /// 0x1E8 HeroEquipmentData nowEquipment
            /// class ["Assembly-CSharp.dll".""."HeroEquipmentData"]
            /// </summary>
            /// <returns>class HeroEquipmentData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nowEquipment", "HeroEquipmentData")]
           public partial ref nint NOW_EQUIPMENT { get; } 
*/

            /// <summary>
            /// 0x1F0 System.Int32 horseSaveRecord
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("horseSaveRecord", "System.Int32")]
            //public partial ref System.Int32 HORSE_SAVE_RECORD { get; } 


            /// <summary>
            /// 0x1F8 ItemData horse
            /// class ["Assembly-CSharp.dll".""."ItemData"]
            /// </summary>
            /// <returns>class ItemData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("horse", "ItemData")]
           public partial ref nint HORSE { get; } 
*/

            /// <summary>
            /// 0x200 System.Int32 horseArmorSaveRecord
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("horseArmorSaveRecord", "System.Int32")]
           public partial ref System.Int32 HORSE_ARMOR_SAVE_RECORD { get; } 
*/

            /// <summary>
            /// 0x208 ItemData horseArmor
            /// class ["Assembly-CSharp.dll".""."ItemData"]
            /// </summary>
            /// <returns>class ItemData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("horseArmor", "ItemData")]
           public partial ref nint HORSE_ARMOR { get; } 
*/

            /// <summary>
            /// 0x210 ItemListData itemListData
            /// class ["Assembly-CSharp.dll".""."ItemListData"]
            /// </summary>
            /// <returns>class ItemListData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemListData", "ItemListData")]
            public partial ItemListData.Ptr_ItemListData ITEM_LIST_DATA { get; }


            /// <summary>
            /// 0x218 ItemListData selfStorage
            /// class ["Assembly-CSharp.dll".""."ItemListData"]
            /// </summary>
            /// <returns>class ItemListData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selfStorage", "ItemListData")]
            public partial ItemListData.Ptr_ItemListData SELF_STORAGE { get; }


            /// <summary>
            /// 0x220 PartPostureData partPosture
            /// class ["Assembly-CSharp.dll".""."PartPostureData"]
            /// </summary>
            /// <returns>class PartPostureData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("partPosture", "PartPostureData")]
           public partial ref nint PART_POSTURE { get; } 
*/

            /// <summary>
            /// 0x228 System.Int32 selfCureTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selfCureTime", "System.Int32")]
           public partial ref System.Int32 SELF_CURE_TIME { get; } 
*/

            /// <summary>
            /// 0x22C System.Single restCureTotalRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("restCureTotalRate", "System.Single")]
           public partial ref System.Single REST_CURE_TOTAL_RATE { get; } 
*/

            /// <summary>
            /// 0x230 System.Single medResist
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("medResist", "System.Single")]
           public partial ref System.Single MED_RESIST { get; } 
*/

            /// <summary>
            /// 0x234 System.Boolean fightProtectTarget
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fightProtectTarget", "System.Boolean")]
           public partial ref System.Boolean FIGHT_PROTECT_TARGET { get; } 
*/

            /// <summary>
            /// 0x235 System.Boolean fightForceEnter
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fightForceEnter", "System.Boolean")]
           public partial ref System.Boolean FIGHT_FORCE_ENTER { get; } 
*/

            /// <summary>
            /// 0x238 System.Collections.Generic.List<SkillMaxPracticeExpData> skillMaxPracticeExpData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SkillMaxPracticeExpData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillMaxPracticeExpData", "System.Collections.Generic.List<SkillMaxPracticeExpData>")]
           public partial ref nint SKILL_MAX_PRACTICE_EXP_DATA { get; } 
*/

            /// <summary>
            /// 0x240 System.Collections.Generic.List<System.Int32> skillCount
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillCount", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint SKILL_COUNT { get; } 
*/

            /// <summary>
            /// 0x248 System.Collections.Generic.List<KungfuSkillLvData> kungfuSkills
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<KungfuSkillLvData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kungfuSkills", "System.Collections.Generic.List<KungfuSkillLvData>")]
            public partial SysPtrList<KungfuSkillLvData.Ptr_KungfuSkillLvData> KUNGFU_SKILLS { get; }


            /// <summary>
            /// 0x250 System.Int32 internalSkillSaveRecord
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("internalSkillSaveRecord", "System.Int32")]
           public partial ref System.Int32 INTERNAL_SKILL_SAVE_RECORD { get; } 
*/

            /// <summary>
            /// 0x258 KungfuSkillLvData internalSkill
            /// class ["Assembly-CSharp.dll".""."KungfuSkillLvData"]
            /// </summary>
            /// <returns>class KungfuSkillLvData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("internalSkill", "KungfuSkillLvData")]
           public partial ref nint INTERNAL_SKILL { get; } 
*/

            /// <summary>
            /// 0x260 System.Int32 dodgeSkillSaveRecord
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dodgeSkillSaveRecord", "System.Int32")]
           public partial ref System.Int32 DODGE_SKILL_SAVE_RECORD { get; } 
*/

            /// <summary>
            /// 0x268 KungfuSkillLvData dodgeSkill
            /// class ["Assembly-CSharp.dll".""."KungfuSkillLvData"]
            /// </summary>
            /// <returns>class KungfuSkillLvData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dodgeSkill", "KungfuSkillLvData")]
           public partial ref nint DODGE_SKILL { get; } 
*/

            /// <summary>
            /// 0x270 System.Int32 uniqueSkillSaveRecord
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("uniqueSkillSaveRecord", "System.Int32")]
           public partial ref System.Int32 UNIQUE_SKILL_SAVE_RECORD { get; } 
*/

            /// <summary>
            /// 0x278 KungfuSkillLvData uniqueSkill
            /// class ["Assembly-CSharp.dll".""."KungfuSkillLvData"]
            /// </summary>
            /// <returns>class KungfuSkillLvData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("uniqueSkill", "KungfuSkillLvData")]
           public partial ref nint UNIQUE_SKILL { get; } 
*/

            /// <summary>
            /// 0x280 System.Collections.Generic.List<System.Int32> attackSkillSaveRecord
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackSkillSaveRecord", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint ATTACK_SKILL_SAVE_RECORD { get; } 
*/

            /// <summary>
            /// 0x288 System.Collections.Generic.List<KungfuSkillLvData> attackSkills
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<KungfuSkillLvData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackSkills", "System.Collections.Generic.List<KungfuSkillLvData>")]
           public partial ref nint ATTACK_SKILLS { get; } 
*/

            /// <summary>
            /// 0x290 System.Int32 nowActiveSkill
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nowActiveSkill", "System.Int32")]
           public partial ref System.Int32 NOW_ACTIVE_SKILL { get; } 
*/

            /// <summary>
            /// 0x298 HeroSpeAddData baseAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("baseAddData", "HeroSpeAddData")]
           public partial ref nint BASE_ADD_DATA { get; } 
*/

            /// <summary>
            /// 0x2A0 HeroSpeAddData totalAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalAddData", "HeroSpeAddData")]
           public partial ref nint TOTAL_ADD_DATA { get; } 
*/

            /// <summary>
            /// 0x2A8 HeroSpeAddData heroBuff
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroBuff", "HeroSpeAddData")]
           public partial ref nint HERO_BUFF { get; } 
*/

            /// <summary>
            /// 0x2B0 System.Boolean heroDetailDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroDetailDirty", "System.Boolean")]
           public partial ref System.Boolean HERO_DETAIL_DIRTY { get; } 
*/

            /// <summary>
            /// 0x2B1 System.Boolean heroBuffDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroBuffDirty", "System.Boolean")]
           public partial ref System.Boolean HERO_BUFF_DIRTY { get; } 
*/

            /// <summary>
            /// 0x2B4 System.Int32 heroIconDirtyCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroIconDirtyCount", "System.Int32")]
           public partial ref System.Int32 HERO_ICON_DIRTY_COUNT { get; } 
*/

            /// <summary>
            /// 0x2B8 MissionData forceMission
            /// class ["Assembly-CSharp.dll".""."MissionData"]
            /// </summary>
            /// <returns>class MissionData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceMission", "MissionData")]
           public partial ref nint FORCE_MISSION { get; } 
*/

            /// <summary>
            /// 0x2C0 System.Collections.Generic.List<MissionData> missions
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<MissionData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("missions", "System.Collections.Generic.List<MissionData>")]
           public partial ref nint MISSIONS { get; } 
*/

            /// <summary>
            /// 0x2C8 System.Boolean inTeam
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("inTeam", "System.Boolean")]
           public partial ref System.Boolean IN_TEAM { get; } 
*/

            /// <summary>
            /// 0x2CC System.Int32 teamLeader
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("teamLeader", "System.Int32")]
           public partial ref System.Int32 TEAM_LEADER { get; } 
*/

            /// <summary>
            /// 0x2D0 System.Collections.Generic.List<System.Int32> teamMates
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("teamMates", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint TEAM_MATES { get; } 
*/

            /// <summary>
            /// 0x2D8 System.Int32 autoLeaveTeamDay
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("autoLeaveTeamDay", "System.Int32")]
           public partial ref System.Int32 AUTO_LEAVE_TEAM_DAY { get; } 
*/

            /// <summary>
            /// 0x2DC System.Boolean autoLeaveTeamDestroy
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("autoLeaveTeamDestroy", "System.Boolean")]
           public partial ref System.Boolean AUTO_LEAVE_TEAM_DESTROY { get; } 
*/

            /// <summary>
            /// 0x2DD System.Boolean bodyGuard
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bodyGuard", "System.Boolean")]
           public partial ref System.Boolean BODY_GUARD { get; } 
*/

            /// <summary>
            /// 0x2E0 PlayerInteractionTimeData playerInteractionTimeData
            /// class ["Assembly-CSharp.dll".""."PlayerInteractionTimeData"]
            /// </summary>
            /// <returns>class PlayerInteractionTimeData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerInteractionTimeData", "PlayerInteractionTimeData")]
           public partial ref nint PLAYER_INTERACTION_TIME_DATA { get; } 
*/

            /// <summary>
            /// 0x2E8 System.Int32 plotNumCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotNumCount", "System.Int32")]
           public partial ref System.Int32 PLOT_NUM_COUNT { get; } 
*/

            /// <summary>
            /// 0x2EC System.Int32 missionNumCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("missionNumCount", "System.Int32")]
           public partial ref System.Int32 MISSION_NUM_COUNT { get; } 
*/

            /// <summary>
            /// 0x2F0 System.Int32 Teacher
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Teacher", "System.Int32")]
           public partial ref System.Int32 TEACHER { get; } 
*/

            /// <summary>
            /// 0x2F8 System.Collections.Generic.List<System.Int32> Students
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Students", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint STUDENTS { get; } 
*/

            /// <summary>
            /// 0x300 System.Int32 Lover
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Lover", "System.Int32")]
           public partial ref System.Int32 LOVER { get; } 
*/

            /// <summary>
            /// 0x308 System.Collections.Generic.List<System.Int32> PreLovers
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PreLovers", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint PRE_LOVERS { get; } 
*/

            /// <summary>
            /// 0x310 System.Collections.Generic.List<System.Int32> Relatives
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Relatives", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint RELATIVES { get; } 
*/

            /// <summary>
            /// 0x318 System.Collections.Generic.List<System.Int32> Brothers
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Brothers", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint BROTHERS { get; } 
*/

            /// <summary>
            /// 0x320 System.Collections.Generic.List<System.Int32> Friends
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Friends", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint FRIENDS { get; } 
*/

            /// <summary>
            /// 0x328 System.Collections.Generic.List<System.Int32> Haters
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Haters", "System.Collections.Generic.List<System.Int32>")]
           public partial ref nint HATERS { get; } 
*/

            /// <summary>
            /// 0x330 System.Collections.Generic.List<System.String> recordLog
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("recordLog", "System.Collections.Generic.List<System.String>")]
           public partial ref nint RECORD_LOG { get; } 
*/

            /// <summary>
            /// 0x338 System.Single selfHouseTotalAdd
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selfHouseTotalAdd", "System.Single")]
           public partial ref System.Single SELF_HOUSE_TOTAL_ADD { get; } 
*/

            /// <summary>
            /// 0x33C System.Single heroTagPoint
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroTagPoint", "System.Single")]
            public partial ref System.Single HERO_TAG_POINT { get; }


            /// <summary>
            /// 0x340 System.Collections.Generic.List<HeroTagData> heroTagData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroTagData></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroTagData", "System.Collections.Generic.List<HeroTagData>")]
            public partial SysPtrList<HeroTagData.Ptr_HeroTagData> HERO_TAG_DATA { get; }


            /// <summary>
            /// 0x348 System.Boolean bookWriteWorking
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookWriteWorking", "System.Boolean")]
           public partial ref System.Boolean BOOK_WRITE_WORKING { get; } 
*/

            /// <summary>
            /// 0x349 System.Boolean wantRemove
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("wantRemove", "System.Boolean")]
           public partial ref System.Boolean WANT_REMOVE { get; } 
*/

            /// <summary>
            /// 0x34A System.Boolean isTempHero
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isTempHero", "System.Boolean")]
           public partial ref System.Boolean IS_TEMP_HERO { get; } 
*/

            /// <summary>
            /// 0x34B System.Boolean isRandomEnemy
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isRandomEnemy", "System.Boolean")]
           public partial ref System.Boolean IS_RANDOM_ENEMY { get; } 
*/

            /// <summary>
            /// 0x34C System.Boolean needRemove
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("needRemove", "System.Boolean")]
           public partial ref System.Boolean NEED_REMOVE { get; } 
*/

            /// <summary>
            /// 0x34D System.Boolean inWater
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("inWater", "System.Boolean")]
           public partial ref System.Boolean IN_WATER { get; } 
*/

            /// <summary>
            /// 0x34E System.Boolean inMountain
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("inMountain", "System.Boolean")]
           public partial ref System.Boolean IN_MOUNTAIN { get; } 
*/

            /// <summary>
            /// 0x34F System.Boolean inHill
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("inHill", "System.Boolean")]
           public partial ref System.Boolean IN_HILL { get; } 
*/

            /// <summary>
            /// 0x350 System.Single fightScore
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fightScore", "System.Single")]
           public partial ref System.Single FIGHT_SCORE { get; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroData"]
        /// </summary>
        partial struct Ptr_HeroData
        {
            /// <summary>
            /// static  System.Single GetExtraStateValueRate(System.Single statePercent)
            /// </summary>
            /// <param name = "statePercent">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExtraStateValueRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public static partial System.Single GET_EXTRA_STATE_VALUE_RATE(System.Single statePercent); 
*/
            /// <summary>
            /// static  System.Int32 GetHeroPopulation(System.Int32 _forceLv)
            /// </summary>
            /// <param name = "_forceLv">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroPopulation", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Int32 GET_HERO_POPULATION(System.Int32 _forceLv); 
*/
            /// <summary>
            /// static  System.Int32 GetHeroSalary(System.Int32 _forceLv)
            /// </summary>
            /// <param name = "_forceLv">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroSalary", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Int32 GET_HERO_SALARY(System.Int32 _forceLv); 
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
            ///   System.Boolean <RandomAttriAndSkill>b__443_0(System.Int32 i)
            /// </summary>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<RandomAttriAndSkill>b__443_0", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean RANDOM_ATTRI_AND_SKILLB__443_0(System.Int32 i); 
*/
            /// <summary>
            ///   System.Boolean <RandomAttriAndSkill>b__443_1(System.Int32 i)
            /// </summary>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<RandomAttriAndSkill>b__443_1", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean RANDOM_ATTRI_AND_SKILLB__443_1(System.Int32 i); 
*/
            /// <summary>
            ///   System.Void AddBrother(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddBrother", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_BROTHER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddBuff(System.Int32 id, System.Single time)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddBuff", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ADD_BUFF(System.Int32 id, System.Single time); 
*/
            /// <summary>
            ///   System.Void AddFriend(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddFriend", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_FRIEND(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddHater(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddHater", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_HATER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddLog(System.String newLog)
            /// </summary>
            /// <param name = "newLog">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddLog", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_LOG(nint newLog); 
*/
            /// <summary>
            ///   System.Void AddPrelover(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPrelover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_PRELOVER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddSkillBookExp(System.Single num, KungfuSkillLvData targetSkill, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSkillBookExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ADD_SKILL_BOOK_EXP(System.Single num, nint targetSkill, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddSkillFightExp(System.Single num, KungfuSkillLvData targetSkill, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSkillFightExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void ADD_SKILL_FIGHT_EXP(System.Single num, nint targetSkill, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddSkillMaxPracticeExp(SkillMaxPracticeExpData target)
            /// </summary>
            /// <param name = "target">class SkillMaxPracticeExpData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSkillMaxPracticeExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SkillMaxPracticeExpData", 0)]
            public partial void ADD_SKILL_MAX_PRACTICE_EXP(nint target); 
*/
            /// <summary>
            ///   System.Void AddStudent(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddStudent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ADD_STUDENT(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AddTag(System.Int32 id, System.Single time, System.String source, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "source">class System.String</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void ADD_TAG(System.Int32 id, System.Single time, nint source, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.String AtAreaName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AtAreaName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint AT_AREA_NAME(); 
*/
            /// <summary>
            ///   System.Boolean AttackSelfTeam()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AttackSelfTeam", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean ATTACK_SELF_TEAM(); 
*/
            /// <summary>
            ///   System.Boolean AttackSkillSlotUnlocked(System.Int32 skillSlotID)
            /// </summary>
            /// <param name = "skillSlotID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AttackSkillSlotUnlocked", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean ATTACK_SKILL_SLOT_UNLOCKED(System.Int32 skillSlotID); 
*/
            /// <summary>
            ///   System.Void AutoChangeLoyal()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoChangeLoyal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AUTO_CHANGE_LOYAL(); 
*/
            /// <summary>
            ///   System.Void AutoCureSelfInjury()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoCureSelfInjury", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AUTO_CURE_SELF_INJURY(); 
*/
            /// <summary>
            ///   System.Void AutoFightQuickChangeState(System.Single rate, System.Boolean showInfo)
            /// </summary>
            /// <param name = "rate">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoFightQuickChangeState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void AUTO_FIGHT_QUICK_CHANGE_STATE(System.Single rate, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void AutoGetFightExp()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoGetFightExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AUTO_GET_FIGHT_EXP(); 
*/
            /// <summary>
            ///   System.Void AutoGetFightExp(System.Single rate)
            /// </summary>
            /// <param name = "rate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoGetFightExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void AUTO_GET_FIGHT_EXP(System.Single rate); 
*/
            /// <summary>
            ///   System.Void AutoManageEquipPoison()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoManageEquipPoison", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AUTO_MANAGE_EQUIP_POISON(); 
*/
            /// <summary>
            ///   System.Void BattleChangeSkillFightExp(System.Single num, KungfuSkillLvData targetSkill, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BattleChangeSkillFightExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void BATTLE_CHANGE_SKILL_FIGHT_EXP(System.Single num, nint targetSkill, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Boolean CanMove()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanMove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_MOVE(); 
*/
            /// <summary>
            ///   System.Boolean CanPlayerMeet()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanPlayerMeet", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_PLAYER_MEET(); 
*/
            /// <summary>
            ///   System.Boolean CanUseAttackSkill()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanUseAttackSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_USE_ATTACK_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean CanUseSkill(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanUseSkill", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial System.Boolean CAN_USE_SKILL(nint targetSkill); 
*/
            /// <summary>
            ///   System.Void ChangeAttri(System.Int32 id, System.Single num, System.Boolean showText)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeAttri", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_ATTRI(System.Int32 id, System.Single num, System.Boolean showText); 
*/
            /// <summary>
            ///   System.Void ChangeAttriAndSkill(HeroSpeAddDataType speAddDataType, System.Single num, System.Single maxNum)
            /// </summary>
            /// <param name = "speAddDataType">enum HeroSpeAddDataType</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "maxNum">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeAttriAndSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddDataType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void CHANGE_ATTRI_AND_SKILL(HeroSpeAddDataType speAddDataType, System.Single num, System.Single maxNum); 
*/
            /// <summary>
            ///   System.Void ChangeBadFame(System.Single num, System.Boolean showInfo, HeroData targetHero)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeBadFame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 2)]
            public partial void CHANGE_BAD_FAME(System.Single num, System.Boolean showInfo, nint targetHero); 
*/
            /// <summary>
            ///   System.Single ChangeExternalInjury(System.Single num, System.Boolean showText, System.Boolean gainExp)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <param name = "gainExp">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeExternalInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.Single CHANGE_EXTERNAL_INJURY(System.Single num, System.Boolean showText, System.Boolean gainExp); 
*/
            /// <summary>
            ///   System.Void ChangeFame(System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeFame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_FAME(System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeFavor(System.Single num, System.Boolean showPopInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeFavor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_FAVOR(System.Single num, System.Boolean showPopInfo); 
*/
            /// <summary>
            ///   System.Void ChangeFightSkill(System.Int32 id, System.Single num, System.Boolean showText)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeFightSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_FIGHT_SKILL(System.Int32 id, System.Single num, System.Boolean showText); 
*/
            /// <summary>
            ///   System.Void ChangeForceContribution(System.Single num, System.Boolean showInfo, System.Int32 targetForce)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "targetForce">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeForceContribution", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void CHANGE_FORCE_CONTRIBUTION(System.Single num, System.Boolean showInfo, System.Int32 targetForce); 
*/
            /// <summary>
            ///   System.Void ChangeGovernContribution(System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeGovernContribution", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_GOVERN_CONTRIBUTION(System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeHeroForceLv(System.Int32 num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroForceLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_HERO_FORCE_LV(System.Int32 num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeHeroMissionResult(MissionTargetType missionTargetType, System.Single changeNum)
            /// </summary>
            /// <param name = "missionTargetType">enum MissionTargetType</param>
            /// <param name = "changeNum">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroMissionResult", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MissionTargetType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CHANGE_HERO_MISSION_RESULT(MissionTargetType missionTargetType, System.Single changeNum); 
*/
            /// <summary>
            ///   System.Void ChangeHeroMissionResult(MissionTargetType missionTargetType, System.String missionTargetID, System.Single changeNum)
            /// </summary>
            /// <param name = "missionTargetType">enum MissionTargetType</param>
            /// <param name = "missionTargetID">class System.String</param>
            /// <param name = "changeNum">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroMissionResult", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MissionTargetType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void CHANGE_HERO_MISSION_RESULT(MissionTargetType missionTargetType, nint missionTargetID, System.Single changeNum); 
*/
            /// <summary>
            ///   System.Void ChangeHeroMissionResult(MissionTargetType missionTargetType, System.Int32 resourceNeed, System.Single changeNum)
            /// </summary>
            /// <param name = "missionTargetType">enum MissionTargetType</param>
            /// <param name = "resourceNeed">struct System.Int32</param>
            /// <param name = "changeNum">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroMissionResult", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MissionTargetType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void CHANGE_HERO_MISSION_RESULT(MissionTargetType missionTargetType, System.Int32 resourceNeed, System.Single changeNum); 
*/
            /// <summary>
            ///   System.Void ChangeHeroMissionResult(MissionTargetType missionTargetType, System.String missionTargetID, System.Int32 resourceNeed, System.Single changeNum)
            /// </summary>
            /// <param name = "missionTargetType">enum MissionTargetType</param>
            /// <param name = "missionTargetID">class System.String</param>
            /// <param name = "resourceNeed">struct System.Int32</param>
            /// <param name = "changeNum">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroMissionResult", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MissionTargetType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void CHANGE_HERO_MISSION_RESULT(MissionTargetType missionTargetType, nint missionTargetID, System.Int32 resourceNeed, System.Single changeNum); 
*/
            /// <summary>
            ///   System.Void ChangeHeroMissionResult(MissionData targetMission, MissionTargetType missionTargetType, System.String missionTargetID, System.Int32 resourceNeed, System.Single changeNum)
            /// </summary>
            /// <param name = "targetMission">class MissionData</param>
            /// <param name = "missionTargetType">enum MissionTargetType</param>
            /// <param name = "missionTargetID">class System.String</param>
            /// <param name = "resourceNeed">struct System.Int32</param>
            /// <param name = "changeNum">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHeroMissionResult", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MissionData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MissionTargetType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 4)]
            public partial void CHANGE_HERO_MISSION_RESULT(nint targetMission, MissionTargetType missionTargetType, nint missionTargetID, System.Int32 resourceNeed, System.Single changeNum); 
*/
            /// <summary>
            ///   System.Void ChangeHp(System.Single num, System.Boolean useRecoverRate, System.Boolean noDead, System.Boolean needRefresh)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "useRecoverRate">struct System.Boolean</param>
            /// <param name = "noDead">struct System.Boolean</param>
            /// <param name = "needRefresh">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void CHANGE_HP(System.Single num, System.Boolean useRecoverRate, System.Boolean noDead, System.Boolean needRefresh); 
*/
            /// <summary>
            ///   System.Single ChangeInternalInjury(System.Single num, System.Boolean showText, System.Boolean gainExp)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <param name = "gainExp">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeInternalInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.Single CHANGE_INTERNAL_INJURY(System.Single num, System.Boolean showText, System.Boolean gainExp); 
*/
            /// <summary>
            ///   System.Void ChangeLivingSkill(System.Int32 id, System.Single num, System.Boolean showText)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeLivingSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_LIVING_SKILL(System.Int32 id, System.Single num, System.Boolean showText); 
*/
            /// <summary>
            ///   System.Void ChangeLivingSkillExp(System.Int32 id, System.Single num, System.Boolean showText)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeLivingSkillExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_LIVING_SKILL_EXP(System.Int32 id, System.Single num, System.Boolean showText); 
*/
            /// <summary>
            ///   System.Void ChangeLoyal(System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeLoyal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_LOYAL(System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeMana(System.Single num, System.Boolean useRecoverRate, System.Boolean needRefresh)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "useRecoverRate">struct System.Boolean</param>
            /// <param name = "needRefresh">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMana", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_MANA(System.Single num, System.Boolean useRecoverRate, System.Boolean needRefresh); 
*/
            /// <summary>
            ///   System.Void ChangeMaxAttri(System.Int32 id, System.Int32 num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMaxAttri", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_MAX_ATTRI(System.Int32 id, System.Int32 num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeMaxFightSkill(System.Int32 id, System.Int32 num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMaxFightSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_MAX_FIGHT_SKILL(System.Int32 id, System.Int32 num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeMaxHp(System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMaxHp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_MAX_HP(System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeMaxLivingSkill(System.Int32 id, System.Int32 num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMaxLivingSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_MAX_LIVING_SKILL(System.Int32 id, System.Int32 num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeMaxMana(System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMaxMana", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_MAX_MANA(System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeMaxPower(System.Single num)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMaxPower", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void CHANGE_MAX_POWER(System.Single num); 
*/
            /// <summary>
            ///   System.Void ChangeMoney(System.Int32 num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeMoney", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_MONEY(System.Int32 num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Single ChangePoisonInjury(System.Single num, System.Boolean showText, System.Boolean gainExp)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <param name = "gainExp">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangePoisonInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial System.Single CHANGE_POISON_INJURY(System.Single num, System.Boolean showText, System.Boolean gainExp); 
*/
            /// <summary>
            ///   System.Void ChangePower(System.Single num)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangePower", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void CHANGE_POWER(System.Single num); 
*/
            /// <summary>
            ///   System.Void ChangeRandomInjury(System.Single num, System.Boolean showText, System.Boolean gainExp)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showText">struct System.Boolean</param>
            /// <param name = "gainExp">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeRandomInjury", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_RANDOM_INJURY(System.Single num, System.Boolean showText, System.Boolean gainExp); 
*/
            /// <summary>
            ///   System.Void ChangeResource(System.Int32 id, System.Single num, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CHANGE_RESOURCE(System.Int32 id, System.Single num, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ChangeSelfHouseTotalAdd(System.Single delta)
            /// </summary>
            /// <param name = "delta">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeSelfHouseTotalAdd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void CHANGE_SELF_HOUSE_TOTAL_ADD(System.Single delta); 
*/
            /// <summary>
            ///   System.Void ChangeSkillPower(SkillChangePowerType skillChangePowerType, System.Single deltaPower)
            /// </summary>
            /// <param name = "skillChangePowerType">enum SkillChangePowerType</param>
            /// <param name = "deltaPower">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeSkillPower", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SkillChangePowerType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void CHANGE_SKILL_POWER(SkillChangePowerType skillChangePowerType, System.Single deltaPower); 
*/
            /// <summary>
            ///   System.Void ChangeTagPoint(System.Single delta, System.Boolean showInfo)
            /// </summary>
            /// <param name = "delta">struct System.Single</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeTagPoint", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CHANGE_TAG_POINT(System.Single delta, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void CheckForceJobDetailDirty(EquipmentData equipmentData)
            /// </summary>
            /// <param name = "equipmentData">class EquipmentData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckForceJobDetailDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipmentData", 0)]
            public partial void CHECK_FORCE_JOB_DETAIL_DIRTY(nint equipmentData); 
*/
            /// <summary>
            ///   System.Void CheckForceJobDetailDirty(HeroSpeAddData heroSpeAddData)
            /// </summary>
            /// <param name = "heroSpeAddData">class HeroSpeAddData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckForceJobDetailDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 0)]
            public partial void CHECK_FORCE_JOB_DETAIL_DIRTY(nint heroSpeAddData); 
*/
            /// <summary>
            ///   System.Void CheckForceJobDetailDirty(System.Int32 livingSkill)
            /// </summary>
            /// <param name = "livingSkill">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckForceJobDetailDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CHECK_FORCE_JOB_DETAIL_DIRTY(System.Int32 livingSkill); 
*/
            /// <summary>
            ///   System.Void CheckHeroDetailDirty(System.Boolean forceCount)
            /// </summary>
            /// <param name = "forceCount">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckHeroDetailDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_HERO_DETAIL_DIRTY(System.Boolean forceCount); 
*/
            /// <summary>
            ///   System.Void CheckPlayerMakeLoverUnhappy()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckPlayerMakeLoverUnhappy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_PLAYER_MAKE_LOVER_UNHAPPY(); 
*/
            /// <summary>
            ///   System.Void CheckSkillUpgrade(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckSkillUpgrade", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial void CHECK_SKILL_UPGRADE(nint targetSkill); 
*/
            /// <summary>
            ///   System.Void ClearAllTempTag()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearAllTempTag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_ALL_TEMP_TAG(); 
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
            ///   System.Boolean Controlable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Controlable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CONTROLABLE(); 
*/
            /// <summary>
            ///   System.Void CostResource(System.Collections.Generic.List<ResourceData> resourceList)
            /// </summary>
            /// <param name = "resourceList">class System.Collections.Generic.List<ResourceData></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<ResourceData>", 0)]
            public partial void COST_RESOURCE(nint resourceList); 
*/
            /// <summary>
            ///   System.Void CostResource(ResourceData resource)
            /// </summary>
            /// <param name = "resource">class ResourceData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ResourceData", 0)]
            public partial void COST_RESOURCE(nint resource); 
*/
            /// <summary>
            ///   System.Void CostResource(System.Int32 id, System.Single num)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void COST_RESOURCE(System.Int32 id, System.Single num); 
*/
            /// <summary>
            ///   System.Void DeadToAlive()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeadToAlive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void DEAD_TO_ALIVE(); 
*/
            /// <summary>
            ///   System.Void EquipHorse(ItemData itemData, System.Boolean playSound)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipHorse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void EQUIP_HORSE(nint itemData, System.Boolean playSound); 
*/
            /// <summary>
            ///   System.Void EquipItem(ItemData itemData, System.Boolean playSound, System.Boolean showInfo)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void EQUIP_ITEM(nint itemData, System.Boolean playSound, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void EquipSkill(KungfuSkillLvData skillLvData, System.Boolean playSound)
            /// </summary>
            /// <param name = "skillLvData">class KungfuSkillLvData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EquipSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void EQUIP_SKILL(nint skillLvData, System.Boolean playSound); 
*/
            /// <summary>
            ///   System.Single Favor()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Favor", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single FAVOR(); 
*/
            /// <summary>
            ///   System.Void FightReset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FightReset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void FIGHT_RESET(); 
*/
            /// <summary>
            ///   ItemData FindRandomItem(System.Int32 minItemLv, System.Int32 maxItemLv, System.Boolean includeEquipment, System.Int32 targetItemType)
            /// </summary>
            /// <param name = "minItemLv">struct System.Int32</param>
            /// <param name = "maxItemLv">struct System.Int32</param>
            /// <param name = "includeEquipment">struct System.Boolean</param>
            /// <param name = "targetItemType">struct System.Int32</param>
            /// <returns>class ItemData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindRandomItem", "ItemData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial nint FIND_RANDOM_ITEM(System.Int32 minItemLv, System.Int32 maxItemLv, System.Boolean includeEquipment, System.Int32 targetItemType); 
*/
            /// <summary>
            ///   KungfuSkillLvData FindRandomSkill(System.Int32 maxSkillRareLv, HeroData exclusiveHero)
            /// </summary>
            /// <param name = "maxSkillRareLv">struct System.Int32</param>
            /// <param name = "exclusiveHero">class HeroData</param>
            /// <returns>class KungfuSkillLvData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindRandomSkill", "KungfuSkillLvData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 1)]
            public partial nint FIND_RANDOM_SKILL(System.Int32 maxSkillRareLv, nint exclusiveHero); 
*/
            /// <summary>
            ///   ItemData FindSameBook(ItemData target)
            /// </summary>
            /// <param name = "target">class ItemData</param>
            /// <returns>class ItemData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindSameBook", "ItemData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial nint FIND_SAME_BOOK(nint target); 
*/
            /// <summary>
            ///   KungfuSkillLvData FindSkill(System.Int32 targetSkillID)
            /// </summary>
            /// <param name = "targetSkillID">struct System.Int32</param>
            /// <returns>class KungfuSkillLvData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindSkill", "KungfuSkillLvData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint FIND_SKILL(System.Int32 targetSkillID); 
*/
            /// <summary>
            ///   System.Void FullRecover(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FullRecover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void FULL_RECOVER(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Boolean FullState()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FullState", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean FULL_STATE(); 
*/
            /// <summary>
            ///   Spine.Unity.SkeletonAnimation GenerateHeroSkeleton(UnityEngine.GameObject parent, UnityEngine.Vector3 scale)
            /// </summary>
            /// <param name = "parent">class UnityEngine.GameObject</param>
            /// <param name = "scale">struct UnityEngine.Vector3</param>
            /// <returns>class Spine.Unity.SkeletonAnimation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateHeroSkeleton", "Spine.Unity.SkeletonAnimation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial nint GENERATE_HERO_SKELETON(nint parent, UnityEngine.Vector3 scale); 
*/
            /// <summary>
            ///   Spine.Unity.SkeletonAnimation GenerateHeroSkeleton(Spine.Unity.SkeletonAnimation skeleton)
            /// </summary>
            /// <param name = "skeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <returns>class Spine.Unity.SkeletonAnimation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GenerateHeroSkeleton", "Spine.Unity.SkeletonAnimation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            public partial nint GENERATE_HERO_SKELETON(nint skeleton); 
*/
            /// <summary>
            ///   System.Boolean get_HeroIconDirty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HeroIconDirty", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_HERO_ICON_DIRTY(); 
*/
            /// <summary>
            ///   System.Int32 GetAISettingFocus(AISettingType targetType)
            /// </summary>
            /// <param name = "targetType">enum AISettingType</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAISettingFocus", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("AISettingType", 0)]
            public partial System.Int32 GET_AI_SETTING_FOCUS(AISettingType targetType); 
*/
            /// <summary>
            ///   System.Int32 GetAISettingPriorityLv(AISettingType targetType)
            /// </summary>
            /// <param name = "targetType">enum AISettingType</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAISettingPriorityLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("AISettingType", 0)]
            public partial System.Int32 GET_AI_SETTING_PRIORITY_LV(AISettingType targetType); 
*/
            /// <summary>
            ///   AreaData GetArea()
            /// </summary>
            /// <returns>class AreaData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArea", "AreaData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_AREA(); 
*/
            /// <summary>
            ///   System.Int32 GetAreaID(System.Boolean includeNearArea)
            /// </summary>
            /// <param name = "includeNearArea">struct System.Boolean</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAreaID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial System.Int32 GET_AREA_ID(System.Boolean includeNearArea); 
*/
            /// <summary>
            ///   System.Single GetAttriRate(System.Int32 attriID)
            /// </summary>
            /// <param name = "attriID">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttriRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_ATTRI_RATE(System.Int32 attriID); 
*/
            /// <summary>
            ///   System.Single GetBadFameRate(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBadFameRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial System.Single GET_BAD_FAME_RATE(nint targetHero); 
*/
            /// <summary>
            ///   System.Single GetBaseAttriNum(BaseAttriType targetAttri)
            /// </summary>
            /// <param name = "targetAttri">enum BaseAttriType</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseAttriNum", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BaseAttriType", 0)]
            public partial System.Single GET_BASE_ATTRI_NUM(BaseAttriType targetAttri); 
*/
            /// <summary>
            ///   System.Single GetBaseMaxHp()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseMaxHp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_BASE_MAX_HP(); 
*/
            /// <summary>
            ///   System.Single GetBaseMaxMana()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseMaxMana", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_BASE_MAX_MANA(); 
*/
            /// <summary>
            ///   System.Int32 GetBodyGuardNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBodyGuardNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_BODY_GUARD_NUM(); 
*/
            /// <summary>
            ///   System.Single GetBookExpRate(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBookExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial System.Single GET_BOOK_EXP_RATE(nint targetSkill); 
*/
            /// <summary>
            ///   System.Void GetBounty(System.Int32 num, HeroData bountyTarget, System.Boolean showInfo)
            /// </summary>
            /// <param name = "num">struct System.Int32</param>
            /// <param name = "bountyTarget">class HeroData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBounty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void GET_BOUNTY(System.Int32 num, nint bountyTarget, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Int32 GetBountyMissionNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBountyMissionNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_BOUNTY_MISSION_NUM(); 
*/
            /// <summary>
            ///   System.Int32 GetBountyPirce()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBountyPirce", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_BOUNTY_PIRCE(); 
*/
            /// <summary>
            ///   System.Single GetDebateScore()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDebateScore", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_DEBATE_SCORE(); 
*/
            /// <summary>
            ///   System.Int32 GetDefaultSkinID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDefaultSkinID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_DEFAULT_SKIN_ID(); 
*/
            /// <summary>
            ///   System.Int32 GetEquipmentWeightLv()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEquipmentWeightLv", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_EQUIPMENT_WEIGHT_LV(); 
*/
            /// <summary>
            ///   System.Single GetExploreStepRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExploreStepRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_EXPLORE_STEP_RATE(); 
*/
            /// <summary>
            ///   System.Single GetExtraHpRecoverValueRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExtraHpRecoverValueRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_EXTRA_HP_RECOVER_VALUE_RATE(); 
*/
            /// <summary>
            ///   System.Single GetFameForceLv()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFameForceLv", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_FAME_FORCE_LV(); 
*/
            /// <summary>
            ///   System.Single GetFameRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFameRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_FAME_RATE(); 
*/
            /// <summary>
            ///   System.Single GetFavorRate(System.Single num)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFavorRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_FAVOR_RATE(System.Single num); 
*/
            /// <summary>
            ///   System.Single GetFavorValueRate(System.Boolean buy)
            /// </summary>
            /// <param name = "buy">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFavorValueRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial System.Single GET_FAVOR_VALUE_RATE(System.Boolean buy); 
*/
            /// <summary>
            ///   System.Single GetFightExpRate(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFightExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial System.Single GET_FIGHT_EXP_RATE(nint targetSkill); 
*/
            /// <summary>
            ///   System.Single GetFightScore(System.Boolean includeTeamMate)
            /// </summary>
            /// <param name = "includeTeamMate">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFightScore", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial System.Single GET_FIGHT_SCORE(System.Boolean includeTeamMate); 
*/
            /// <summary>
            ///   System.Int32 GetFightTime(HeroData enemyData)
            /// </summary>
            /// <param name = "enemyData">class HeroData</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFightTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial System.Int32 GET_FIGHT_TIME(nint enemyData); 
*/
            /// <summary>
            ///   System.Single GetFinalTravelSpeed()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFinalTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_FINAL_TRAVEL_SPEED(); 
*/
            /// <summary>
            ///   ForceData GetForce()
            /// </summary>
            /// <returns>class ForceData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForce", "ForceData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FORCE(); 
*/
            /// <summary>
            ///   System.Single GetForceBookStorageExpRate(System.Int32 skillID)
            /// </summary>
            /// <param name = "skillID">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceBookStorageExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_FORCE_BOOK_STORAGE_EXP_RATE(System.Int32 skillID); 
*/
            /// <summary>
            ///   System.Single GetForceJobEffectSkillNum()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceJobEffectSkillNum", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_FORCE_JOB_EFFECT_SKILL_NUM(); 
*/
            /// <summary>
            ///   System.Single GetForceJobEffectSkillNum(System.Int32 jobType, System.Int32 jobID)
            /// </summary>
            /// <param name = "jobType">struct System.Int32</param>
            /// <param name = "jobID">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceJobEffectSkillNum", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Single GET_FORCE_JOB_EFFECT_SKILL_NUM(System.Int32 jobType, System.Int32 jobID); 
*/
            /// <summary>
            ///   System.Single GetForceJobSpeAddResult(System.Int32 forceSpeAddDataType)
            /// </summary>
            /// <param name = "forceSpeAddDataType">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceJobSpeAddResult", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_FORCE_JOB_SPE_ADD_RESULT(System.Int32 forceSpeAddDataType); 
*/
            /// <summary>
            ///   HeroData GetForceLeader()
            /// </summary>
            /// <returns>class HeroData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceLeader", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FORCE_LEADER(); 
*/
            /// <summary>
            ///   System.Single GetForceStorageDiscount(ItemListData targetForceStorage)
            /// </summary>
            /// <param name = "targetForceStorage">class ItemListData</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForceStorageDiscount", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemListData", 0)]
            public partial System.Single GET_FORCE_STORAGE_DISCOUNT(nint targetForceStorage); 
*/
            /// <summary>
            ///   System.Int32 GetFullRecoverTime(System.Single baseRecoverRate)
            /// </summary>
            /// <param name = "baseRecoverRate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFullRecoverTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Int32 GET_FULL_RECOVER_TIME(System.Single baseRecoverRate); 
*/
            /// <summary>
            ///   System.Single GetGameDifficultyExpRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameDifficultyExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_GAME_DIFFICULTY_EXP_RATE(); 
*/
            /// <summary>
            ///   System.Single GetGameDifficultyFameRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGameDifficultyFameRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_GAME_DIFFICULTY_FAME_RATE(); 
*/
            /// <summary>
            ///   System.Single GetGovernExtraFameRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGovernExtraFameRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_GOVERN_EXTRA_FAME_RATE(); 
*/
            /// <summary>
            ///   System.Single GetGovernUpgradeCost()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetGovernUpgradeCost", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_GOVERN_UPGRADE_COST(); 
*/
            /// <summary>
            ///   UnityEngine.AudioClip GetHeroDieSound()
            /// </summary>
            /// <returns>class UnityEngine.AudioClip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroDieSound", "UnityEngine.AudioClip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_DIE_SOUND(); 
*/
            /// <summary>
            ///   System.String GetHeroForceLvDescribe(System.Boolean fullName)
            /// </summary>
            /// <param name = "fullName">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroForceLvDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_HERO_FORCE_LV_DESCRIBE(System.Boolean fullName); 
*/
            /// <summary>
            ///   System.String GetHeroForceLvDescribeSimplify()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroForceLvDescribeSimplify", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_FORCE_LV_DESCRIBE_SIMPLIFY(); 
*/
            /// <summary>
            ///   System.String GetHeroGovernName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroGovernName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_GOVERN_NAME(); 
*/
            /// <summary>
            ///   System.String GetHeroHornorName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroHornorName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_HORNOR_NAME(); 
*/
            /// <summary>
            ///   UnityEngine.AudioClip GetHeroHurtSound()
            /// </summary>
            /// <returns>class UnityEngine.AudioClip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroHurtSound", "UnityEngine.AudioClip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_HURT_SOUND(); 
*/
            /// <summary>
            ///   UnityEngine.AudioClip GetHeroLittleTalkSound()
            /// </summary>
            /// <returns>class UnityEngine.AudioClip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroLittleTalkSound", "UnityEngine.AudioClip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_LITTLE_TALK_SOUND(); 
*/
            /// <summary>
            ///   UnityEngine.AudioClip GetHeroMeetSound()
            /// </summary>
            /// <returns>class UnityEngine.AudioClip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroMeetSound", "UnityEngine.AudioClip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_MEET_SOUND(); 
*/
            /// <summary>
            ///   System.String GetHeroName(System.Boolean fullDescribe)
            /// </summary>
            /// <param name = "fullDescribe">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_HERO_NAME(System.Boolean fullDescribe); 
*/
            /// <summary>
            ///   System.Int32 GetHeroPermanentTagNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroPermanentTagNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HERO_PERMANENT_TAG_NUM(); 
*/
            /// <summary>
            ///   UnityEngine.AudioClip GetHeroRecoverSound()
            /// </summary>
            /// <returns>class UnityEngine.AudioClip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroRecoverSound", "UnityEngine.AudioClip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_RECOVER_SOUND(); 
*/
            /// <summary>
            ///   UnityEngine.AudioClip GetHeroShoutSound()
            /// </summary>
            /// <returns>class UnityEngine.AudioClip</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroShoutSound", "UnityEngine.AudioClip", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_SHOUT_SOUND(); 
*/
            /// <summary>
            ///   System.String GetHeroWeaponAttackAnim()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroWeaponAttackAnim", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HERO_WEAPON_ATTACK_ANIM(); 
*/
            /// <summary>
            ///   System.Int32 GetHitMoveRange()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHitMoveRange", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HIT_MOVE_RANGE(); 
*/
            /// <summary>
            ///   System.String GetHobbyDescribe()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHobbyDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HOBBY_DESCRIBE(); 
*/
            /// <summary>
            ///   System.Int32 GetHornorChangeMaxArea()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHornorChangeMaxArea", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HORNOR_CHANGE_MAX_AREA(); 
*/
            /// <summary>
            ///   System.Single GetHornorReduceBadFameRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHornorReduceBadFameRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HORNOR_REDUCE_BAD_FAME_RATE(); 
*/
            /// <summary>
            ///   System.Single GetHornorUpgradeCost()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHornorUpgradeCost", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HORNOR_UPGRADE_COST(); 
*/
            /// <summary>
            ///   System.Single GetHorseScore()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHorseScore", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HORSE_SCORE(); 
*/
            /// <summary>
            ///   System.Single GetHorseTravelSpeed()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHorseTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HORSE_TRAVEL_SPEED(); 
*/
            /// <summary>
            ///   System.Single GetHorseTravelSpeed(System.Boolean havePower, System.Boolean isSprint)
            /// </summary>
            /// <param name = "havePower">struct System.Boolean</param>
            /// <param name = "isSprint">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHorseTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Single GET_HORSE_TRAVEL_SPEED(System.Boolean havePower, System.Boolean isSprint); 
*/
            /// <summary>
            ///   System.Single GetHpPercent()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHpPercent", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_HP_PERCENT(); 
*/
            /// <summary>
            ///   System.Void GetItem(ItemListData _itemListData, System.Boolean showPopInfo, System.Boolean showSpeGetItem, System.Int32 treasureChestClickTime)
            /// </summary>
            /// <param name = "_itemListData">class ItemListData</param>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <param name = "showSpeGetItem">struct System.Boolean</param>
            /// <param name = "treasureChestClickTime">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemListData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void GET_ITEM(nint _itemListData, System.Boolean showPopInfo, System.Boolean showSpeGetItem, System.Int32 treasureChestClickTime); 
*/
            /// <summary>
            ///   System.Void GetItem(ItemData itemData, System.Boolean showPopInfo)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void GET_ITEM(nint itemData, System.Boolean showPopInfo); 
*/
            /// <summary>
            ///   System.Void GetItem(ItemData itemData, System.Boolean showPopInfo, System.Boolean showSpeGetItem, System.Int32 treasureChestClickTime, System.Boolean skipManageItemPoison)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <param name = "showSpeGetItem">struct System.Boolean</param>
            /// <param name = "treasureChestClickTime">struct System.Int32</param>
            /// <param name = "skipManageItemPoison">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial void GET_ITEM(nint itemData, System.Boolean showPopInfo, System.Boolean showSpeGetItem, System.Int32 treasureChestClickTime, System.Boolean skipManageItemPoison); 
*/
            /// <summary>
            ///   System.Single GetItemFavorValue(ItemData targetItem, System.Single maxLimit)
            /// </summary>
            /// <param name = "targetItem">class ItemData</param>
            /// <param name = "maxLimit">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemFavorValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Single GET_ITEM_FAVOR_VALUE(nint targetItem, System.Single maxLimit); 
*/
            /// <summary>
            ///   System.Single GetLivingSkillExpMax(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLivingSkillExpMax", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_LIVING_SKILL_EXP_MAX(System.Int32 id); 
*/
            /// <summary>
            ///   System.Single GetLoyalWorkRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLoyalWorkRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_LOYAL_WORK_RATE(); 
*/
            /// <summary>
            ///   System.Single GetManaPercent()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetManaPercent", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MANA_PERCENT(); 
*/
            /// <summary>
            ///   System.Single GetMaxAttri(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxAttri", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_MAX_ATTRI(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32 GetMaxBountyMissionNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxBountyMissionNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_BOUNTY_MISSION_NUM(); 
*/
            /// <summary>
            ///   System.Single GetMaxBuyValue(System.Single discount)
            /// </summary>
            /// <param name = "discount">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxBuyValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_MAX_BUY_VALUE(System.Single discount); 
*/
            /// <summary>
            ///   System.Int32 GetMaxDoctorTime()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxDoctorTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_DOCTOR_TIME(); 
*/
            /// <summary>
            ///   System.Single GetMaxFavor()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxFavor", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MAX_FAVOR(); 
*/
            /// <summary>
            ///   System.Single GetMaxFightSkill(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxFightSkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_MAX_FIGHT_SKILL(System.Int32 id); 
*/
            /// <summary>
            ///   System.Single GetMaxLivingSkill(System.Int32 id)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxLivingSkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_MAX_LIVING_SKILL(System.Int32 id); 
*/
            /// <summary>
            ///   System.Int32 GetMaxTeamMate()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxTeamMate", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MAX_TEAM_MATE(); 
*/
            /// <summary>
            ///   System.Single GetMeetNeedFame()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMeetNeedFame", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MEET_NEED_FAME(); 
*/
            /// <summary>
            ///   System.Int32 GetMissMeetingReduceContribution()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMissMeetingReduceContribution", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MISS_MEETING_REDUCE_CONTRIBUTION(); 
*/
            /// <summary>
            ///   System.Int32 GetMoveRange()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMoveRange", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_MOVE_RANGE(); 
*/
            /// <summary>
            ///   System.Single GetNatureFavorRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNatureFavorRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_NATURE_FAVOR_RATE(); 
*/
            /// <summary>
            ///   KungfuSkillLvData GetNowActiveSkill()
            /// </summary>
            /// <returns>class KungfuSkillLvData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNowActiveSkill", "KungfuSkillLvData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NOW_ACTIVE_SKILL(); 
*/
            /// <summary>
            ///   System.Single GetPostureCurePostureRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPostureCurePostureRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_POSTURE_CURE_POSTURE_RATE(); 
*/
            /// <summary>
            ///   System.Single GetPostureCurePower()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPostureCurePower", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_POSTURE_CURE_POWER(); 
*/
            /// <summary>
            ///   System.Single GetPostureValue()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPostureValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_POSTURE_VALUE(); 
*/
            /// <summary>
            ///   System.Single GetPostureValue(System.Single recoverRate)
            /// </summary>
            /// <param name = "recoverRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPostureValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_POSTURE_VALUE(System.Single recoverRate); 
*/
            /// <summary>
            ///   System.Single GetPowerPercent()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPowerPercent", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_POWER_PERCENT(); 
*/
            /// <summary>
            ///   System.String GetQuickDetail(System.Boolean fullDetail)
            /// </summary>
            /// <param name = "fullDetail">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetQuickDetail", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_QUICK_DETAIL(System.Boolean fullDetail); 
*/
            /// <summary>
            ///   System.String GetRecordLog()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRecordLog", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RECORD_LOG(); 
*/
            /// <summary>
            ///   System.Single GetRecoverRate(System.Single baseRecoverRate)
            /// </summary>
            /// <param name = "baseRecoverRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRecoverRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_RECOVER_RATE(System.Single baseRecoverRate); 
*/
            /// <summary>
            ///   System.Int32 GetRecruitCost(System.Boolean tempRecruit, System.Single rate)
            /// </summary>
            /// <param name = "tempRecruit">struct System.Boolean</param>
            /// <param name = "rate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRecruitCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Int32 GET_RECRUIT_COST(System.Boolean tempRecruit, System.Single rate); 
*/
            /// <summary>
            ///   System.String GetRelationShipText(System.Int32 _heroID)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRelationShipText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_RELATION_SHIP_TEXT(System.Int32 _heroID); 
*/
            /// <summary>
            ///   System.Single GetRestCurePostureRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRestCurePostureRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_REST_CURE_POSTURE_RATE(); 
*/
            /// <summary>
            ///   System.Single GetRestCurePower()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRestCurePower", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_REST_CURE_POWER(); 
*/
            /// <summary>
            ///   System.Single GetRestCureRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRestCureRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_REST_CURE_RATE(); 
*/
            /// <summary>
            ///   System.Single GetRestValue()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRestValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_REST_VALUE(); 
*/
            /// <summary>
            ///   System.Single GetSeeRange()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSeeRange", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SEE_RANGE(); 
*/
            /// <summary>
            ///   System.Single GetSelfCureExternalInjury(System.Single speRate)
            /// </summary>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureExternalInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_SELF_CURE_EXTERNAL_INJURY(System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCureExternalInjurySkill(System.Single buildingSkill)
            /// </summary>
            /// <param name = "buildingSkill">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureExternalInjurySkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_SELF_CURE_EXTERNAL_INJURY_SKILL(System.Single buildingSkill); 
*/
            /// <summary>
            ///   System.Int32 GetSelfCureExternalInjuryTime(System.Single buildingSkillNum, System.Single speRate)
            /// </summary>
            /// <param name = "buildingSkillNum">struct System.Single</param>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureExternalInjuryTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Int32 GET_SELF_CURE_EXTERNAL_INJURY_TIME(System.Single buildingSkillNum, System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCureInjury(System.Single targetSKillNum, System.Single speRate)
            /// </summary>
            /// <param name = "targetSKillNum">struct System.Single</param>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Single GET_SELF_CURE_INJURY(System.Single targetSKillNum, System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCureInternalInjury(System.Single speRate)
            /// </summary>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureInternalInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_SELF_CURE_INTERNAL_INJURY(System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCureInternalInjurySkill(System.Single buildingSkill)
            /// </summary>
            /// <param name = "buildingSkill">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureInternalInjurySkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_SELF_CURE_INTERNAL_INJURY_SKILL(System.Single buildingSkill); 
*/
            /// <summary>
            ///   System.Int32 GetSelfCureInternalInjuryTime(System.Single buildingSkillNum, System.Single speRate)
            /// </summary>
            /// <param name = "buildingSkillNum">struct System.Single</param>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureInternalInjuryTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Int32 GET_SELF_CURE_INTERNAL_INJURY_TIME(System.Single buildingSkillNum, System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCurePoisonInjury(System.Single speRate)
            /// </summary>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCurePoisonInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_SELF_CURE_POISON_INJURY(System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCurePoisonInjurySkill(System.Single buildingSkill)
            /// </summary>
            /// <param name = "buildingSkill">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCurePoisonInjurySkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Single GET_SELF_CURE_POISON_INJURY_SKILL(System.Single buildingSkill); 
*/
            /// <summary>
            ///   System.Int32 GetSelfCurePoisonInjuryTime(System.Single buildingSkillNum, System.Single speRate)
            /// </summary>
            /// <param name = "buildingSkillNum">struct System.Single</param>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCurePoisonInjuryTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial System.Int32 GET_SELF_CURE_POISON_INJURY_TIME(System.Single buildingSkillNum, System.Single speRate); 
*/
            /// <summary>
            ///   System.Single GetSelfCurePostureRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCurePostureRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SELF_CURE_POSTURE_RATE(); 
*/
            /// <summary>
            ///   System.Single GetSelfCurePower()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCurePower", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SELF_CURE_POWER(); 
*/
            /// <summary>
            ///   System.Single GetSelfCureRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SELF_CURE_RATE(); 
*/
            /// <summary>
            ///   System.Single GetSelfCureValue()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSelfCureValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SELF_CURE_VALUE(); 
*/
            /// <summary>
            ///   Spine.Unity.SkeletonGraphic GetSkeletonGraphic(UnityEngine.Transform targetSkeletonParent)
            /// </summary>
            /// <param name = "targetSkeletonParent">class UnityEngine.Transform</param>
            /// <returns>class Spine.Unity.SkeletonGraphic</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkeletonGraphic", "Spine.Unity.SkeletonGraphic", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 0)]
            public partial nint GET_SKELETON_GRAPHIC(nint targetSkeletonParent); 
*/
            /// <summary>
            ///   System.String GetSkeletonHorseIdleAnim()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkeletonHorseIdleAnim", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKELETON_HORSE_IDLE_ANIM(); 
*/
            /// <summary>
            ///   System.String GetSkeletonHorseRunAnim()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkeletonHorseRunAnim", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKELETON_HORSE_RUN_ANIM(); 
*/
            /// <summary>
            ///   System.String GetSkeletonHorseWalkAnim()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkeletonHorseWalkAnim", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKELETON_HORSE_WALK_ANIM(); 
*/
            /// <summary>
            ///   KungfuSkillLvData GetSkill(KungfuSkillLvData skillLvData, System.Boolean showInfo, System.Boolean speShow)
            /// </summary>
            /// <param name = "skillLvData">class KungfuSkillLvData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "speShow">struct System.Boolean</param>
            /// <returns>class KungfuSkillLvData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkill", "KungfuSkillLvData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint GET_SKILL(nint skillLvData, System.Boolean showInfo, System.Boolean speShow); 
*/
            /// <summary>
            ///   SkillMaxPracticeExpData GetSkillMaxPracticeExp(System.Int32 targetID)
            /// </summary>
            /// <param name = "targetID">struct System.Int32</param>
            /// <returns>class SkillMaxPracticeExpData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillMaxPracticeExp", "SkillMaxPracticeExpData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SKILL_MAX_PRACTICE_EXP(System.Int32 targetID); 
*/
            /// <summary>
            ///   System.Single GetSkillPowerChargeSpeed(FightSkillType targetSkillType)
            /// </summary>
            /// <param name = "targetSkillType">enum FightSkillType</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillPowerChargeSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("FightSkillType", 0)]
            public partial System.Single GET_SKILL_POWER_CHARGE_SPEED(FightSkillType targetSkillType); 
*/
            /// <summary>
            ///   System.Single GetSkillRareLvExpRate(System.Int32 targetRareLv)
            /// </summary>
            /// <param name = "targetRareLv">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillRareLvExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single GET_SKILL_RARE_LV_EXP_RATE(System.Int32 targetRareLv); 
*/
            /// <summary>
            ///   UnityEngine.Color GetSkinColorByDark()
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkinColorByDark", "UnityEngine.Color", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Color GET_SKIN_COLOR_BY_DARK(); 
*/
            /// <summary>
            ///   System.String GetSkinName(System.Boolean skeletonAnim, System.Int32 forceSkinID, System.Int32 forceSkinLv)
            /// </summary>
            /// <param name = "skeletonAnim">struct System.Boolean</param>
            /// <param name = "forceSkinID">struct System.Int32</param>
            /// <param name = "forceSkinLv">struct System.Int32</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkinName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial nint GET_SKIN_NAME(System.Boolean skeletonAnim, System.Int32 forceSkinID, System.Int32 forceSkinLv); 
*/
            /// <summary>
            ///   System.Single GetStartFavor(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetStartFavor", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial System.Single GET_START_FAVOR(nint targetHero); 
*/
            /// <summary>
            ///   HeroData GetTeacher()
            /// </summary>
            /// <returns>class HeroData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTeacher", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TEACHER(); 
*/
            /// <summary>
            ///   System.Single GetTerrainChangeTravelSpeed()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTerrainChangeTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TERRAIN_CHANGE_TRAVEL_SPEED(); 
*/
            /// <summary>
            ///   System.Single GetTotalAttir()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalAttir", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TOTAL_ATTIR(); 
*/
            /// <summary>
            ///   System.Single GetTotalFightSkill()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalFightSkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TOTAL_FIGHT_SKILL(); 
*/
            /// <summary>
            ///   System.Single GetTotalInjury()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalInjury", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TOTAL_INJURY(); 
*/
            /// <summary>
            ///   System.Single GetTotalLivingSkill()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalLivingSkill", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TOTAL_LIVING_SKILL(); 
*/
            /// <summary>
            ///   System.Single GetTradeValueRate(System.Boolean buy)
            /// </summary>
            /// <param name = "buy">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTradeValueRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial System.Single GET_TRADE_VALUE_RATE(System.Boolean buy); 
*/
            /// <summary>
            ///   System.Single GetTradeValueRate(System.Boolean buy, System.Boolean useLivingSkill)
            /// </summary>
            /// <param name = "buy">struct System.Boolean</param>
            /// <param name = "useLivingSkill">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTradeValueRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Single GET_TRADE_VALUE_RATE(System.Boolean buy, System.Boolean useLivingSkill); 
*/
            /// <summary>
            ///   System.Single GetTravelSpeed()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_TRAVEL_SPEED(); 
*/
            /// <summary>
            ///   System.Single GetTravelSpeed(System.Boolean havePower, System.Boolean isSprint)
            /// </summary>
            /// <param name = "havePower">struct System.Boolean</param>
            /// <param name = "isSprint">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Single GET_TRAVEL_SPEED(System.Boolean havePower, System.Boolean isSprint); 
*/
            /// <summary>
            ///   System.Int32 GetUpgradeForceLvNeedContribution(System.Single rate)
            /// </summary>
            /// <param name = "rate">struct System.Single</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUpgradeForceLvNeedContribution", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial System.Int32 GET_UPGRADE_FORCE_LV_NEED_CONTRIBUTION(System.Single rate); 
*/
            /// <summary>
            ///   System.Int32 GetUpgradeForceLvNeedContribution()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUpgradeForceLvNeedContribution", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_UPGRADE_FORCE_LV_NEED_CONTRIBUTION(); 
*/
            /// <summary>
            ///   System.String GetUpgradeForceLvNeedText()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUpgradeForceLvNeedText", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_UPGRADE_FORCE_LV_NEED_TEXT(); 
*/
            /// <summary>
            ///   System.Single GetUseItemValue(ItemData targetItem, System.Boolean useExtraStateValueRate)
            /// </summary>
            /// <param name = "targetItem">class ItemData</param>
            /// <param name = "useExtraStateValueRate">struct System.Boolean</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetUseItemValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Single GET_USE_ITEM_VALUE(nint targetItem, System.Boolean useExtraStateValueRate); 
*/
            /// <summary>
            ///   System.Single GetWeatherChangeTravelSpeed()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeatherChangeTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_WEATHER_CHANGE_TRAVEL_SPEED(); 
*/
            /// <summary>
            ///   System.Single GetWeighChangeTravelSpeed()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWeighChangeTravelSpeed", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_WEIGH_CHANGE_TRAVEL_SPEED(); 
*/
            /// <summary>
            ///   System.Single GetWoundResist()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWoundResist", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_WOUND_RESIST(); 
*/
            /// <summary>
            ///   System.Void GoInPrison()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GoInPrison", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void GO_IN_PRISON(); 
*/
            /// <summary>
            ///   System.Void GoOutPrison()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GoOutPrison", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void GO_OUT_PRISON(); 
*/
            /// <summary>
            ///   System.Boolean HaveBrother(System.Int32 _heroID)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveBrother", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean HAVE_BROTHER(System.Int32 _heroID); 
*/
            /// <summary>
            ///   System.Boolean HaveFriend(System.Int32 _heroID)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveFriend", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean HAVE_FRIEND(System.Int32 _heroID); 
*/
            /// <summary>
            ///   System.Boolean HaveHater(System.Int32 _heroID)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveHater", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean HAVE_HATER(System.Int32 _heroID); 
*/
            /// <summary>
            ///   System.Boolean HaveHobby(ItemData target)
            /// </summary>
            /// <param name = "target">class ItemData</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveHobby", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial System.Boolean HAVE_HOBBY(nint target); 
*/
            /// <summary>
            ///   System.Boolean HaveLover()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveLover", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean HAVE_LOVER(); 
*/
            /// <summary>
            ///   System.Boolean HaveMission(System.String targetMissionName)
            /// </summary>
            /// <param name = "targetMissionName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveMission", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean HAVE_MISSION(nint targetMissionName); 
*/
            /// <summary>
            ///   System.Boolean HavePrelover(System.Int32 _heroID)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HavePrelover", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean HAVE_PRELOVER(System.Int32 _heroID); 
*/
            /// <summary>
            ///   System.Boolean HaveRelationBetterThanFriend(System.Int32 _heroID, System.Boolean includeFriend)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "includeFriend">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveRelationBetterThanFriend", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean HAVE_RELATION_BETTER_THAN_FRIEND(System.Int32 _heroID, System.Boolean includeFriend); 
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
            ///   System.Boolean HaveStudent(System.Int32 _heroID)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveStudent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean HAVE_STUDENT(System.Int32 _heroID); 
*/
            /// <summary>
            ///   System.Boolean HaveTeacher()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveTeacher", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean HAVE_TEACHER(); 
*/
            /// <summary>
            ///   System.Boolean IsPlayerSameForce()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPlayerSameForce", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_PLAYER_SAME_FORCE(); 
*/
            /// <summary>
            ///   System.Boolean ItemControlable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ItemControlable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean ITEM_CONTROLABLE(); 
*/
            /// <summary>
            ///   System.Void JoinForce(System.Int32 _forceID, System.Int32 _forceLv, System.Int32 _generation, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_forceID">struct System.Int32</param>
            /// <param name = "_forceLv">struct System.Int32</param>
            /// <param name = "_generation">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("JoinForce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void JOIN_FORCE(System.Int32 _forceID, System.Int32 _forceLv, System.Int32 _generation, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void LeaveForce(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LeaveForce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void LEAVE_FORCE(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void LoseAllItem()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoseAllItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOSE_ALL_ITEM(); 
*/
            /// <summary>
            ///   System.Void LoseAllSkill()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoseAllSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOSE_ALL_SKILL(); 
*/
            /// <summary>
            ///   System.Void LoseItem(ItemData itemData, System.Boolean showPopInfo)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoseItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void LOSE_ITEM(nint itemData, System.Boolean showPopInfo); 
*/
            /// <summary>
            ///   System.Void LoseSkill(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoseSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial void LOSE_SKILL(nint targetSkill); 
*/
            /// <summary>
            ///   System.Void ManageAIInPrison(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageAIInPrison", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void MANAGE_AI_IN_PRISON(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Single ManageGetEquipPoison(ItemData equipData, System.Boolean showInfo, System.Single poisonRate, System.Single injuryRate)
            /// </summary>
            /// <param name = "equipData">class ItemData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "poisonRate">struct System.Single</param>
            /// <param name = "injuryRate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageGetEquipPoison", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial System.Single MANAGE_GET_EQUIP_POISON(nint equipData, System.Boolean showInfo, System.Single poisonRate, System.Single injuryRate); 
*/
            /// <summary>
            ///   System.Void ManageGetItemPoison(ItemData itemData, System.Boolean showInfo, System.Single poisonRate)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <param name = "poisonRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageGetItemPoison", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void MANAGE_GET_ITEM_POISON(nint itemData, System.Boolean showInfo, System.Single poisonRate); 
*/
            /// <summary>
            ///   System.Void ManageHeroHorseMove(System.Single deltaTime)
            /// </summary>
            /// <param name = "deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageHeroHorseMove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void MANAGE_HERO_HORSE_MOVE(System.Single deltaTime); 
*/
            /// <summary>
            ///   System.Void ManageHeroHorseMove(System.Single deltaTime, System.Boolean isInSafeArea)
            /// </summary>
            /// <param name = "deltaTime">struct System.Single</param>
            /// <param name = "isInSafeArea">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageHeroHorseMove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void MANAGE_HERO_HORSE_MOVE(System.Single deltaTime, System.Boolean isInSafeArea); 
*/
            /// <summary>
            ///   System.Void ManageHeroHorseRest(System.Single deltaTime)
            /// </summary>
            /// <param name = "deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageHeroHorseRest", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void MANAGE_HERO_HORSE_REST(System.Single deltaTime); 
*/
            /// <summary>
            ///   System.Void ManageHeroHorseTime(System.Single deltaTime)
            /// </summary>
            /// <param name = "deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageHeroHorseTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void MANAGE_HERO_HORSE_TIME(System.Single deltaTime); 
*/
            /// <summary>
            ///   System.Void ManagePoisonEquipment(ItemData targetItem)
            /// </summary>
            /// <param name = "targetItem">class ItemData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManagePoisonEquipment", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial void MANAGE_POISON_EQUIPMENT(nint targetItem); 
*/
            /// <summary>
            ///   System.Void ManagePoisonItem(ItemData targetItem)
            /// </summary>
            /// <param name = "targetItem">class ItemData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManagePoisonItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial void MANAGE_POISON_ITEM(nint targetItem); 
*/
            /// <summary>
            ///   System.Void ManageTagTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageTagTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void MANAGE_TAG_TIME(); 
*/
            /// <summary>
            ///   System.Int32 MaxSelfCureTime()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MaxSelfCureTime", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 MAX_SELF_CURE_TIME(); 
*/
            /// <summary>
            ///   System.Boolean MeetForceJobRequire(System.Int32 jobType)
            /// </summary>
            /// <param name = "jobType">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MeetForceJobRequire", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Boolean MEET_FORCE_JOB_REQUIRE(System.Int32 jobType); 
*/
            /// <summary>
            ///   System.Boolean MissionKeepInTeam()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MissionKeepInTeam", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean MISSION_KEEP_IN_TEAM(); 
*/
            /// <summary>
            ///   System.String Name(System.Boolean colored)
            /// </summary>
            /// <param name = "colored">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint NAME(System.Boolean colored); 
*/
            /// <summary>
            ///   System.Void OnDeserializedMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserializedMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_DESERIALIZED_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void OnSerializingMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerializingMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_SERIALIZING_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void PlayHeroSound(UnityEngine.AudioClip targetClip, System.Single volume, System.Single pitch)
            /// </summary>
            /// <param name = "targetClip">class UnityEngine.AudioClip</param>
            /// <param name = "volume">struct System.Single</param>
            /// <param name = "pitch">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayHeroSound", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.AudioClip", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void PLAY_HERO_SOUND(nint targetClip, System.Single volume, System.Single pitch); 
*/
            /// <summary>
            ///   System.Void RandomAttriAndSkill()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomAttriAndSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RANDOM_ATTRI_AND_SKILL(); 
*/
            /// <summary>
            ///   System.Void RandomBigMapMovePos()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomBigMapMovePos", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RANDOM_BIG_MAP_MOVE_POS(); 
*/
            /// <summary>
            ///   System.Void RandomFaceData(System.Boolean includeNoRandom)
            /// </summary>
            /// <param name = "includeNoRandom">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RandomFaceData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void RANDOM_FACE_DATA(System.Boolean includeNoRandom); 
*/
            /// <summary>
            ///   System.Void RecoverState()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecoverState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RECOVER_STATE(); 
*/
            /// <summary>
            ///   System.Void RefreshHeroSalaryAndPopulation()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshHeroSalaryAndPopulation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REFRESH_HERO_SALARY_AND_POPULATION(); 
*/
            /// <summary>
            ///   System.Void RefreshHeroSkeleton(Spine.Unity.SkeletonAnimation skeleton)
            /// </summary>
            /// <param name = "skeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshHeroSkeleton", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            public partial void REFRESH_HERO_SKELETON(nint skeleton); 
*/
            /// <summary>
            ///   System.Void RefreshHorseState(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshHorseState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void REFRESH_HORSE_STATE(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RefreshMaxAttriAndSkill()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshMaxAttriAndSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REFRESH_MAX_ATTRI_AND_SKILL(); 
*/
            /// <summary>
            ///   System.Void RemoveAllPrelover(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAllPrelover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void REMOVE_ALL_PRELOVER(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveBrother(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveBrother", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_BROTHER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveFriend(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveFriend", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_FRIEND(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveHater(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveHater", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_HATER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveLover(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveLover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void REMOVE_LOVER(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemovePrelover(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemovePrelover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_PRELOVER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveRelative(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveRelative", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_RELATIVE(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveStudent(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveStudent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_STUDENT(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveTag(System.String tagName, System.Boolean showInfo)
            /// </summary>
            /// <param name = "tagName">class System.String</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_TAG(nint tagName, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveTag(System.Int32 tagID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "tagID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REMOVE_TAG(System.Int32 tagID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void RemoveTeacher(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTeacher", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void REMOVE_TEACHER(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void ResetAI()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetAI", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_AI(); 
*/
            /// <summary>
            ///   System.Void ResetDefaultSkin()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetDefaultSkin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_DEFAULT_SKIN(); 
*/
            /// <summary>
            ///   System.Void ResetLoyal()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetLoyal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_LOYAL(); 
*/
            /// <summary>
            ///   System.Boolean SameForce(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SameForce", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial System.Boolean SAME_FORCE(nint targetHero); 
*/
            /// <summary>
            ///   System.Void set_HeroIconDirty(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_HeroIconDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_HERO_ICON_DIRTY(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetFavor(System.Single num, System.Boolean showPopInfo)
            /// </summary>
            /// <param name = "num">struct System.Single</param>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetFavor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_FAVOR(System.Single num, System.Boolean showPopInfo); 
*/
            /// <summary>
            ///   System.Void SetForce(System.Int32 _forceID, System.Int32 _forceLv)
            /// </summary>
            /// <param name = "_forceID">struct System.Int32</param>
            /// <param name = "_forceLv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetForce", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_FORCE(System.Int32 _forceID, System.Int32 _forceLv); 
*/
            /// <summary>
            ///   System.Void SetHeroAIData(HeroAIData target)
            /// </summary>
            /// <param name = "target">class HeroAIData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroAIData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroAIData", 0)]
            public partial void SET_HERO_AI_DATA(nint target); 
*/
            /// <summary>
            ///   System.Void SetHeroFavorUI(UnityEngine.GameObject heroFavorUI, System.Boolean showFullInfo)
            /// </summary>
            /// <param name = "heroFavorUI">class UnityEngine.GameObject</param>
            /// <param name = "showFullInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroFavorUI", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_HERO_FAVOR_UI(nint heroFavorUI, System.Boolean showFullInfo); 
*/
            /// <summary>
            ///   System.Void SetHeroForceLv(System.Int32 _forceLv)
            /// </summary>
            /// <param name = "_forceLv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroForceLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_HERO_FORCE_LV(System.Int32 _forceLv); 
*/
            /// <summary>
            ///   System.Void SetHeroMeet(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroMeet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_HERO_MEET(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void SetHeroWeapon(Spine.Unity.SkeletonAnimation targetSkeleton)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroWeapon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            public partial void SET_HERO_WEAPON(nint targetSkeleton); 
*/
            /// <summary>
            ///   System.Void SetHeroWeapon(Spine.Unity.SkeletonAnimation targetSkeleton, System.String weaponName)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <param name = "weaponName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHeroWeapon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void SET_HERO_WEAPON(nint targetSkeleton, nint weaponName); 
*/
            /// <summary>
            ///   System.Void SetHpBar(UnityEngine.GameObject hpBarRoot)
            /// </summary>
            /// <param name = "hpBarRoot">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHpBar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public partial void SET_HP_BAR(nint hpBarRoot); 
*/
            /// <summary>
            ///   System.Void SetLover(System.Int32 _heroID, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_heroID">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetLover", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_LOVER(System.Int32 _heroID, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void SetMeetFavor(System.Boolean showPopInfo)
            /// </summary>
            /// <param name = "showPopInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetMeetFavor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_MEET_FAVOR(System.Boolean showPopInfo); 
*/
            /// <summary>
            ///   System.Void SetMpBar(UnityEngine.GameObject mpBarRoot)
            /// </summary>
            /// <param name = "mpBarRoot">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetMpBar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public partial void SET_MP_BAR(nint mpBarRoot); 
*/
            /// <summary>
            ///   System.Void SetNeedRemove()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetNeedRemove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SET_NEED_REMOVE(); 
*/
            /// <summary>
            ///   System.Void SetNowActiveSkill(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetNowActiveSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial void SET_NOW_ACTIVE_SKILL(nint targetSkill); 
*/
            /// <summary>
            ///   System.Void SetPowerBar(UnityEngine.GameObject powerBarRoot)
            /// </summary>
            /// <param name = "powerBarRoot">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetPowerBar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            public partial void SET_POWER_BAR(nint powerBarRoot); 
*/
            /// <summary>
            ///   System.Void SetRandomEnemyBadFame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetRandomEnemyBadFame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SET_RANDOM_ENEMY_BAD_FAME(); 
*/
            /// <summary>
            ///   System.Void SetSkeletonFaceSlot(Spine.Unity.SkeletonAnimation targetSkeleton, System.Int32 i)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonFaceSlot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_SKELETON_FACE_SLOT(nint targetSkeleton, System.Int32 i); 
*/
            /// <summary>
            ///   System.Void SetSkeletonGraphic(UnityEngine.Transform targetSkeletonParent, System.Int32 forceSkinID, System.Int32 forceSkinLv)
            /// </summary>
            /// <param name = "targetSkeletonParent">class UnityEngine.Transform</param>
            /// <param name = "forceSkinID">struct System.Int32</param>
            /// <param name = "forceSkinLv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonGraphic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void SET_SKELETON_GRAPHIC(nint targetSkeletonParent, System.Int32 forceSkinID, System.Int32 forceSkinLv); 
*/
            /// <summary>
            ///   System.Void SetSkeletonGraphicFaceSlot(Spine.Unity.SkeletonGraphic targetSkeleton, System.Int32 i)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonGraphic</param>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonGraphicFaceSlot", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonGraphic", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_SKELETON_GRAPHIC_FACE_SLOT(nint targetSkeleton, System.Int32 i); 
*/
            /// <summary>
            ///   System.Void SetSkeletonGraphicSkinColor(Spine.Unity.SkeletonGraphic targetSkeleton)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonGraphic</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonGraphicSkinColor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonGraphic", 0)]
            public partial void SET_SKELETON_GRAPHIC_SKIN_COLOR(nint targetSkeleton); 
*/
            /// <summary>
            ///   System.Void SetSkeletonSkinColor(Spine.Unity.SkeletonAnimation targetSkeleton)
            /// </summary>
            /// <param name = "targetSkeleton">class Spine.Unity.SkeletonAnimation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkeletonSkinColor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Spine.Unity.SkeletonAnimation", 0)]
            public partial void SET_SKELETON_SKIN_COLOR(nint targetSkeleton); 
*/
            /// <summary>
            ///   System.Void SetSkin(System.Int32 _skinID, System.Int32 _skinLv)
            /// </summary>
            /// <param name = "_skinID">struct System.Int32</param>
            /// <param name = "_skinLv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSkin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_SKIN(System.Int32 _skinID, System.Int32 _skinLv); 
*/
            /// <summary>
            ///   System.Boolean StuffStoppable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StuffStoppable", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean STUFF_STOPPABLE(); 
*/
            /// <summary>
            ///   System.Void TryIdentifyAllItem(System.Boolean showInfo)
            /// </summary>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryIdentifyAllItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void TRY_IDENTIFY_ALL_ITEM(System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void UnderstandTag(System.Int32 id, System.Boolean showInfo)
            /// </summary>
            /// <param name = "id">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnderstandTag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void UNDERSTAND_TAG(System.Int32 id, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Void UnequipHorse(ItemData itemData, System.Boolean playSound)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnequipHorse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void UNEQUIP_HORSE(nint itemData, System.Boolean playSound); 
*/
            /// <summary>
            ///   System.Void UnequipItem(ItemData itemData)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnequipItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial void UNEQUIP_ITEM(nint itemData); 
*/
            /// <summary>
            ///   System.Void UnequipItem(ItemData itemData, System.Boolean playSound)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnequipItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void UNEQUIP_ITEM(nint itemData, System.Boolean playSound); 
*/
            /// <summary>
            ///   System.Void UnequipSkill(KungfuSkillLvData skillLvData, System.Boolean playSound)
            /// </summary>
            /// <param name = "skillLvData">class KungfuSkillLvData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnequipSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void UNEQUIP_SKILL(nint skillLvData, System.Boolean playSound); 
*/
            /// <summary>
            ///   System.Void UpgradeSkill(KungfuSkillLvData targetSkill)
            /// </summary>
            /// <param name = "targetSkill">class KungfuSkillLvData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpgradeSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KungfuSkillLvData", 0)]
            public partial void UPGRADE_SKILL(nint targetSkill); 
*/
            /// <summary>
            ///   System.Void UseMedFood(ItemData itemData, System.Boolean playSound, System.Boolean showInfo)
            /// </summary>
            /// <param name = "itemData">class ItemData</param>
            /// <param name = "playSound">struct System.Boolean</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UseMedFood", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void USE_MED_FOOD(nint itemData, System.Boolean playSound, System.Boolean showInfo); 
*/
            /// <summary>
            ///   System.Single UsePoisonRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UsePoisonRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single USE_POISON_RATE(); 
*/
        }
    }
}