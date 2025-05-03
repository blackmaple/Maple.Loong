namespace Maple.Loong.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp.dll".""."ItemListType"]
    /// </summary>
    public enum ItemListType : System.Int32
    {
        None = -1,
        EquipType = 0x00000000,
        MedType = 0x00000001,
        FoodType = 0x00000002,
        BookType = 0x00000003,
        TreasureType = 0x00000004,
        MaterialType = 0x00000005,
        HorseType = 0x00000006,
        All = 0x00000007
    }
}