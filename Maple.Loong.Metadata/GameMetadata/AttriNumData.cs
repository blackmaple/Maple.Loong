namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."AttriNumData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_AttriNumData>, Ptr_AttriNumData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "AttriNumData", "AttriNumData")]
    public partial class AttriNumData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_AttriNumData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_AttriNumData(System.IntPtr ptr) => new Ptr_AttriNumData(ptr);
            public static implicit operator System.IntPtr(Ptr_AttriNumData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_AttriNumData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."AttriNumData"]
        /// </summary>
        partial struct Ptr_AttriNumData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.List<System.Single> attri
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attri", "System.Collections.Generic.List<System.Single>")]
            public partial nint ATTRI { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.Single> fightSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fightSkill", "System.Collections.Generic.List<System.Single>")]
            public partial nint FIGHT_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.Single> livingSkill
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("livingSkill", "System.Collections.Generic.List<System.Single>")]
            public partial nint LIVING_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single Hp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Hp", "System.Single")]
            public partial System.Single HP { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single Power
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Power", "System.Single")]
            public partial System.Single POWER { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single Mana
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Mana", "System.Single")]
            public partial System.Single MANA { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Single Charm
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Charm", "System.Single")]
            public partial System.Single CHARM { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."AttriNumData"]
        /// </summary>
        partial struct Ptr_AttriNumData
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
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint CLONE(); 
*/
            /// <summary>
            ///   System.String GetAttriRatioString(System.Single attriRatio)
            /// </summary>
            /// <param name = "attriRatio">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttriRatioString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial nint GET_ATTRI_RATIO_STRING(System.Single attriRatio); 
*/
            /// <summary>
            ///   System.String GetDamageRatioDescribe(System.Single speRate)
            /// </summary>
            /// <param name = "speRate">struct System.Single</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDamageRatioDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial nint GET_DAMAGE_RATIO_DESCRIBE(System.Single speRate); 
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
            ///   System.String GetSkillNeedsDescribe(HeroData targetHero)
            /// </summary>
            /// <param name = "targetHero">class HeroData</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillNeedsDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial nint GET_SKILL_NEEDS_DESCRIBE(nint targetHero); 
*/
        }
    }
}