using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SkinDataBase"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SkinDataBase>, Ptr_SkinDataBase>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "SkinDataBase", "SkinDataBase")]
    public partial class SkinDataBase
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SkinDataBase(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SkinDataBase(System.IntPtr ptr) => new Ptr_SkinDataBase(ptr);
            public static implicit operator System.IntPtr(Ptr_SkinDataBase ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_SkinDataBase ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SkinDataBase"]
        /// </summary>
        partial struct Ptr_SkinDataBase
        {
            /// <summary>
            /// 0x10 System.Int32 skinID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinID", "System.Int32")]
            public partial System.Int32 SKIN_ID { get; set; }


            /// <summary>
            /// 0x18 System.String skinName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinName", "System.String")]
            public partial PMonoString SKIN_NAME { get; set; }


            /// <summary>
            /// 0x20 HeroSpeAddData skinSpeAdd
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinSpeAdd", "HeroSpeAddData")]
           public partial nint SKIN_SPE_ADD { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SkinDataBase"]
        /// </summary>
        partial struct Ptr_SkinDataBase
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
            ///   System.String GetSkinFullName(System.Int32 _skinLv, System.Boolean changeLine)
            /// </summary>
            /// <param name = "_skinLv">struct System.Int32</param>
            /// <param name = "changeLine">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkinFullName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_SKIN_FULL_NAME(System.Int32 _skinLv, System.Boolean changeLine); 
*/
            /// <summary>
            ///   HeroSpeAddData GetSkinSpeAdd(System.Int32 lv)
            /// </summary>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkinSpeAdd", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_SKIN_SPE_ADD(System.Int32 lv); 
*/
        }
    }
}