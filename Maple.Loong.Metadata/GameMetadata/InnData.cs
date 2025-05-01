namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."InnData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_InnData>, Ptr_InnData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "InnData", "InnData")]
    public partial class InnData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_InnData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_InnData(System.IntPtr ptr) => new Ptr_InnData(ptr);
            public static implicit operator System.IntPtr(Ptr_InnData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_InnData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."InnData"]
        /// </summary>
        partial struct Ptr_InnData
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String innName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("innName", "System.String")]
            public partial nint INN_NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String describe
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("describe", "System.String")]
            public partial nint DESCRIBE { get; set; } 
*/

            /// <summary>
            /// 0x28 ItemListData shopItemList
            /// class ["Assembly-CSharp.dll".""."ItemListData"]
            /// </summary>
            /// <returns>class ItemListData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("shopItemList", "ItemListData")]
            public partial nint SHOP_ITEM_LIST { get; set; } 
*/

            /// <summary>
            /// 0x30 BigMapPos bigMapPos
            /// class ["Assembly-CSharp.dll".""."BigMapPos"]
            /// </summary>
            /// <returns>class BigMapPos</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bigMapPos", "BigMapPos")]
            public partial nint BIG_MAP_POS { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<System.Int32> nearAreaID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nearAreaID", "System.Collections.Generic.List<System.Int32>")]
            public partial nint NEAR_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Boolean haveSpeEvent
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveSpeEvent", "System.Boolean")]
            public partial System.Boolean HAVE_SPE_EVENT { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 plotNumCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotNumCount", "System.Int32")]
            public partial System.Int32 PLOT_NUM_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 missionNumCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("missionNumCount", "System.Int32")]
            public partial System.Int32 MISSION_NUM_COUNT { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."InnData"]
        /// </summary>
        partial struct Ptr_InnData
        {
            /// <summary>
            ///   System.Void .ctor(System.Int32 _id, System.String _innName)
            /// </summary>
            /// <param name = "_id">struct System.Int32</param>
            /// <param name = "_innName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CTOR(System.Int32 _id, nint _innName); 
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