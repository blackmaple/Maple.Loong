using Maple.MonoGameAssistant.Core;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ItemData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ItemData>, Ptr_ItemData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ItemData", "ItemData")]
    public partial class ItemData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ItemData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ItemData(System.IntPtr ptr) => new Ptr_ItemData(ptr);
            public static implicit operator System.IntPtr(Ptr_ItemData ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ItemData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ItemData"]
        /// </summary>
        partial struct Ptr_ItemData
        {
            /// <summary>
            /// 0x10 System.Int32 itemID
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemID", "System.Int32")]
            public partial System.Int32 ITEM_ID { get; set; }


            /// <summary>
            /// 0x14 ItemType type
            /// enum ["Assembly-CSharp.dll".""."ItemType"]
            /// </summary>
            /// <returns>enum ItemType</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("type", "ItemType")]
            public partial ItemType TYPE { get; set; }


            /// <summary>
            /// 0x18 System.Int32 subType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("subType", "System.Int32")]
            public partial System.Int32 SUB_TYPE { get; set; }


            /// <summary>
            /// 0x20 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial PMonoString NAME { get; set; }


            /// <summary>
            /// 0x28 System.String checkName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("checkName", "System.String")]
            public partial PMonoString CHECK_NAME { get; set; }


            /// <summary>
            /// 0x30 System.String describe
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("describe", "System.String")]
            public partial PMonoString DESCRIBE { get; set; }


            /// <summary>
            /// 0x38 System.Int32 value
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("value", "System.Int32")]
           public partial System.Int32 VALUE { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 itemLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemLv", "System.Int32")]
            public partial System.Int32 ITEM_LV { get; set; }


            /// <summary>
            /// 0x40 System.Int32 rareLv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rareLv", "System.Int32")]
            public partial System.Int32 RARE_LV { get; set; }


            /// <summary>
            /// 0x44 System.Single weight
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("weight", "System.Single")]
            public partial System.Single WEIGHT { get; set; }


            /// <summary>
            /// 0x48 System.Boolean isNew
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isNew", "System.Boolean")]
           public partial System.Boolean IS_NEW { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Single poisonNum
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("poisonNum", "System.Single")]
           public partial System.Single POISON_NUM { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Boolean poisonNumDetected
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("poisonNumDetected", "System.Boolean")]
           public partial System.Boolean POISON_NUM_DETECTED { get; set; } 
