using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HeroTagDataBase"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HeroTagDataBase>, Ptr_HeroTagDataBase>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "HeroTagDataBase", "HeroTagDataBase")]
    public partial class HeroTagDataBase
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HeroTagDataBase(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HeroTagDataBase(System.IntPtr ptr) => new Ptr_HeroTagDataBase(ptr);
            public static implicit operator System.IntPtr(Ptr_HeroTagDataBase ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_HeroTagDataBase ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroTagDataBase"]
        /// </summary>
        partial struct Ptr_HeroTagDataBase
        {
            /// <summary>
            /// 0x10 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial PMonoString NAME { get; set; }


            /// <summary>
            /// 0x18 System.Int32 value
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("value", "System.Int32")]
            public partial System.Int32 VALUE { get; set; }


            /// <summary>
            /// 0x1C SkillTargetType effectTarget
            /// enum ["Assembly-CSharp.dll".""."SkillTargetType"]
            /// </summary>
            /// <returns>enum SkillTargetType</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effectTarget", "SkillTargetType")]
            public partial SkillTargetType EFFECT_TARGET { get; set; }


            /// <summary>
            /// 0x20 System.String sameMeaning
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sameMeaning", "System.String")]
           public partial nint SAME_MEANING { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String oppositeMeaning
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("oppositeMeaning", "System.String")]
           public partial nint OPPOSITE_MEANING { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Boolean canRandom
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("canRandom", "System.Boolean")]
           public partial System.Boolean CAN_RANDOM { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<System.String> targetHobby
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("targetHobby", "System.Collections.Generic.List<System.String>")]
           public partial nint TARGET_HOBBY { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<System.String> requirement
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("requirement", "System.Collections.Generic.List<System.String>")]
           public partial nint REQUIREMENT { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<System.String> replaceTag
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("replaceTag", "System.Collections.Generic.List<System.String>")]
           public partial nint REPLACE_TAG { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String category
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("category", "System.String")]
            public partial PMonoString CATEGORY { get; set; }


            /// <summary>
            /// 0x58 HeroSpeAddData buffData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("buffData", "HeroSpeAddData")]
           public partial nint BUFF_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroTagDataBase"]
        /// </summary>
        partial struct Ptr_HeroTagDataBase
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
            ///   System.Single GetCostValue()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCostValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_COST_VALUE(); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Boolean showEffectTarget)
            /// </summary>
            /// <param name = "showEffectTarget">struct System.Boolean</param>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [/*typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)*/])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial PMonoString GET_DESCRIBE(System.Boolean showEffectTarget);

            /// <summary>
            ///   System.String Name()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Name", "System.String", CallConvs = [/*typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)*/])]
            public partial PMonoString GET_NAME();

        }
    }
}