namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HeroTagData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HeroTagData>, Ptr_HeroTagData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "HeroTagData", "HeroTagData")]
    public partial class HeroTagData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HeroTagData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HeroTagData(System.IntPtr ptr) => new Ptr_HeroTagData(ptr);
            public static implicit operator System.IntPtr(Ptr_HeroTagData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_HeroTagData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroTagData"]
        /// </summary>
        partial struct Ptr_HeroTagData
        {
            /// <summary>
            /// 0x10 System.Int32 tagID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tagID", "System.Int32")]
            public partial System.Int32 TAG_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single leftTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("leftTime", "System.Single")]
            public partial System.Single LEFT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String sourceHero
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sourceHero", "System.String")]
            public partial nint SOURCE_HERO { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HeroTagData"]
        /// </summary>
        partial struct Ptr_HeroTagData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _tagID, System.Single _leftTime, System.String _sourceHero)
            /// </summary>
            /// <param name = "_tagID">struct System.Int32</param>
            /// <param name = "_leftTime">struct System.Single</param>
            /// <param name = "_sourceHero">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void CTOR(System.Int32 _tagID, System.Single _leftTime, nint _sourceHero); 
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
            ///   HeroTagDataBase DataBase()
            /// </summary>
            /// <returns>class HeroTagDataBase</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DataBase", "HeroTagDataBase", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint DATA_BASE(); 
*/
            /// <summary>
            ///   System.String GetDescribe(System.Boolean showEffectTarget, System.Boolean detail, System.Boolean showValue)
            /// </summary>
            /// <param name = "showEffectTarget">struct System.Boolean</param>
            /// <param name = "detail">struct System.Boolean</param>
            /// <param name = "showValue">struct System.Boolean</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDescribe", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial nint GET_DESCRIBE(System.Boolean showEffectTarget, System.Boolean detail, System.Boolean showValue); 
*/
            /// <summary>
            ///   System.Boolean IsPermanentTag()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPermanentTag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_PERMANENT_TAG(); 
*/
        }
    }
}