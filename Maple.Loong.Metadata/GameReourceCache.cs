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
        }


        IEnumerable<GameInventoryDisplayDTOEX> LoadItems(IEnumerable<ItemData.Ptr_ItemData> ptr_ItemDatas)
        {
            using (this.Logger.Running())
            {

                foreach (var item in ptr_ItemDatas)
                {
                    var id = item.ITEM_ID.ToString();
                    var checkName = item.CHECK_NAME.ToString();
                    var name = item.NAME.ToString();
                    var desc = item.DESCRIBE.ToString();

                    var fullName = item.GET_NAME(false).ToString();
                    var fullDesc = item.GET_ITEM_TYPE_DESCRIBE(false).ToString();
                    var type = item.TYPE;

                    var subType = item.SUB_TYPE;

                    this.Logger.LogInformation("Id:{id},checkName:{checkName},name:{name},desc:{desc},fullname:{fullname},fulldesc:{fulldesc},type:{type},subType:{subType}",
                        id, checkName, name, desc, fullName, fullDesc, type, subType);

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

        public IEnumerable<GameCharacterDisplayDTOEX> LoadCharacters()
        {
            using (this.Logger.Running())
            {

                foreach (var character in this.Ptr_GameDataController.SPE_HERO_DATA_BASE.AsEnumerable())
                {
                    var hero_id = character.HERO_ID.ToString();
                    var name = character.HERO_NAME.ToString();
                    this.Logger.LogInformation("heroid:{id},name:{name}", hero_id, name);
                    yield return new GameCharacterDisplayDTOEX() { ObjectId = hero_id, DisplayName = name };
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
                    var name = skill.NAME.ToString();
                    var desc = skill.DESCRIBE.ToString();
                    var fullName = skill.GET_NAME(false).ToString();
                    var fullDesc = string.Empty;// skill.TYPE_DESCRIBE().ToString();
                    var type = skill.TYPE.ToString();
                    this.Logger.LogInformation("skillid:{id},name:{name} desc:{desc},fullname{fullname},fulldesc:{fulldesc},type:{type}", skillId, name, desc, fullName, fullDesc, type);
                    yield return new GameSkillDisplayDTOEX() { ObjectId = skillId, DisplayName = name, DisplayDesc = fullDesc, DisplayCategory = type, };
                }
            }
        }
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
                    var tagId = tag.VALUE.ToString();
                    var name = tag.NAME.ToString();

                    var fullName = tag.GET_NAME().ToString();
                    var fullDesc = tag.GET_DESCRIBE(false).ToString();
                    var type = tag.CATEGORY.ToString();
                    this.Logger.LogInformation("tagid:{id},name:{name},fullname{fullname},fulldesc:{fulldesc},type:{type}", tagId, name, fullName, fullDesc, type);
                    yield return new GameValueInfoDTOEX() { ObjectId = tagId, DisplayName = name,/* DisplayDesc = fullDesc, DisplayCategory = type,*/ };
                }
            }
        }

    }


    public class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public nint ObjectPointer { get; set; }
    }

    public class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public nint ObjectPointer { get; set; }

    }

    public class GameMonsterDisplayDTOEX : GameMonsterDisplayDTO
    {
        public nint ObjectPointer { get; set; }

    }

    public class GameCharacterDisplayDTOEX : GameCharacterDisplayDTO
    {
        public nint ObjectPointer { get; set; }
    }

    public class GameValueInfoDTOEX : GameValueInfoDTO
    {
        public nint ObjectPointer { get; set; }

        //  public DictIndex Index { get; set; }
        public float Min { set; get; }


    }





}
