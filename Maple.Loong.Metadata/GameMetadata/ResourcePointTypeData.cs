namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ResourcePointTypeData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ResourcePointTypeData>, Ptr_ResourcePointTypeData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ResourcePointTypeData", "ResourcePointTypeData")]
    public partial class ResourcePointTypeData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ResourcePointTypeData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ResourcePointTypeData(System.IntPtr ptr) => new Ptr_ResourcePointTypeData(ptr);
            public static implicit operator System.IntPtr(Ptr_ResourcePointTypeData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ResourcePointTypeData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ResourcePointTypeData"]
        /// </summary>
        partial struct Ptr_ResourcePointTypeData
        {
            /// <summary>
            /// 0x10 System.Int32 resourcePointTypeID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointTypeID", "System.Int32")]
            public partial System.Int32 RESOURCE_POINT_TYPE_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String resourcePointTypeName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointTypeName", "System.String")]
            public partial nint RESOURCE_POINT_TYPE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.Single> changeResource
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("changeResource", "System.Collections.Generic.List<System.Single>")]
            public partial nint CHANGE_RESOURCE { get; set; } 
*/

            /// <summary>
            /// 0x28 ForceSpeAddData resourceSpeAddData
            /// class ["Assembly-CSharp.dll".""."ForceSpeAddData"]
            /// </summary>
            /// <returns>class ForceSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourceSpeAddData", "ForceSpeAddData")]
            public partial nint RESOURCE_SPE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x30 HeroSpeAddData defenceSpeAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("defenceSpeAddData", "HeroSpeAddData")]
            public partial nint DEFENCE_SPE_ADD_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ResourcePointTypeData"]
        /// </summary>
        partial struct Ptr_ResourcePointTypeData
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
        }
    }
}