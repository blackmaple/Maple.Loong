using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."KungfuSkillData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_KungfuSkillData>, Ptr_KungfuSkillData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "KungfuSkillData", "KungfuSkillData")]
    public partial class KungfuSkillData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_KungfuSkillData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_KungfuSkillData(System.IntPtr ptr) => new Ptr_KungfuSkillData(ptr);
            public static implicit operator System.IntPtr(Ptr_KungfuSkillData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_KungfuSkillData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."KungfuSkillData"]
        /// </summary>
        partial struct Ptr_KungfuSkillData
        {
            /// <summary>
            /// 0x10 System.Boolean summonSkill
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonSkill", "System.Boolean")]
            public partial System.Boolean SUMMON_SKILL { get; set; }


            /// <summary>
            /// 0x14 System.Int32 skillID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillID", "System.Int32")]
            public partial System.Int32 SKILL_ID { get; set; }


            /// <summary>
            /// 0x18 System.Int32 belongForceID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("belongForceID", "System.Int32")]
           public partial System.Int32 BELONG_FORCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x1C SkillTargetType targetType
            /// enum ["Assembly-CSharp.dll".""."SkillTargetType"]
            /// </summary>
            /// <returns>enum SkillTargetType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("targetType", "SkillTargetType")]
           public partial SkillTargetType TARGET_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial PMonoString NAME { get; set; }


            /// <summary>
            /// 0x28 System.String describe
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("describe", "System.String")]
            public partial PMonoString DESCRIBE { get; set; }


            /// <summary>
            /// 0x30 System.Int32 type
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("type", "System.Int32")]
            public partial System.Int32 TYPE { get; set; }


            /// <summary>
            /// 0x34 System.Int32 rareLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rareLv", "System.Int32")]
           public partial System.Int32 RARE_LV { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Single manaCost
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("manaCost", "System.Single")]
           public partial System.Single MANA_COST { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Single baseDamage
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("baseDamage", "System.Single")]
           public partial System.Single BASE_DAMAGE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Single expRatio
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("expRatio", "System.Single")]
           public partial System.Single EXP_RATIO { get; set; } 
*/

            /// <summary>
            /// 0x48 AttriNumData addDamageRatio
            /// class ["Assembly-CSharp.dll".""."AttriNumData"]
            /// </summary>
            /// <returns>class AttriNumData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("addDamageRatio", "AttriNumData")]
           public partial nint ADD_DAMAGE_RATIO { get; set; } 
*/

            /// <summary>
            /// 0x50 AttriNumData skillNeeds
            /// class ["Assembly-CSharp.dll".""."AttriNumData"]
            /// </summary>
            /// <returns>class AttriNumData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillNeeds", "AttriNumData")]
           public partial nint SKILL_NEEDS { get; set; } 
*/

            /// <summary>
            /// 0x58 HeroSpeAddData upgradeAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("upgradeAddData", "HeroSpeAddData")]
           public partial nint UPGRADE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x60 HeroSpeAddData equipAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipAddData", "HeroSpeAddData")]
           public partial nint EQUIP_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x68 HeroSpeAddData useAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useAddData", "HeroSpeAddData")]
           public partial nint USE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Collections.Generic.List<SkillAttackRangeData> attackRangeData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SkillAttackRangeData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackRangeData", "System.Collections.Generic.List<SkillAttackRangeData>")]
           public partial nint ATTACK_RANGE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x78 SkillDamageRangeData damageRangeData
            /// class ["Assembly-CSharp.dll".""."SkillDamageRangeData"]
            /// </summary>
            /// <returns>class SkillDamageRangeData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("damageRangeData", "SkillDamageRangeData")]
           public partial nint DAMAGE_RANGE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 summonID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("summonID", "System.Int32")]
           public partial System.Int32 SUMMON_ID { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 battleMaxUseTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("battleMaxUseTime", "System.Int32")]
           public partial System.Int32 BATTLE_MAX_USE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x88 PartPostureData atkPartPosture
            /// class ["Assembly-CSharp.dll".""."PartPostureData"]
            /// </summary>
            /// <returns>class PartPostureData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("atkPartPosture", "PartPostureData")]
           public partial nint ATK_PART_POSTURE { get; set; } 
