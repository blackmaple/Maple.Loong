namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SkillDamageRangeData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SkillDamageRangeData>, Ptr_SkillDamageRangeData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "SkillDamageRangeData", "SkillDamageRangeData")]
    public partial class SkillDamageRangeData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SkillDamageRangeData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SkillDamageRangeData(System.IntPtr ptr) => new Ptr_SkillDamageRangeData(ptr);
            public static implicit operator System.IntPtr(Ptr_SkillDamageRangeData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SkillDamageRangeData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SkillDamageRangeData"]
        /// </summary>
        partial struct Ptr_SkillDamageRangeData
        {
            /// <summary>
            /// 0x10 DamageRangeType rangeType
            /// enum ["Assembly-CSharp.dll".""."DamageRangeType"]
            /// </summary>
            /// <returns>enum DamageRangeType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rangeType", "DamageRangeType")]
            public partial DamageRangeType RANGE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 minRange
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("minRange", "System.Int32")]
            public partial System.Int32 MIN_RANGE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 maxRange
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxRange", "System.Int32")]
            public partial System.Int32 MAX_RANGE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SkillDamageRangeData"]
        /// </summary>
        partial struct Ptr_SkillDamageRangeData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 type, System.Int32 min, System.Int32 max)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <param name = "min">struct System.Int32</param>
            /// <param name = "max">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void CTOR(System.Int32 type, System.Int32 min, System.Int32 max); 
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