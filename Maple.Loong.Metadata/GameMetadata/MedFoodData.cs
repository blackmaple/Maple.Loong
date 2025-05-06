namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."MedFoodData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_MedFoodData>, Ptr_MedFoodData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "MedFoodData", "MedFoodData")]
    public partial class MedFoodData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_MedFoodData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_MedFoodData(System.IntPtr ptr) => new Ptr_MedFoodData(ptr);
            public static implicit operator System.IntPtr(Ptr_MedFoodData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_MedFoodData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."MedFoodData"]
        /// </summary>
        partial struct Ptr_MedFoodData
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
            /// 0x18 ChangeHeroStateData changeHeroState
            /// class ["Assembly-CSharp.dll".""."ChangeHeroStateData"]
            /// </summary>
            /// <returns>class ChangeHeroStateData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("changeHeroState", "ChangeHeroStateData")]
            public partial nint CHANGE_HERO_STATE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 randomSpeAddValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("randomSpeAddValue", "System.Int32")]
            public partial System.Int32 RANDOM_SPE_ADD_VALUE { get; set; } 
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
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."MedFoodData"]
        /// </summary>
        partial struct Ptr_MedFoodData
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
            ///   ChangeHeroStateData GetChangeHeroStateData()
            /// </summary>
            /// <returns>class ChangeHeroStateData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChangeHeroStateData", "ChangeHeroStateData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial ChangeHeroStateData.Ptr_ChangeHeroStateData GET_CHANGE_HERO_STATE_DATA();

        }
    }
}