*/

            /// <summary>
            /// 0x90 PartPostureData defPartPosture
            /// class ["Assembly-CSharp.dll".""."PartPostureData"]
            /// </summary>
            /// <returns>class PartPostureData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defPartPosture", "PartPostureData")]
           public partial nint DEF_PART_POSTURE { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String weaponName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("weaponName", "System.String")]
           public partial nint WEAPON_NAME { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String animationName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("animationName", "System.String")]
           public partial nint ANIMATION_NAME { get; set; } 
*/

            /// <summary>
            /// 0xA8 SkillBulletData skillBullet
            /// class ["Assembly-CSharp.dll".""."SkillBulletData"]
            /// </summary>
            /// <returns>class SkillBulletData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillBullet", "SkillBulletData")]
           public partial nint SKILL_BULLET { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.List<SkillSpeEffectData> skillSpeEffects
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SkillSpeEffectData></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillSpeEffects", "System.Collections.Generic.List<SkillSpeEffectData>")]
           public partial nint SKILL_SPE_EFFECTS { get; set; } 
*/

            /// <summary>
            /// 0xB8 SkillDamageOrder skillDamageOrder
            /// enum ["Assembly-CSharp.dll".""."SkillDamageOrder"]
            /// </summary>
            /// <returns>enum SkillDamageOrder</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillDamageOrder", "SkillDamageOrder")]
           public partial SkillDamageOrder SKILL_DAMAGE_ORDER { get; set; } 
*/

            /// <summary>
            /// 0xBC System.Boolean autoHeroMove
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("autoHeroMove", "System.Boolean")]
           public partial System.Boolean AUTO_HERO_MOVE { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Int32 trailID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("trailID", "System.Int32")]
           public partial System.Int32 TRAIL_ID { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 maxAttackRange
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxAttackRange", "System.Int32")]
           public partial System.Int32 MAX_ATTACK_RANGE { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Boolean hide
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hide", "System.Boolean")]
           public partial System.Boolean HIDE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."KungfuSkillData"]
        /// </summary>
        partial struct Ptr_KungfuSkillData
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
            ///   System.Single BadFame()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BadFame", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single BAD_FAME(); 
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
            ///   PartPostureData GetAtkPartPosture(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>class PartPostureData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAtkPartPosture", "PartPostureData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_ATK_PART_POSTURE(System.Int32 targetLv); 
*/
            /// <summary>
            ///   System.Single GetBaseDamage(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseDamage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Single GET_BASE_DAMAGE(System.Int32 targetLv); 
*/
            /// <summary>
            ///   PartPostureData GetDefPartPosture(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>class PartPostureData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDefPartPosture", "PartPostureData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_DEF_PART_POSTURE(System.Int32 targetLv); 
*/
            /// <summary>
            ///   System.Single GetManaCost(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetManaCost", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Single GET_MANA_COST(System.Int32 targetLv); 
*/
            /// <summary>
            ///   System.Single GetMaxExp(System.Int32 targetLv, System.Int32 expType)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <param name = "expType">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxExp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial System.Single GET_MAX_EXP(System.Int32 targetLv, System.Int32 expType); 
*/
            /// <summary>
            ///   System.Single GetRealUpgradeRatio(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRealUpgradeRatio", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Single GET_REAL_UPGRADE_RATIO(System.Int32 targetLv); 
*/
            /// <summary>
            ///   System.Int32 GetSkillIconID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillIconID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_SKILL_ICON_ID(); 
*/
            /// <summary>
            ///   HeroSpeAddData GetSpeEquipData(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSpeEquipData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_SPE_EQUIP_DATA(System.Int32 targetLv); 
*/
            /// <summary>
            ///   HeroSpeAddData GetSpeUseData(System.Int32 targetLv)
            /// </summary>
            /// <param name = "targetLv">struct System.Int32</param>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSpeUseData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial nint GET_SPE_USE_DATA(System.Int32 targetLv); 
*/
            /// <summary>
            ///   System.String Name(System.Boolean colored)
            /// </summary>
            /// <param name = "colored">struct System.Boolean</param>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Name", "System.String", CallConvs = [/*typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)*/])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial PMonoString GET_NAME(System.Boolean colored);

            /// <summary>
            ///   System.String TypeDescribe()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TypeDescribe", "System.String", CallConvs = [/*typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)*/])]
            public partial PMonoString TYPE_DESCRIBE();

        }
    }
}