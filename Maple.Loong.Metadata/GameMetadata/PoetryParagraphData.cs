namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."PoetryParagraphData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PoetryParagraphData>, Ptr_PoetryParagraphData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "PoetryParagraphData", "PoetryParagraphData")]
    public partial class PoetryParagraphData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PoetryParagraphData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PoetryParagraphData(System.IntPtr ptr) => new Ptr_PoetryParagraphData(ptr);
            public static implicit operator System.IntPtr(Ptr_PoetryParagraphData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PoetryParagraphData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."PoetryParagraphData"]
        /// </summary>
        partial struct Ptr_PoetryParagraphData
        {
            /// <summary>
            /// 0x10 System.String paragraphText
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("paragraphText", "System.String")]
            public partial nint PARAGRAPH_TEXT { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.Int32> paragraphTextNum
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("paragraphTextNum", "System.Collections.Generic.List<System.Int32>")]
            public partial nint PARAGRAPH_TEXT_NUM { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."PoetryParagraphData"]
        /// </summary>
        partial struct Ptr_PoetryParagraphData
        {
            /// <summary>
            ///   System.Void .ctor(System.String _paragraphText)
            /// </summary>
            /// <param name = "_paragraphText">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CTOR(nint _paragraphText); 
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