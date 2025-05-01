using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."EquipmentData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_EquipmentData>, Ptr_EquipmentData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "EquipmentData", "EquipmentData")]
    public partial class EquipmentData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_EquipmentData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_EquipmentData(System.IntPtr ptr) => new Ptr_EquipmentData(ptr);
            public static implicit operator System.IntPtr(Ptr_EquipmentData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_EquipmentData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."EquipmentData"]
        /// </summary>
        partial struct Ptr_EquipmentData
        {
            /// <summary>
            /// 0x10 System.Int32 enhanceLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("enhanceLv", "System.Int32")]
            public partial System.Int32 ENHANCE_LV { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 littleType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("littleType", "System.Int32")]
            public partial System.Int32 LITTLE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 attriType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attriType", "System.Int32")]
            public partial System.Int32 ATTRI_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x20 HeroSpeAddData baseAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("baseAddData", "HeroSpeAddData")]
            public partial nint BASE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x28 HeroSpeAddData extraAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("extraAddData", "HeroSpeAddData")]
            public partial nint EXTRA_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Boolean equiped
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equiped", "System.Boolean")]
            public partial System.Boolean EQUIPED { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String skeletonName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skeletonName", "System.String")]
            public partial nint SKELETON_NAME { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String animName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("animName", "System.String")]
            public partial nint ANIM_NAME { get; set; } 
*/

            /// <summary>
            /// 0x48 EquipPoisonData equipPoisonData
            /// class ["Assembly-CSharp.dll".""."EquipPoisonData"]
            /// </summary>
            /// <returns>class EquipPoisonData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipPoisonData", "EquipPoisonData")]
            public partial nint EQUIP_POISON_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."EquipmentData"]
        /// </summary>
        partial struct Ptr_EquipmentData
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
            ///   HeroSpeAddData GetBaseAddData()
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBaseAddData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_BASE_ADD_DATA(); 
*/
            /// <summary>
            ///   System.String GetExtraAddName()
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetExtraAddName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial PMonoString GET_EXTRA_ADD_NAME();

        }
    }
}