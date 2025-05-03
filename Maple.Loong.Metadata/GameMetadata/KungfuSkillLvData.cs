namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."KungfuSkillLvData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_KungfuSkillLvData>, Ptr_KungfuSkillLvData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "KungfuSkillLvData", "KungfuSkillLvData")]
    public partial class KungfuSkillLvData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_KungfuSkillLvData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_KungfuSkillLvData(System.IntPtr ptr) => new Ptr_KungfuSkillLvData(ptr);
            public static implicit operator System.IntPtr(Ptr_KungfuSkillLvData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_KungfuSkillLvData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."KungfuSkillLvData"]
        /// </summary>
        partial struct Ptr_KungfuSkillLvData
        {
            /// <summary>
            /// 0x10 System.Int32 skillID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillID", "System.Int32")]
            public partial System.Int32 SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 lv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lv", "System.Int32")]
            public partial System.Int32 LV { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single fightExp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fightExp", "System.Single")]
            public partial System.Single FIGHT_EXP { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single bookExp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookExp", "System.Single")]
            public partial System.Single BOOK_EXP { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Boolean equiped
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equiped", "System.Boolean")]
            public partial System.Boolean EQUIPED { get; set; } 
*/

            /// <summary>
            /// 0x21 System.Boolean isNew
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isNew", "System.Boolean")]
            public partial System.Boolean IS_NEW { get; set; } 
*/

            /// <summary>
            /// 0x22 System.Boolean playerSkill
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerSkill", "System.Boolean")]
            public partial System.Boolean PLAYER_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x28 HeroSpeAddData speEquipData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speEquipData", "HeroSpeAddData")]
            public partial nint SPE_EQUIP_DATA { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single equipUseSpeAddValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipUseSpeAddValue", "System.Single")]
            public partial System.Single EQUIP_USE_SPE_ADD_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x38 HeroSpeAddData speUseData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speUseData", "HeroSpeAddData")]
            public partial nint SPE_USE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Single damageUseSpeAddValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("damageUseSpeAddValue", "System.Single")]
            public partial System.Single DAMAGE_USE_SPE_ADD_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Single selfUseSpeAddValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("selfUseSpeAddValue", "System.Single")]
            public partial System.Single SELF_USE_SPE_ADD_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Single enemyUseSpeAddValue
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("enemyUseSpeAddValue", "System.Single")]
            public partial System.Single ENEMY_USE_SPE_ADD_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x50 HeroSpeAddData extraAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("extraAddData", "HeroSpeAddData")]
            public partial nint EXTRA_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single cdTimeLeft
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cdTimeLeft", "System.Single")]
            public partial System.Single CD_TIME_LEFT { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Int32 useTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("useTime", "System.Int32")]
            public partial System.Int32 USE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single activeTimeLeft
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("activeTimeLeft", "System.Single")]
            public partial System.Single ACTIVE_TIME_LEFT { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Single power
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("power", "System.Single")]
            public partial System.Single POWER { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Boolean maxManaChanged
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxManaChanged", "System.Boolean")]
            public partial System.Boolean MAX_MANA_CHANGED { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."KungfuSkillLvData"]
        /// </summary>
        partial struct Ptr_KungfuSkillLvData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _skillID)
            /// </summary>
            /// <param name = "_skillID">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CTOR(System.Int32 _skillID); 
*/
            /// <summary>
            ///   System.Void AutoManageBreakThrough()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoManageBreakThrough", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AUTO_MANAGE_BREAK_THROUGH(); 
*/
            /// <summary>
            ///   System.Boolean BookExpFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BookExpFull", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean BOOK_EXP_FULL(); 
*/
            /// <summary>
            ///   System.Int32 BreakThroughDayCost()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BreakThroughDayCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 BREAK_THROUGH_DAY_COST(); 
*/
            /// <summary>
            ///   System.Boolean CanUpgrade()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanUpgrade", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_UPGRADE(); 
*/
            /// <summary>
            ///   System.Single CDTimeTotal()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CDTimeTotal", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single CD_TIME_TOTAL(); 
*/
            /// <summary>
            ///   System.Void ChangeExtraAddData(HeroSpeAddData deltaAddData)
            /// </summary>
            /// <param name = "deltaAddData">class HeroSpeAddData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeExtraAddData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroSpeAddData", 0)]
            public partial void CHANGE_EXTRA_ADD_DATA(nint deltaAddData); 
