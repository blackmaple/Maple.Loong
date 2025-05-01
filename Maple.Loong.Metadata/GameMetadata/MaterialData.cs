namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."MaterialData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_MaterialData>, Ptr_MaterialData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "MaterialData", "MaterialData")]
    public partial class MaterialData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_MaterialData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_MaterialData(System.IntPtr ptr) => new Ptr_MaterialData(ptr);
            public static implicit operator System.IntPtr(Ptr_MaterialData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_MaterialData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."MaterialData"]
        /// </summary>
        partial struct Ptr_MaterialData
        {
            /// <summary>
            /// 0x10 HeroSpeAddData extraAddData
            /// class ["Assembly-CSharp.dll".""."HeroSpeAddData"]
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("extraAddData", "HeroSpeAddData")]
            public partial nint EXTRA_ADD_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."MaterialData"]
        /// </summary>
        partial struct Ptr_MaterialData
        {
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