namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TreasureData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TreasureData>, Ptr_TreasureData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TreasureData", "TreasureData")]
    public partial class TreasureData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TreasureData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TreasureData(System.IntPtr ptr) => new Ptr_TreasureData(ptr);
            public static implicit operator System.IntPtr(Ptr_TreasureData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TreasureData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TreasureData"]
        /// </summary>
        partial struct Ptr_TreasureData
        {
            /// <summary>
            /// 0x10 System.Boolean fullIdentified
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fullIdentified", "System.Boolean")]
            public partial System.Boolean FULL_IDENTIFIED { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Single identifyKnowledgeNeed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("identifyKnowledgeNeed", "System.Single")]
            public partial System.Single IDENTIFY_KNOWLEDGE_NEED { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.Int32> treasureLv
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treasureLv", "System.Collections.Generic.List<System.Int32>")]
            public partial nint TREASURE_LV { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.Single> identifyDifficulty
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("identifyDifficulty", "System.Collections.Generic.List<System.Single>")]
            public partial nint IDENTIFY_DIFFICULTY { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<System.Boolean> identified
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("identified", "System.Collections.Generic.List<System.Boolean>")]
            public partial nint IDENTIFIED { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> playerGuessTreasureLv
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("playerGuessTreasureLv", "System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>")]
            public partial nint PLAYER_GUESS_TREASURE_LV { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TreasureData"]
        /// </summary>
        partial struct Ptr_TreasureData
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