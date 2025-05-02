namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ItemListData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ItemListData>, Ptr_ItemListData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ItemListData", "ItemListData")]
    public partial class ItemListData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ItemListData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ItemListData(System.IntPtr ptr) => new Ptr_ItemListData(ptr);
            public static implicit operator System.IntPtr(Ptr_ItemListData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ItemListData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ItemListData"]
        /// </summary>
        partial struct Ptr_ItemListData
        {
            /// <summary>
            /// 0x10 System.Int32 heroID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("heroID", "System.Int32")]
            public partial System.Int32 HERO_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 forceID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceID", "System.Int32")]
            public partial System.Int32 FORCE_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 money
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("money", "System.Int32")]
            public partial System.Int32 MONEY { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Single weight
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("weight", "System.Single")]
            public partial System.Single WEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Single maxWeight
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("maxWeight", "System.Single")]
            public partial System.Single MAX_WEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<ItemData> allItem
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ItemData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("allItem", "System.Collections.Generic.List<ItemData>")]
            public partial nint ALL_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<System.Collections.Generic.List<ItemData>> itemTypeList
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<ItemData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemTypeList", "System.Collections.Generic.List<System.Collections.Generic.List<ItemData>>")]
            public partial nint ITEM_TYPE_LIST { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ItemListData"]
        /// </summary>
        partial struct Ptr_ItemListData
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
            ///   System.Boolean BelongForce()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BelongForce", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean BELONG_FORCE(); 
*/
            /// <summary>
            ///   System.Boolean BelongHero()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BelongHero", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean BELONG_HERO(); 
*/
            /// <summary>
            ///   System.Void ClearAllItem()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearAllItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_ALL_ITEM(); 
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
            ///   ItemData FindRandomItem(System.Int32 minItemLv, System.Int32 maxItemLv, System.Boolean includeEquipment, System.Int32 targetItemType, System.Int32 subType, System.Int32 littleType, System.Single minValue, System.Single maxValue)
            /// </summary>
            /// <param name = "minItemLv">struct System.Int32</param>
            /// <param name = "maxItemLv">struct System.Int32</param>
            /// <param name = "includeEquipment">struct System.Boolean</param>
            /// <param name = "targetItemType">struct System.Int32</param>
            /// <param name = "subType">struct System.Int32</param>
            /// <param name = "littleType">struct System.Int32</param>
            /// <param name = "minValue">struct System.Single</param>
            /// <param name = "maxValue">struct System.Single</param>
            /// <returns>class ItemData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindRandomItem", "ItemData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 7)]
            public partial nint FIND_RANDOM_ITEM(System.Int32 minItemLv, System.Int32 maxItemLv, System.Boolean includeEquipment, System.Int32 targetItemType, System.Int32 subType, System.Int32 littleType, System.Single minValue, System.Single maxValue); 
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
            ///   System.Void GetItem(ItemListData target)
            /// </summary>
            /// <param name = "target">class ItemListData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemListData", 0)]
            public partial void GET_ITEM(nint target); 
*/
            /// <summary>
            ///   System.Void GetItem(ItemData targetItem)
            /// </summary>
            /// <param name = "targetItem">class ItemData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial void GET_ITEM(nint targetItem); 
*/
            /// <summary>
            ///   System.String GetItemName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEM_NAME(); 
*/
            /// <summary>
            ///   System.Single GetItemValue()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_ITEM_VALUE(); 
*/
            /// <summary>
            ///   System.Void LoseItem(ItemListData target)
            /// </summary>
            /// <param name = "target">class ItemListData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoseItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemListData", 0)]
            public partial void LOSE_ITEM(nint target); 
*/
            /// <summary>
            ///   System.Void LoseItem(ItemData targetItem)
            /// </summary>
            /// <param name = "targetItem">class ItemData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoseItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemData", 0)]
            public partial void LOSE_ITEM(nint targetItem); 
*/
            /// <summary>
            ///   System.Void MergeList(ItemListData target)
            /// </summary>
            /// <param name = "target">class ItemListData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MergeList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemListData", 0)]
            public partial void MERGE_LIST(nint target); 
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
            ///   System.Void RemoveList(ItemListData target)
            /// </summary>
            /// <param name = "target">class ItemListData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveList", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemListData", 0)]
            public partial void REMOVE_LIST(nint target); 
*/
        }
    }
}