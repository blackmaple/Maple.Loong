namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ResourcePointData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ResourcePointData>, Ptr_ResourcePointData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ResourcePointData", "ResourcePointData")]
    public partial class ResourcePointData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ResourcePointData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ResourcePointData(System.IntPtr ptr) => new Ptr_ResourcePointData(ptr);
            public static implicit operator System.IntPtr(Ptr_ResourcePointData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ResourcePointData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ResourcePointData"]
        /// </summary>
        partial struct Ptr_ResourcePointData
        {
            /// <summary>
            /// 0x10 System.Int32 resourcePointID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointID", "System.Int32")]
            public partial System.Int32 RESOURCE_POINT_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 resourcePointTypeID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointTypeID", "System.Int32")]
            public partial System.Int32 RESOURCE_POINT_TYPE_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String resourcePointName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointName", "System.String")]
            public partial nint RESOURCE_POINT_NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String resourcePointFullName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointFullName", "System.String")]
            public partial nint RESOURCE_POINT_FULL_NAME { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String spriteName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("spriteName", "System.String")]
            public partial nint SPRITE_NAME { get; set; } 
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
            /// 0x38 System.Int32 belongForceID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("belongForceID", "System.Int32")]
            public partial System.Int32 BELONG_FORCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 connectAreaID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("connectAreaID", "System.Int32")]
            public partial System.Int32 CONNECT_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<System.Single> changeResource
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("changeResource", "System.Collections.Generic.List<System.Single>")]
            public partial nint CHANGE_RESOURCE { get; set; } 
*/

            /// <summary>
            /// 0x48 ForceSpeAddData resourceSpeAddData
            /// class ["Assembly-CSharp.dll".""."ForceSpeAddData"]
            /// </summary>
            /// <returns>class ForceSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourceSpeAddData", "ForceSpeAddData")]
            public partial nint RESOURCE_SPE_ADD_DATA { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Boolean resourcePointDetailDirty
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("resourcePointDetailDirty", "System.Boolean")]
            public partial System.Boolean RESOURCE_POINT_DETAIL_DIRTY { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ResourcePointData"]
        /// </summary>
        partial struct Ptr_ResourcePointData
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
            /// <summary>
            ///   AreaData GetArea()
            /// </summary>
            /// <returns>class AreaData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArea", "AreaData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_AREA(); 
*/
            /// <summary>
            ///   HeroSpeAddData GetDefenceSpeAddData()
            /// </summary>
            /// <returns>class HeroSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetDefenceSpeAddData", "HeroSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_DEFENCE_SPE_ADD_DATA(); 
*/
            /// <summary>
            ///   ForceData GetForce()
            /// </summary>
            /// <returns>class ForceData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForce", "ForceData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_FORCE(); 
*/
            /// <summary>
            ///   System.Single GetProduceRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetProduceRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_PRODUCE_RATE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<System.Single> GetTotalChangeResource()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalChangeResource", "System.Collections.Generic.List<System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TOTAL_CHANGE_RESOURCE(); 
*/
            /// <summary>
            ///   ForceSpeAddData GetTotalResourceSpeAddData()
            /// </summary>
            /// <returns>class ForceSpeAddData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalResourceSpeAddData", "ForceSpeAddData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TOTAL_RESOURCE_SPE_ADD_DATA(); 
*/
            /// <summary>
            ///   System.Void RefreshData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REFRESH_DATA(); 
*/
        }
    }
}