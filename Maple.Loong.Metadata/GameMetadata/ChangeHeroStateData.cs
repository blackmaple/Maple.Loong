using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ChangeHeroStateData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ChangeHeroStateData>, Ptr_ChangeHeroStateData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ChangeHeroStateData", "ChangeHeroStateData")]
    public partial class ChangeHeroStateData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ChangeHeroStateData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ChangeHeroStateData(System.IntPtr ptr) => new Ptr_ChangeHeroStateData(ptr);
            public static implicit operator System.IntPtr(Ptr_ChangeHeroStateData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ChangeHeroStateData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ChangeHeroStateData"]
        /// </summary>
        partial struct Ptr_ChangeHeroStateData
        {
            /// <summary>
            /// 0x10 System.Single hp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Single")]
            public partial System.Single HP { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single maxhp
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxhp", "System.Single")]
            public partial System.Single MAXHP { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Single mana
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mana", "System.Single")]
            public partial System.Single MANA { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single maxMana
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxMana", "System.Single")]
            public partial System.Single MAX_MANA { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single power
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("power", "System.Single")]
            public partial System.Single POWER { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single maxPower
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxPower", "System.Single")]
            public partial System.Single MAX_POWER { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single externalInjury
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("externalInjury", "System.Single")]
            public partial System.Single EXTERNAL_INJURY { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Single internalInjury
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("internalInjury", "System.Single")]
            public partial System.Single INTERNAL_INJURY { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single poisonInjury
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("poisonInjury", "System.Single")]
            public partial System.Single POISON_INJURY { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<System.Int32> changeAttri
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("changeAttri", "System.Collections.Generic.List<System.Int32>")]
            public partial nint CHANGE_ATTRI { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Single charm
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("charm", "System.Single")]
            public partial System.Single CHARM { get; set; } 
*/

            /// <summary>
            /// 0x48 HeroSpeAddData buffData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buffData", "HeroSpeAddData")]
            public partial nint BUFF_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ChangeHeroStateData"]
        /// </summary>
        partial struct Ptr_ChangeHeroStateData
        {
            /// <summary>
            /// static  ChangeHeroStateData op_Multiply(ChangeHeroStateData a, System.Single b)
            /// </summary>
            /// <param name = "a">class ChangeHeroStateData</param>
            /// <param name = "b">struct System.Single</param>
            /// <returns>class ChangeHeroStateData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Multiply", "ChangeHeroStateData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ChangeHeroStateData", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           public static partial nint OP_MULTIPLY(nint a, System.Single b); 
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
            ///   System.Object Clone()
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clone", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint CLONE(); 
*/
            /// <summary>
            ///   System.String GetDescribe()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_DESCRIBE();

            /// <summary>
            ///   System.Single GetMaxChangeMaxHp()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxChangeMaxHp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_MAX_CHANGE_MAX_HP(); 
*/
            /// <summary>
            ///   System.Single GetMaxChangeMaxMp()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaxChangeMaxMp", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_MAX_CHANGE_MAX_MP(); 
*/
        }
    }
}