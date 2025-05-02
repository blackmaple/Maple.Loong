namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HeroFaceData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HeroFaceData>, Ptr_HeroFaceData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "HeroFaceData", "HeroFaceData")]
    public partial class HeroFaceData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HeroFaceData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HeroFaceData(System.IntPtr ptr) => new Ptr_HeroFaceData(ptr);
            public static implicit operator System.IntPtr(Ptr_HeroFaceData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_HeroFaceData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroFaceData"]
        /// </summary>
        partial struct Ptr_HeroFaceData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.List<System.Int32> faceID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("faceID", "System.Collections.Generic.List<System.Int32>")]
            public partial nint FACE_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroFaceData"]
        /// </summary>
        partial struct Ptr_HeroFaceData
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
            ///   System.Void Reset()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reset", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET(); 
*/
        }
    }
}