*/

            /// <summary>
            /// 0x58 EquipmentData equipmentData
            /// class ["Assembly-CSharp.dll".""."EquipmentData"]
            /// </summary>
            /// <returns>class EquipmentData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("equipmentData", "EquipmentData")]
            public partial EquipmentData.Ptr_EquipmentData EQUIPMENT_DATA { get; set; }


            /// <summary>
            /// 0x60 MedFoodData medFoodData
            /// class ["Assembly-CSharp.dll".""."MedFoodData"]
            /// </summary>
            /// <returns>class MedFoodData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("medFoodData", "MedFoodData")]
            public partial MedFoodData.Ptr_MedFoodData MED_FOOD_DATA { get; set; }


            /// <summary>
            /// 0x68 BookData bookData
            /// class ["Assembly-CSharp.dll".""."BookData"]
            /// </summary>
            /// <returns>class BookData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bookData", "BookData")]
            public partial BookData.Ptr_BookData BOOK_DATA { get; set; }


            /// <summary>
            /// 0x70 TreasureData treasureData
            /// class ["Assembly-CSharp.dll".""."TreasureData"]
            /// </summary>
            /// <returns>class TreasureData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("treasureData", "TreasureData")]
            public partial TreasureData.Ptr_TreasureData TREASURE_DATA { get; set; }


            /// <summary>
            /// 0x78 MaterialData materialData
            /// class ["Assembly-CSharp.dll".""."MaterialData"]
            /// </summary>
            /// <returns>class MaterialData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("materialData", "MaterialData")]
            public partial MaterialData.Ptr_MaterialData MATERIAL_DATA { get; set; }


            /// <summary>
            /// 0x80 HorseData horseData
            /// class ["Assembly-CSharp.dll".""."HorseData"]
            /// </summary>
            /// <returns>class HorseData</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("horseData", "HorseData")]
            public partial HorseData.Ptr_HorseData HORSE_DATA { get; set; }

        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ItemData"]
        /// </summary>
        partial struct Ptr_ItemData
        {
            /// <summary>
            /// static  System.Boolean TryIdentifyOneResult(System.Single identifyKnowledge, System.Single identifyDifficulty)
            /// </summary>
            /// <param name = "identifyKnowledge">struct System.Single</param>
            /// <param name = "identifyDifficulty">struct System.Single</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryIdentifyOneResult", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
           public static partial System.Boolean TRY_IDENTIFY_ONE_RESULT(System.Single identifyKnowledge, System.Single identifyDifficulty); 
*/
            /// <summary>
            ///   System.Void .ctor(ItemType _type)
            /// </summary>
            /// <param name = "_type">enum ItemType</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ItemType", 0)]
           public partial void CTOR(ItemType _type); 
*/
            /// <summary>
            ///   System.Void AutoManageEquipPoison(System.Int32 heroLv)
            /// </summary>
            /// <param name = "heroLv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AutoManageEquipPoison", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial void AUTO_MANAGE_EQUIP_POISON(System.Int32 heroLv); 
*/
            /// <summary>
            ///   System.Single BadFame(System.Single rate)
            /// </summary>
            /// <param name = "rate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BadFame", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial System.Single BAD_FAME(System.Single rate); 
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
            ///   System.Single CountValueAndWeight()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CountValueAndWeight", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single COUNT_VALUE_AND_WEIGHT(); 
*/
            /// <summary>
            ///   System.Boolean DetectPoisonNum()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DetectPoisonNum", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean DETECT_POISON_NUM(); 
*/
            /// <summary>
            ///   System.Boolean Equiped()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equiped", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean EQUIPED(); 
*/
            /// <summary>
            ///   System.Single FullIdentify()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FullIdentify", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single FULL_IDENTIFY(); 
*/
            /// <summary>
            ///   System.String GetBookRareLvName()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBookRareLvName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_BOOK_RARE_LV_NAME(); 
*/
            /// <summary>
            ///   System.Int32 GetContributionCost(System.Int32 heroID)
            /// </summary>
            /// <param name = "heroID">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetContributionCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Int32 GET_CONTRIBUTION_COST(System.Int32 heroID); 
*/
            /// <summary>
            ///   System.Single GetHorseSeeRange()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHorseSeeRange", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_HORSE_SEE_RANGE(); 
*/
            /// <summary>
            ///   System.Single GetHorseStepAddRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHorseStepAddRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_HORSE_STEP_ADD_RATE(); 
*/
            /// <summary>
            ///   System.String GetItemIconName()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemIconName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ITEM_ICON_NAME(); 
*/
            /// <summary>
            ///   System.String GetItemSoundName()
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemSoundName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_ITEM_SOUND_NAME(); 
*/
            /// <summary>
            ///   System.String GetItemTypeDescribe(System.Boolean italic)
            /// </summary>
            /// <param name = "italic">struct System.Boolean</param>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemTypeDescribe", "System.String", CallConvs = [/*typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)*/])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial PMonoString GET_ITEM_TYPE_DESCRIBE(System.Boolean italic);

            /// <summary>
            ///   System.Single GetMaterialExtraCraftRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMaterialExtraCraftRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Single GET_MATERIAL_EXTRA_CRAFT_RATE(); 
*/
            /// <summary>
            ///   System.Int32 GetReadBookContributionCost(System.Int32 heroID)
            /// </summary>
            /// <param name = "heroID">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetReadBookContributionCost", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           public partial System.Int32 GET_READ_BOOK_CONTRIBUTION_COST(System.Int32 heroID); 
*/
            /// <summary>
            ///   System.Single GetShowRoomFameChange(System.Single rate)
            /// </summary>
            /// <param name = "rate">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShowRoomFameChange", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial System.Single GET_SHOW_ROOM_FAME_CHANGE(System.Single rate); 
*/
            /// <summary>
            ///   System.Int32 GetTreasureRealValue()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTreasureRealValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Int32 GET_TREASURE_REAL_VALUE(); 
*/
            /// <summary>
            ///   System.Int32 GetTreasureValue(System.Boolean guess)
            /// </summary>
            /// <param name = "guess">struct System.Boolean</param>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTreasureValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
           public partial System.Int32 GET_TREASURE_VALUE(System.Boolean guess); 
*/
            /// <summary>
            ///   System.Boolean IsPlayerEquip()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPlayerEquip", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial System.Boolean IS_PLAYER_EQUIP(); 
*/
            /// <summary>
            ///   System.Void ManagePlayerGuessTreasureLv(System.Single playerKnowledgeLv)
            /// </summary>
            /// <param name = "playerKnowledgeLv">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManagePlayerGuessTreasureLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial void MANAGE_PLAYER_GUESS_TREASURE_LV(System.Single playerKnowledgeLv); 
*/
            /// <summary>
            ///   System.String Name(System.Boolean colored)
            /// </summary>
            /// <param name = "colored">struct System.Boolean</param>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Name", "System.String", CallConvs = [/*typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)*/])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial PMonoString GET_NAME(System.Boolean colored);

            /// <summary>
            ///   System.Void PlayItemSound()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayItemSound", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void PLAY_ITEM_SOUND(); 
*/
            /// <summary>
            ///   System.Void RecountRareLv()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecountRareLv", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void RECOUNT_RARE_LV(); 
*/
            /// <summary>
            ///   ItemData SetBookData(System.Int32 _skillID, System.Int32 _rareLv)
            /// </summary>
            /// <param name = "_skillID">struct System.Int32</param>
            /// <param name = "_rareLv">struct System.Int32</param>
            /// <returns>class ItemData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetBookData", "ItemData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           public partial nint SET_BOOK_DATA(System.Int32 _skillID, System.Int32 _rareLv); 
*/
            /// <summary>
            ///   ItemData SetMaterialData(System.Int32 _subType, System.Int32 _itemLv, System.Int32 _rareLv)
            /// </summary>
            /// <param name = "_subType">struct System.Int32</param>
            /// <param name = "_itemLv">struct System.Int32</param>
            /// <param name = "_rareLv">struct System.Int32</param>
            /// <returns>class ItemData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetMaterialData", "ItemData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint SET_MATERIAL_DATA(System.Int32 _subType, System.Int32 _itemLv, System.Int32 _rareLv); 
*/
            /// <summary>
            ///   ItemData SetTreasureData(System.Int32 _subType, System.Int32 _itemLv, System.Int32 _rareLv)
            /// </summary>
            /// <param name = "_subType">struct System.Int32</param>
            /// <param name = "_itemLv">struct System.Int32</param>
            /// <param name = "_rareLv">struct System.Int32</param>
            /// <returns>class ItemData</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetTreasureData", "ItemData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
           public partial nint SET_TREASURE_DATA(System.Int32 _subType, System.Int32 _itemLv, System.Int32 _rareLv); 
*/
            /// <summary>
            ///   System.Single TryIdentify(System.Single identifyKnowledge)
            /// </summary>
            /// <param name = "identifyKnowledge">struct System.Single</param>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryIdentify", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
           public partial System.Single TRY_IDENTIFY(System.Single identifyKnowledge); 
*/
        }
    }
}