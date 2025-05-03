using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.Loong.Metadata
{
    public partial class GameReourceCache
    {
        public GameMetadataContext MetadataContext { get; }
        ILogger Logger => MetadataContext.Logger;

        GameDataController.Ptr_GameDataController Ptr_GameDataController { get; }

        public GameInventoryDisplayDTOEX[] WEAPON_DATA_BASE { get; }
        public GameInventoryDisplayDTOEX[] ARMOR_DATA_BASE { get; }
        public GameInventoryDisplayDTOEX[] HELMET_DATA_BASE { get; }
        public GameInventoryDisplayDTOEX[] SHOES_DATA_BASE { get; }
        public GameInventoryDisplayDTOEX[] MED_DATA_BASE { get; }
        public GameInventoryDisplayDTOEX[] FOOD_DATA_BASE { get; }
        public GameInventoryDisplayDTOEX[] HORSE_DATA_BASE { get; }


        public GameSkillDisplayDTOEX[] SKILL_DATA_BASE { get; }
        public GameSkillDisplayDTOEX[] SUMMON_SKILL_DATA_BASE { get; }
        //public GameSkillDisplayDTOEX[] SKILL_DATA_BASE_LIST { get; }


        public GameValueInfoDTOEX[] Character_Tag { get; }
        public GameValueInfoDTOEX[] Force_Data { get; }
        public GameValueInfoDTOEX[] Skin_Data { get; }

        public GameReourceCache(GameMetadataContext metadataContext)
        {
            this.MetadataContext = metadataContext;
            SpinWait.SpinUntil(() => GameDataController.Ptr_GameDataController.INSTANCE.IsNotNull());
            this.Ptr_GameDataController = GameDataController.Ptr_GameDataController.INSTANCE;

            this.FOOD_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.FOOD_DATA_BASE.AsEnumerable())];

            this.WEAPON_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.WEAPON_DATA_BASE.AsEnumerable())];
            this.ARMOR_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.ARMOR_DATA_BASE.AsEnumerable())];
            this.HELMET_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.HELMET_DATA_BASE.AsEnumerable())];
            this.SHOES_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.SHOES_DATA_BASE.AsEnumerable())];
            this.MED_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.MED_DATA_BASE.AsEnumerable())];
            this.HORSE_DATA_BASE = [.. LoadItems(this.Ptr_GameDataController.HORSE_DATA_BASE.AsEnumerable())];

            this.SKILL_DATA_BASE = [.. LoadSkills(this.Ptr_GameDataController.KUNGFU_SKILL_DATA_BASE.AsEnumerable())];
            this.SUMMON_SKILL_DATA_BASE = [.. LoadSkills(this.Ptr_GameDataController.SUMMON_SKILL_DATA_BASE.AsEnumerable())];
            //this.SKILL_DATA_BASE_LIST = [.. LoadSkillList()];


            this.Character_Tag = [.. LoadCharacterTags()];


            this.Skin_Data = [.. LoadSkinData()];

            this.Force_Data = [.. LoadForceData()];

        }

        IEnumerable<GameInventoryDisplayDTOEX> LoadItems(IEnumerable<ItemData.Ptr_ItemData> ptr_ItemDatas)
        {
            using (this.Logger.Running())
            {

                foreach (var item in ptr_ItemDatas)
                {
                    var id = item.ITEM_ID.ToString();
                    //var checkName = item.CHECK_NAME.ToString();
                    //var name = item.NAME.ToString();
                    //var desc = item.DESCRIBE.ToString();

                    var fullName = item.GET_NAME(false).ToString();
                    var fullDesc = item.GET_ITEM_TYPE_DESCRIBE(false).ToString();
                    var type = item.TYPE;

                    //var subType = item.SUB_TYPE;

                    this.Logger.LogInformation("Id:{id},fullname:{fullname},fulldesc:{fulldesc},type:{type}",
                        id, fullName, fullDesc, type);

                    yield return new GameInventoryDisplayDTOEX()
                    {
                        ObjectPointer = item.Ptr,
                        ObjectId = id,
                        DisplayName = fullName,
                        DisplayDesc = fullDesc,
                        DisplayCategory = type.ToString(),
                    };
                }
            }
        }

        IEnumerable<GameCharacterDisplayDTOEX> LoadCharacters()
        {
            using (this.Logger.Running())
            {

                foreach (var character in this.Ptr_GameDataController.SPE_HERO_DATA_BASE.AsEnumerable())
                {
                    var hero_id = character.HERO_ID.ToString();
                    var name = character.HERO_NAME.ToString();
                    this.Logger.LogInformation("heroid:{id},name:{name}", hero_id, name);
                    yield return new GameCharacterDisplayDTOEX() {ObjectPointer= character.Ptr, ObjectId = hero_id, DisplayName = name };
                }
            }

        }

        IEnumerable<GameSkillDisplayDTOEX> LoadSkills(IEnumerable<KungfuSkillData.Ptr_KungfuSkillData> ptr_KungfuSkillDatas)
        {
            using (this.Logger.Running())
            {
                foreach (var skill in ptr_KungfuSkillDatas.AsEnumerable())
                {
                    var skillId = skill.SKILL_ID.ToString();
                 //   var name = skill.NAME.ToString();
                    var fullDesc = skill.DESCRIBE.ToString();
                    var fullName = skill.GET_NAME(false).ToString();
                    //var fullDesc = string.Empty;// skill.TYPE_DESCRIBE().ToString();
                    var type = skill.TYPE.ToString();
                    this.Logger.LogInformation("skillid:{id},fullname:{fullname},fulldesc:{fulldesc},type:{type}", skillId,  fullName, fullDesc, type);
                    yield return new GameSkillDisplayDTOEX() { ObjectPointer = skill.Ptr, ObjectId = skillId, DisplayName = fullName, DisplayDesc = fullDesc, DisplayCategory = type, };
                }
            }
        }

        [Obsolete("")]
        IEnumerable<GameSkillDisplayDTOEX> LoadSkillList()
        {
            using (this.Logger.Running())
            {
                foreach (var database in this.Ptr_GameDataController.KUNGFU_SKILL_DATA_LIST.AsEnumerable())
                {
                    if (database.IsNotNull())
                    {
                        foreach (var skill in LoadSkills(database.AsEnumerable()))
                        {
                            yield return skill;
                        }
                    }

                }
            }
        }

        IEnumerable<GameValueInfoDTOEX> LoadCharacterTags()
        {
            using (this.Logger.Running())
            {
                foreach (var tag in this.Ptr_GameDataController.HERO_TAG_DATA_BASE.AsEnumerable())
                {
                     var name = tag.NAME.ToString();

                    var fullName = tag.GET_NAME().ToString();
                    var fullDesc = tag.GET_DESCRIBE(false).ToString();
                    var type = tag.CATEGORY.ToString();
                    this.Logger.LogInformation("name:{name},fullname{fullname},fulldesc:{fulldesc},type:{type}", name, fullName, fullDesc, type);
                    yield return new GameValueInfoDTOEX() {ObjectPointer = tag.Ptr, ObjectId = name!, DisplayName = name,/* DisplayDesc = fullDesc, DisplayCategory = type,*/ };
                }
            }
        }


        IEnumerable<GameValueInfoDTOEX> LoadForceData()
        {
            using (this.Logger.Running())
            {
                foreach (var item in this.Ptr_GameDataController.FORCE_DATA_BASE.AsEnumerable())
                {
                    var id = item.FORCE_ID.ToString();
                    var name = item.FORCE_NAME.ToString();
                    var desc = string.Empty;//
                    var fullName = item.GET_FORCE_NAME().ToString(); ;
                    var fullDesc = string.Empty;//;
                    var type = string.Empty;//;
                    this.Logger.LogInformation("id:{id},name:{name},fullname{fullname},fulldesc:{fulldesc},type:{type}", id, name, fullName, fullDesc, type);
                    yield return new GameValueInfoDTOEX() {ObjectPointer = item.Ptr, ObjectId = id, DisplayName = name,/* DisplayDesc = fullDesc, DisplayCategory = type,*/ };
                }
            }
        }

        IEnumerable<GameValueInfoDTOEX> LoadSkinData()
        {
            using (this.Logger.Running())
            {
                foreach (var item in this.Ptr_GameDataController.SKIN_DATA_BASE.AsEnumerable())
                {
                    var id = item.SKIN_ID.ToString();
                    var name = item.SKIN_NAME.ToString();
                    var desc = string.Empty;//
                    var fullName = string.Empty;//item.().ToString(); ;
                    var fullDesc = string.Empty;//;
                    var type = string.Empty;//;
                    this.Logger.LogInformation("id:{id},name:{name},fullname{fullname},fulldesc:{fulldesc},type:{type}", id, name, fullName, fullDesc, type);
                    yield return new GameValueInfoDTOEX() { ObjectPointer = item.Ptr, ObjectId = id, DisplayName = name,/* DisplayDesc = fullDesc, DisplayCategory = type,*/ };
                }

            }
        }
    }


    public class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public required nint ObjectPointer { get; set; }
    }

    public class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public required nint ObjectPointer { get; set; }

    }

    public class GameMonsterDisplayDTOEX : GameMonsterDisplayDTO
    {
        public required nint ObjectPointer { get; set; }

    }

    public class GameCharacterDisplayDTOEX : GameCharacterDisplayDTO
    {
        public required nint ObjectPointer { get; set; }
    }

    public class GameValueInfoDTOEX : GameValueInfoDTO
    {
        public required nint ObjectPointer { get; set; }

        //  public DictIndex Index { get; set; }
        public float Min { set; get; }


    }





}
