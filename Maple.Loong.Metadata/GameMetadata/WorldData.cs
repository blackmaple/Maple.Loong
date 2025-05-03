using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.Loong.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."WorldData"]
    /// [System.Object]
    /// [System.ICloneable]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_WorldData>, Ptr_WorldData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "WorldData", "WorldData")]
    public partial class WorldData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_WorldData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_WorldData(System.IntPtr ptr) => new Ptr_WorldData(ptr);
            public static implicit operator System.IntPtr(Ptr_WorldData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_WorldData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."WorldData"]
        /// </summary>
        partial struct Ptr_WorldData
        {
            /// <summary>
            /// 0x10 System.Int32 chapter
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chapter", "System.Int32")]
            public partial System.Int32 CHAPTER { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<System.Int32> cityAreaID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cityAreaID", "System.Collections.Generic.List<System.Int32>")]
            public partial nint CITY_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.Int32> villageAreaID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("villageAreaID", "System.Collections.Generic.List<System.Int32>")]
            public partial nint VILLAGE_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<System.Int32> forceAreaID
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceAreaID", "System.Collections.Generic.List<System.Int32>")]
            public partial nint FORCE_AREA_ID { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<AreaData> Areas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<AreaData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Areas", "System.Collections.Generic.List<AreaData>")]
            public partial nint AREAS { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<InnData> Inns
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<InnData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Inns", "System.Collections.Generic.List<InnData>")]
            public partial nint INNS { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<ResourcePointData> ResourcePoints
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ResourcePointData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ResourcePoints", "System.Collections.Generic.List<ResourcePointData>")]
            public partial nint RESOURCE_POINTS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<ForceData> Forces
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ForceData></returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Forces", "System.Collections.Generic.List<ForceData>")]
            public partial SysPtrList<ForceData.Ptr_ForceData> FORCES { get; set; } 


            /// <summary>
            /// 0x50 System.Collections.Generic.List<HeroData> Heros
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Heros", "System.Collections.Generic.List<HeroData>")]
            public partial SysPtrList<HeroData.Ptr_HeroData> HEROS { get; set; } 


            /// <summary>
            /// 0x58 System.Collections.Generic.List<HeroData> TempHeros
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<HeroData></returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TempHeros", "System.Collections.Generic.List<HeroData>")]
            public partial SysPtrList<HeroData.Ptr_HeroData> TEMP_HEROS { get; set; } 


            /// <summary>
            /// 0x60 System.Collections.Generic.List<EventData> BigMapRandomEventDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EventData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BigMapRandomEventDatas", "System.Collections.Generic.List<EventData>")]
            public partial nint BIG_MAP_RANDOM_EVENT_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.List<EventData> AreaMapRandomEventDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EventData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AreaMapRandomEventDatas", "System.Collections.Generic.List<EventData>")]
            public partial nint AREA_MAP_RANDOM_EVENT_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 lastRandomWorldEventDay
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastRandomWorldEventDay", "System.Int32")]
            public partial System.Int32 LAST_RANDOM_WORLD_EVENT_DAY { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<System.Int32> WorldEventDatasSaveRecord
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WorldEventDatasSaveRecord", "System.Collections.Generic.List<System.Int32>")]
            public partial nint WORLD_EVENT_DATAS_SAVE_RECORD { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.List<EventData> WorldEventDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<EventData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WorldEventDatas", "System.Collections.Generic.List<EventData>")]
            public partial nint WORLD_EVENT_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.List<WorldNewsData> WorldNewsDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<WorldNewsData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WorldNewsDatas", "System.Collections.Generic.List<WorldNewsData>")]
            public partial nint WORLD_NEWS_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.List<MailData> MailDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<MailData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MailDatas", "System.Collections.Generic.List<MailData>")]
            public partial nint MAIL_DATAS { get; set; } 
*/

            /// <summary>
            /// 0x98 GameMode gameMode
            /// enum ["Assembly-CSharp.dll".""."GameMode"]
            /// </summary>
            /// <returns>enum GameMode</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gameMode", "GameMode")]
            public partial GameMode GAME_MODE { get; set; } 
*/

            /// <summary>
            /// 0x9C System.Int32 gameDifficulty
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("gameDifficulty", "System.Int32")]
            public partial System.Int32 GAME_DIFFICULTY { get; set; } 
*/

            /// <summary>
            /// 0xA0 TimeData worldTime
            /// class ["Assembly-CSharp.dll".""."TimeData"]
            /// </summary>
            /// <returns>class TimeData</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("worldTime", "TimeData")]
            public partial TimeData.Ptr_TimeData WORLD_TIME { get; set; } 


            /// <summary>
            /// 0xA8 System.Single TimeDifficulty
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TimeDifficulty", "System.Single")]
            public partial System.Single TIME_DIFFICULTY { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Single hour
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hour", "System.Single")]
            public partial System.Single HOUR { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Boolean forceMeetingStarted
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceMeetingStarted", "System.Boolean")]
            public partial System.Boolean FORCE_MEETING_STARTED { get; set; } 
*/

            /// <summary>
            /// 0xB1 System.Boolean forcePartyStarted
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forcePartyStarted", "System.Boolean")]
            public partial System.Boolean FORCE_PARTY_STARTED { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Int32 forceMeetingMissedTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("forceMeetingMissedTime", "System.Int32")]
            public partial System.Int32 FORCE_MEETING_MISSED_TIME { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<InfoData> infos
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<InfoData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("infos", "System.Collections.Generic.List<InfoData>")]
            public partial nint INFOS { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Collections.Generic.Dictionary<System.Int32 , TimeData> plotHappened
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TimeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("plotHappened", "System.Collections.Generic.Dictionary<System.Int32,TimeData>")]
            public partial nint PLOT_HAPPENED { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.List<System.Int32> missionFinished
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("missionFinished", "System.Collections.Generic.List<System.Int32>")]
            public partial nint MISSION_FINISHED { get; set; } 
*/

            /// <summary>
            /// 0xD0 PlotEventLogData PlotEventLog
            /// class ["Assembly-CSharp.dll".""."PlotEventLogData"]
            /// </summary>
            /// <returns>class PlotEventLogData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlotEventLog", "PlotEventLogData")]
            public partial nint PLOT_EVENT_LOG { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<WorldPlotEventStartData> worldPlotEventStartData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<WorldPlotEventStartData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("worldPlotEventStartData", "System.Collections.Generic.List<WorldPlotEventStartData>")]
            public partial nint WORLD_PLOT_EVENT_START_DATA { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Collections.Generic.Dictionary<System.Int32 , TimeData> worldPlotEventStartTime
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , TimeData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("worldPlotEventStartTime", "System.Collections.Generic.Dictionary<System.Int32,TimeData>")]
            public partial nint WORLD_PLOT_EVENT_START_TIME { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Collections.Generic.List<System.String> tutorialFinished
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tutorialFinished", "System.Collections.Generic.List<System.String>")]
            public partial nint TUTORIAL_FINISHED { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Boolean openLeaveForce
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("openLeaveForce", "System.Boolean")]
            public partial System.Boolean OPEN_LEAVE_FORCE { get; set; } 
*/

            /// <summary>
            /// 0xF1 System.Boolean openForceBuilding
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("openForceBuilding", "System.Boolean")]
            public partial System.Boolean OPEN_FORCE_BUILDING { get; set; } 
*/

            /// <summary>
            /// 0xF2 System.Boolean openForceAttackResource
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("openForceAttackResource", "System.Boolean")]
            public partial System.Boolean OPEN_FORCE_ATTACK_RESOURCE { get; set; } 
*/

            /// <summary>
            /// 0xF3 System.Boolean openForceAttackArea
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("openForceAttackArea", "System.Boolean")]
            public partial System.Boolean OPEN_FORCE_ATTACK_AREA { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Boolean openForceAttackBasement
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("openForceAttackBasement", "System.Boolean")]
            public partial System.Boolean OPEN_FORCE_ATTACK_BASEMENT { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Int32 monthCatchBadFamePlayerTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthCatchBadFamePlayerTime", "System.Int32")]
            public partial System.Int32 MONTH_CATCH_BAD_FAME_PLAYER_TIME { get; set; } 
*/

            /// <summary>
            /// 0xFC System.Int32 monthGambleTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthGambleTime", "System.Int32")]
            public partial System.Int32 MONTH_GAMBLE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32 monthPartyTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthPartyTime", "System.Int32")]
            public partial System.Int32 MONTH_PARTY_TIME { get; set; } 
*/

            /// <summary>
            /// 0x104 System.Int32 monthForcePartyTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthForcePartyTime", "System.Int32")]
            public partial System.Int32 MONTH_FORCE_PARTY_TIME { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 monthDoctorTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthDoctorTime", "System.Int32")]
            public partial System.Int32 MONTH_DOCTOR_TIME { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 monthPerformForMoneyTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthPerformForMoneyTime", "System.Int32")]
            public partial System.Int32 MONTH_PERFORM_FOR_MONEY_TIME { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Int32 monthCoachTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthCoachTime", "System.Int32")]
            public partial System.Int32 MONTH_COACH_TIME { get; set; } 
*/

            /// <summary>
            /// 0x114 System.Int32 monthAttackMartialClubTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthAttackMartialClubTime", "System.Int32")]
            public partial System.Int32 MONTH_ATTACK_MARTIAL_CLUB_TIME { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Int32 monthSpeReduceBadFameTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthSpeReduceBadFameTime", "System.Int32")]
            public partial System.Int32 MONTH_SPE_REDUCE_BAD_FAME_TIME { get; set; } 
*/

            /// <summary>
            /// 0x11C System.Int32 monthSpeAddFameTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthSpeAddFameTime", "System.Int32")]
            public partial System.Int32 MONTH_SPE_ADD_FAME_TIME { get; set; } 
*/

            /// <summary>
            /// 0x120 System.Int32 monthSpeGetTalentPointTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthSpeGetTalentPointTime", "System.Int32")]
            public partial System.Int32 MONTH_SPE_GET_TALENT_POINT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x124 System.Int32 monthChallengeTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthChallengeTime", "System.Int32")]
            public partial System.Int32 MONTH_CHALLENGE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Int32 monthBuyAreaInfoTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("monthBuyAreaInfoTime", "System.Int32")]
            public partial System.Int32 MONTH_BUY_AREA_INFO_TIME { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<System.Collections.Generic.List<ItemData>> showRoomItems
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Collections.Generic.List<ItemData>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("showRoomItems", "System.Collections.Generic.List<System.Collections.Generic.List<ItemData>>")]
            public partial nint SHOW_ROOM_ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Single showRoomChangeFame
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("showRoomChangeFame", "System.Single")]
            public partial System.Single SHOW_ROOM_CHANGE_FAME { get; set; } 
*/

            /// <summary>
            /// 0x13C System.Int32 nowWeather
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("nowWeather", "System.Int32")]
            public partial System.Int32 NOW_WEATHER { get; set; } 
*/

            /// <summary>
            /// 0x140 System.Single weatherLastTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("weatherLastTime", "System.Single")]
            public partial System.Single WEATHER_LAST_TIME { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Collections.Generic.List<SkinUnlockData> skinUnlockData
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<SkinUnlockData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skinUnlockData", "System.Collections.Generic.List<SkinUnlockData>")]
            public partial nint SKIN_UNLOCK_DATA { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Collections.Generic.List<System.Int32> speBuildingUnlocked
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("speBuildingUnlocked", "System.Collections.Generic.List<System.Int32>")]
            public partial nint SPE_BUILDING_UNLOCKED { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Int32 finishForceMissionCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("finishForceMissionCount", "System.Int32")]
            public partial System.Int32 FINISH_FORCE_MISSION_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x15C System.Int32 totalFightCount
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalFightCount", "System.Int32")]
            public partial System.Int32 TOTAL_FIGHT_COUNT { get; set; } 
*/

            /// <summary>
            /// 0x160 System.Int32 studyFightWithGreatHeroSingleWinNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("studyFightWithGreatHeroSingleWinNum", "System.Int32")]
            public partial System.Int32 STUDY_FIGHT_WITH_GREAT_HERO_SINGLE_WIN_NUM { get; set; } 
*/

            /// <summary>
            /// 0x164 System.Int32 studyFightWithGreatHeroMultiWinNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("studyFightWithGreatHeroMultiWinNum", "System.Int32")]
            public partial System.Int32 STUDY_FIGHT_WITH_GREAT_HERO_MULTI_WIN_NUM { get; set; } 
*/

            /// <summary>
            /// 0x168 System.Int32 studyFightWithGreatHeroFinalWinNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("studyFightWithGreatHeroFinalWinNum", "System.Int32")]
            public partial System.Int32 STUDY_FIGHT_WITH_GREAT_HERO_FINAL_WIN_NUM { get; set; } 
*/

            /// <summary>
            /// 0x16C System.Int32 totalHeroMeet
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalHeroMeet", "System.Int32")]
            public partial System.Int32 TOTAL_HERO_MEET { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."WorldData"]
        /// </summary>
        partial struct Ptr_WorldData
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
            ///   System.Void AddNewHero(HeroData target)
            /// </summary>
            /// <param name = "target">class HeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddNewHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial void ADD_NEW_HERO(nint target); 
*/
            /// <summary>
            ///   System.Void AddTempHero(HeroData target)
            /// </summary>
            /// <param name = "target">class HeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTempHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial void ADD_TEMP_HERO(nint target); 
*/
            /// <summary>
            ///   System.Void AddWorldNews(System.String text, System.Int32 time)
            /// </summary>
            /// <param name = "text">class System.String</param>
            /// <param name = "time">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddWorldNews", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_WORLD_NEWS(nint text, System.Int32 time); 
*/
            /// <summary>
            ///   System.Boolean CanQuickTravel()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanQuickTravel", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean CAN_QUICK_TRAVEL(); 
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
            ///   AreaData GetArea(System.String areaName)
            /// </summary>
            /// <param name = "areaName">class System.String</param>
            /// <returns>class AreaData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetArea", "AreaData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_AREA(nint areaName); 
*/
            /// <summary>
            ///   System.Single GetChapterBadFameRate()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChapterBadFameRate", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_CHAPTER_BAD_FAME_RATE(); 
*/
            /// <summary>
            ///   System.Int32 GetEventSaveID(EventData targetEvent)
            /// </summary>
            /// <param name = "targetEvent">class EventData</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEventSaveID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EventData", 0)]
            public partial System.Int32 GET_EVENT_SAVE_ID(nint targetEvent); 
*/
            /// <summary>
            ///   EventData GetEventSaveIDEvent(System.Int32 eventSaveID)
            /// </summary>
            /// <param name = "eventSaveID">struct System.Int32</param>
            /// <returns>class EventData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEventSaveIDEvent", "EventData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_EVENT_SAVE_ID_EVENT(System.Int32 eventSaveID); 
*/
            /// <summary>
            ///   ForceData GetForce(System.String forceName)
            /// </summary>
            /// <param name = "forceName">class System.String</param>
            /// <returns>class ForceData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetForce", "ForceData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_FORCE(nint forceName); 
*/
            /// <summary>
            ///   HeroData GetHero(System.String heroName)
            /// </summary>
            /// <param name = "heroName">class System.String</param>
            /// <returns>class HeroData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHero", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_HERO(nint heroName); 
*/
            /// <summary>
            ///   HeroData GetHero(System.Int32 heroID)
            /// </summary>
            /// <param name = "heroID">struct System.Int32</param>
            /// <returns>class HeroData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHero", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_HERO(System.Int32 heroID); 
*/
            /// <summary>
            ///   System.Int32 GetHeroCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HERO_COUNT(); 
*/
            /// <summary>
            ///   ForceData GetHeroForce(System.Int32 heroID)
            /// </summary>
            /// <param name = "heroID">struct System.Int32</param>
            /// <returns>class ForceData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHeroForce", "ForceData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_HERO_FORCE(System.Int32 heroID); 
*/
            /// <summary>
            ///   System.Int32 GetRandomEnemyCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomEnemyCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_RANDOM_ENEMY_COUNT(); 
*/
            /// <summary>
            ///   System.String GetRandomWorldNews()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRandomWorldNews", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RANDOM_WORLD_NEWS(); 
*/
            /// <summary>
            ///   System.Int32 GetTempHeroCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTempHeroCount", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TEMP_HERO_COUNT(); 
*/
            /// <summary>
            ///   System.Boolean HaveWorldNews()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HaveWorldNews", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean HAVE_WORLD_NEWS(); 
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
            ///   System.Void OnSerializingMethod(System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerializingMethod", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 0)]
            public partial void ON_SERIALIZING_METHOD(System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   HeroData Player()
            /// </summary>
            /// <returns>class HeroData</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Player", "HeroData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial HeroData.Ptr_HeroData PLAYER(); 

            /// <summary>
            ///   System.Void RecoverPlayerMissionEventData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RecoverPlayerMissionEventData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RECOVER_PLAYER_MISSION_EVENT_DATA(); 
*/
            /// <summary>
            ///   System.Void RemoveHero(HeroData target)
            /// </summary>
            /// <param name = "target">class HeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial void REMOVE_HERO(nint target); 
*/
            /// <summary>
            ///   System.Void RemoveTempHero(HeroData target)
            /// </summary>
            /// <param name = "target">class HeroData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTempHero", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("HeroData", 0)]
            public partial void REMOVE_TEMP_HERO(nint target); 
*/
            /// <summary>
            ///   System.Boolean SkinUnlocked(System.Int32 _skinID, System.Int32 _skinLv)
            /// </summary>
            /// <param name = "_skinID">struct System.Int32</param>
            /// <param name = "_skinLv">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkinUnlocked", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Boolean SKIN_UNLOCKED(System.Int32 _skinID, System.Int32 _skinLv); 
*/
            /// <summary>
            ///   System.Void UnlockSkin(System.Int32 _skinID, System.Int32 _skinLv, System.Boolean showInfo)
            /// </summary>
            /// <param name = "_skinID">struct System.Int32</param>
            /// <param name = "_skinLv">struct System.Int32</param>
            /// <param name = "showInfo">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UnlockSkin", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void UNLOCK_SKIN(System.Int32 _skinID, System.Int32 _skinLv, System.Boolean showInfo); 
*/
        }
    }
}