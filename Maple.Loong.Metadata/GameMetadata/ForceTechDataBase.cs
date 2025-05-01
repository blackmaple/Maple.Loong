namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ForceTechDataBase"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ForceTechDataBase>, Ptr_ForceTechDataBase>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ForceTechDataBase", "ForceTechDataBase")]
    public partial class ForceTechDataBase
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ForceTechDataBase(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ForceTechDataBase(System.IntPtr ptr) => new Ptr_ForceTechDataBase(ptr);
            public static implicit operator System.IntPtr(Ptr_ForceTechDataBase ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ForceTechDataBase ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ForceTechDataBase"]
        /// </summary>
        partial struct Ptr_ForceTechDataBase
        {
            /// <summary>
            /// 0x10 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String describe
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("describe", "System.String")]
            public partial nint DESCRIBE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 belongTab
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("belongTab", "System.Int32")]
            public partial System.Int32 BELONG_TAB { get; set; } 
*/

            /// <summary>
            /// 0x24 ForceSpeAddDataType speAddDataType
            /// enum ["Assembly-CSharp.dll".""."ForceSpeAddDataType"]
            /// </summary>
            /// <returns>enum ForceSpeAddDataType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speAddDataType", "ForceSpeAddDataType")]
            public partial ForceSpeAddDataType SPE_ADD_DATA_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single speAddDataNum
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speAddDataNum", "System.Single")]
            public partial System.Single SPE_ADD_DATA_NUM { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Boolean staticSpeAddNum
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("staticSpeAddNum", "System.Boolean")]
            public partial System.Boolean STATIC_SPE_ADD_NUM { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single researchDifficulty
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("researchDifficulty", "System.Single")]
            public partial System.Single RESEARCH_DIFFICULTY { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 costResourceID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("costResourceID", "System.Int32")]
            public partial System.Int32 COST_RESOURCE_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ForceTechDataBase"]
        /// </summary>
        partial struct Ptr_ForceTechDataBase
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