*/
            /// <summary>
            ///   System.Void ChangePower(System.Single deltaPower)
            /// </summary>
            /// <param name = "deltaPower">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangePower", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void CHANGE_POWER(System.Single deltaPower); 
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
            ///   KungfuSkillData DataBase()
            /// </summary>
            /// <returns>class KungfuSkillData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DataBase", "KungfuSkillData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint DATA_BASE(); 
*/
            /// <summary>
            ///   System.Boolean FightExpFull()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FightExpFull", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean FIGHT_EXP_FULL(); 
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
            ///   System.Void FullFillExp()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FullFillExp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void FULL_FILL_EXP(); 
*/
            /// <summary>
            ///   System.Single GetActiveTime()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetActiveTime", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_ACTIVE_TIME(); 
*/
            /// <summary>
            ///   PartPostureData GetAtkPartPosture()
            /// </summary>
            /// <returns>class PartPostureData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAtkPartPosture", "PartPostureData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATK_PART_POSTURE(); 
*/
            /// <summary>
            ///   System.Single GetBaseDamage()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseDamage", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_BASE_DAMAGE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Int32> GetBreakThroughAvailableChoice()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBreakThroughAvailableChoice", "System.Collections.Generic.List<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BREAK_THROUGH_AVAILABLE_CHOICE(); 
*/
            /// <summary>
            ///   PartPostureData GetDefPartPosture()
            /// </summary>
            /// <returns>class PartPostureData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDefPartPosture", "PartPostureData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DEF_PART_POSTURE(); 
*/
            /// <summary>
            ///   System.String GetExpDescribe()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExpDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EXP_DESCRIBE(); 
*/
            /// <summary>
            ///   HeroSpeAddData GetExtraAddData()
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExtraAddData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_EXTRA_ADD_DATA(); 
*/
            /// <summary>
            ///   System.Single GetLvSpeDamageChange()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLvSpeDamageChange", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_LV_SPE_DAMAGE_CHANGE(); 
*/
            /// <summary>
            ///   System.Single GetManaCost()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetManaCost", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_MANA_COST(); 
*/
            /// <summary>
            ///   System.String GetSkillDescribe()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_DESCRIBE(); 
*/
            /// <summary>
            ///   System.Single GetSkillExpExchangeRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillExpExchangeRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SKILL_EXP_EXCHANGE_RATE(); 
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
            ///   System.Single GetSkillNeedExpRate(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillNeedExpRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial System.Single GET_SKILL_NEED_EXP_RATE(nint targetHero); 
*/
            /// <summary>
            ///   HeroSpeAddData GetSpeEquipData()
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSpeEquipData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SPE_EQUIP_DATA(); 
*/
            /// <summary>
            ///   HeroSpeAddData GetSpeUseData()
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSpeUseData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SPE_USE_DATA(); 
*/
            /// <summary>
            ///   System.Void ManageCdTimeLeft(System.Single deltaTime)
            /// </summary>
            /// <param name = "deltaTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManageCdTimeLeft", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void MANAGE_CD_TIME_LEFT(System.Single deltaTime); 
*/
            /// <summary>
            ///   System.Single MaxPower()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MaxPower", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single MAX_POWER(); 
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
            ///   System.Void ResetSpeEquipData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetSpeEquipData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_SPE_EQUIP_DATA(); 
*/
            /// <summary>
            ///   System.Void ResetSpeUseData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetSpeUseData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_SPE_USE_DATA(); 
*/
            /// <summary>
            ///   System.Single SkillGetMaxExp(System.Int32 expType)
            /// </summary>
            /// <param name = "expType">struct System.Int32</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillGetMaxExp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial System.Single SKILL_GET_MAX_EXP(System.Int32 expType); 
*/
            /// <summary>
            ///   System.Int32 StudyDayCost()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StudyDayCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 STUDY_DAY_COST(); 
*/
            /// <summary>
            ///   System.Int32 Type()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Type", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 TYPE(); 
*/
            /// <summary>
            ///   System.Void Upgrade(System.Int32 upgradeLv)
            /// </summary>
            /// <param name = "upgradeLv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Upgrade", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void UPGRADE(System.Int32 upgradeLv); 
*/
        }
    }
}