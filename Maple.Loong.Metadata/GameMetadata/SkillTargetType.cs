namespace Maple.Loong.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp.dll".""."SkillTargetType"]
    /// </summary>
    public enum SkillTargetType : System.Int32
    {
        Enemy = 0x00000000,
        SelfTeam = 0x00000001,
        Self = 0x00000002,
        TeamMate = 0x00000003,
        EmptyGridSummon = 0x00000004,
        EmptyGridJump = 0x00000005
    }
}