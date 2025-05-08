using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataCollections;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Numerics;
using System.Runtime.CompilerServices;
using static Maple.Loong.Metadata.GameController;
using static Maple.Loong.Metadata.GameDataController;

namespace Maple.Loong.Metadata
{
    public partial class GameCheatEngine(GameReourceCache reourceCache)
    {
        GameReourceCache ReourceCache { get; } = reourceCache;
        GameMetadataContext MetadataContext => ReourceCache.MetadataContext;
        ILogger Logger => MetadataContext.Logger;

        GameController.Ptr_GameController Ptr_GameController { get; init; }
        WorldData.Ptr_WorldData Ptr_WorldData { get; init; }

        //public bool InGame()
        //{
        //    return this.Ptr_GameController.IsNotNull() && this.Ptr_GameController.M_CACHED_PTR != nint.Zero;
        //}

        public static GameCheatEngine Create(GameReourceCache cache)
        {
            Ptr_GameController ptr_GameController = GameController.Ptr_GameController.INSTANCE;
            if (ptr_GameController.IsNull() || ptr_GameController.M_CACHED_PTR == nint.Zero)
            {
                return GameException.ThrowIfNotLoaded<GameCheatEngine>();
            }
            return new GameCheatEngine(cache)
            {

                Ptr_GameController = ptr_GameController,
                Ptr_WorldData = ptr_GameController.WORLD_DATA,
            };
        }

        int GetItemCount(ItemListData.Ptr_ItemListData ptr_ItemListData, ItemData.Ptr_ItemData ptr_ItemData)
        {
            int count = 0;
            foreach (var item in ptr_ItemListData.ALL_ITEM.AsEnumerable())
            {
                if (item.Ptr == ptr_ItemData.Ptr)
                {
                    count++;
                }
                this.Logger.LogInformation("item:{name},type:{type}", item.GET_NAME(false), item.TYPE.ToString());
            }

            return count;
        }
        public GameInventoryInfoDTO GetGameInventoryInfo(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var itemPtr = this.ReourceCache.ALL_ITEM.Where(p =>
                p.ObjectId == inventoryObjectDTO.InventoryObject
                && p.DisplayCategory == inventoryObjectDTO.InventoryCategory).FirstOrDefault();
            if (itemPtr is null)
            {
                return GameException.Throw<GameInventoryInfoDTO>("NOT FOUND");
            }
            var player = this.Ptr_WorldData.PLAYER();
            var bag = player.ITEM_LIST_DATA;
            var count = GetItemCount(bag, itemPtr.ObjectPointer);
            //var storage = player.SELF_STORAGE;
            //count += GetItemCount(storage, id, type);
            return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, InventoryCount = count };

        }

        public GameInventoryInfoDTO UpdateGameInventoryInfo(GameInventoryModifyDTO inventoryModifyDTO)
        {
            var itemPtr = this.ReourceCache.ALL_ITEM.Where(p =>
            p.ObjectId == inventoryModifyDTO.InventoryObject
            && p.DisplayCategory == inventoryModifyDTO.InventoryCategory).FirstOrDefault();
            if (itemPtr is null)
            {
                return GameException.Throw<GameInventoryInfoDTO>("NOT FOUND");
            }
            var player = this.Ptr_WorldData.PLAYER();

            if (inventoryModifyDTO.InventoryCategory == nameof(Ptr_GameDataController.SKIN_DATA_BASE))
            {
                var ptr_skin =new  SkinDataBase.Ptr_SkinDataBase(itemPtr.ObjectPointer);
                player.SET_SKIN(ptr_skin.SKIN_ID, 1);
                return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = 1 };

            }

            var oldCount = GetItemCount(player.ITEM_LIST_DATA, itemPtr.ObjectPointer);
            var newCount = inventoryModifyDTO.InventoryCount;
            var diff = newCount - oldCount;
            for (var i = 0; i < diff; ++i)
            {
                player.GET_ITEM(itemPtr.ObjectPointer, false);
            }
            var currCount = GetItemCount(player.ITEM_LIST_DATA, itemPtr.ObjectPointer);
            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, InventoryCount = currCount };


        }




        public IEnumerable<GameCharacterDisplayDTO> GetGameCharacters()
        {
            var worldData = this.Ptr_WorldData;
            var player = worldData.PLAYER();
            var playerId = player.HERO_ID;
            foreach (var character in worldData.HEROS.AsEnumerable())
            {
                var id = character.HERO_ID;
                yield return new GameCharacterDisplayDTO()
                {
                    ObjectId = id.ToString(),
                    DisplayName = character.GET_NAME(false).ToString(),
                    DisplayCategory = GetEnumHeroType(character, playerId).ToString(),
                    DisplayDesc = string.Empty,
                };
            }

            static EnumHeroType GetEnumHeroType(HeroData.Ptr_HeroData ptr_HeroData, int playerId)
            {
                if (ptr_HeroData.HERO_ID == playerId)
                {
                    return EnumHeroType.A_Player;
                }
                if (ptr_HeroData.IN_TEAM)
                {
                    return EnumHeroType.B_Friend;
                }
                if (ptr_HeroData.IS_RANDOM_ENEMY)
                {
                    return EnumHeroType.C_Enemy;
                }
                return EnumHeroType.D_NPC;
            }
        }
        IEnumerable<GameSwitchDisplayDTO> GetAttri(float[] arr)
        {
            foreach (var type in Enum.GetValues<AttriType>())
            {
                var val = arr.ElementAtOrDefault((int)type);
                yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(AttriType)}.{type}", DisplayName = $"属.{type}", ContentValue = val.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }
        }
        IEnumerable<GameSwitchDisplayDTO> GetFight(float[] arr)
        {
            foreach (var type in Enum.GetValues<FightSkillType>())
            {
                var val = arr.ElementAtOrDefault((int)type);
                yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(FightSkillType)}.{type}", DisplayName = $"武.{type}", ContentValue = val.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }
        }
        IEnumerable<GameSwitchDisplayDTO> GetLiving(float[] arr)
        {
            foreach (var type in Enum.GetValues<LivingSkillType>())
            {
                var val = arr.ElementAtOrDefault((int)type);
                yield return new GameSwitchDisplayDTO() { ObjectId = $"{nameof(LivingSkillType)}.{type}", DisplayName = $"技.{type}", ContentValue = val.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };
            }
        }
        public IEnumerable<GameSwitchDisplayDTO> GetCharacterStatusImp(HeroData.Ptr_HeroData ptr_HeroData)
        {
            var baseAttri = ptr_HeroData.TOTAL_ATTRI.AsReadOnlySpan().ToArray();
            foreach (var att in GetAttri(baseAttri))
            {
                yield return att;
            }
            //  var maxAttri = ptr_HeroData.MAX_ATTRI.AsReadOnlySpan().ToArray();

            var baseFight = ptr_HeroData.TOTAL_FIGHT_SKILL.AsReadOnlySpan().ToArray();
            foreach (var att in GetFight(baseFight))
            {
                yield return att;
            }
            //  var maxFight = ptr_HeroData.MAX_FIGHT_SKILL.AsReadOnlySpan().ToArray();

            var baseLiveing = ptr_HeroData.TOTAL_LIVING_SKILL.AsReadOnlySpan().ToArray();
            foreach (var att in GetLiving(baseLiveing))
            {
                yield return att;
            }
            //   var maxLiveing = ptr_HeroData.BASE_LIVING_SKILL.AsReadOnlySpan().ToArray();


            var hp = ptr_HeroData.HP;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.HP), DisplayName = nameof(ptr_HeroData.HP), ContentValue = hp.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var maxHp = ptr_HeroData.MAXHP;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.MAXHP), DisplayName = nameof(ptr_HeroData.MAXHP), ContentValue = maxHp.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var mp = ptr_HeroData.MANA;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.MANA), DisplayName = nameof(ptr_HeroData.MANA), ContentValue = mp.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var maxMp = ptr_HeroData.MAX_MANA;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.MAX_MANA), DisplayName = nameof(ptr_HeroData.MAX_MANA), ContentValue = maxMp.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var power = ptr_HeroData.POWER;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.POWER), DisplayName = nameof(ptr_HeroData.POWER), ContentValue = power.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var maxPower = ptr_HeroData.MAX_POWER;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.MAX_POWER), DisplayName = nameof(ptr_HeroData.MAX_POWER), ContentValue = maxPower.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var e = ptr_HeroData.EXTERNAL_INJURY;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.EXTERNAL_INJURY), DisplayName = nameof(ptr_HeroData.EXTERNAL_INJURY), ContentValue = e.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };


            var i = ptr_HeroData.INTERNAL_INJURY;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.INTERNAL_INJURY), DisplayName = nameof(ptr_HeroData.INTERNAL_INJURY), ContentValue = i.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var p = ptr_HeroData.POISON_INJURY;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.POISON_INJURY), DisplayName = nameof(ptr_HeroData.POISON_INJURY), ContentValue = p.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var t = ptr_HeroData.HERO_TAG_POINT;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.HERO_TAG_POINT), DisplayName = nameof(ptr_HeroData.HERO_TAG_POINT), ContentValue = t.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var f = ptr_HeroData.FAME;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.FAME), DisplayName = nameof(ptr_HeroData.FAME), ContentValue = f.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };

            var bf = ptr_HeroData.BAD_FAME;
            yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.BAD_FAME), DisplayName = nameof(ptr_HeroData.BAD_FAME), ContentValue = bf.ToString(), UIType = (int)EnumGameSwitchUIType.TextEditor };


            var tags = ptr_HeroData.HERO_TAG_DATA.AsReadOnlySpan().ToArray();
            foreach (var tag in this.ReourceCache.Character_Tag)
            {
                var had = tags.FirstOrDefault(p => p.DATA_BASE() == tag.ObjectPointer);

                var had2 = tags.FirstOrDefault(p => this.ReourceCache.Character_Tag.ElementAtOrDefault(p.TAG_ID) is not null);

                if (had)
                {
                    this.Logger.LogInformation("{id},{time},{source}", had.TAG_ID, had.LEFT_TIME, had.SOURCE_HERO);
                }


                yield return new GameSwitchDisplayDTO() { ObjectId = nameof(ptr_HeroData.HERO_TAG_DATA), DisplayName = tag.DisplayName, SwitchValue = had, UIType = (int)EnumGameSwitchUIType.Switches };

            }
        }
        public GameCharacterStatusDTO GetGameCharacterStatus(GameCharacterObjectDTO characterObjectDTO)
        {
            if (!Enum.TryParse<EnumHeroType>(characterObjectDTO.CharacterCategory, out var heroType))
            {
                return GameException.Throw<GameCharacterStatusDTO>("NOT FOUND");
            }
            if (heroType == EnumHeroType.A_Player)
            {
                var player = this.Ptr_WorldData.PLAYER();
                return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. GetCharacterStatusImp(player)] };
            }
            else if (TryGetHero(characterObjectDTO, out var ptr_HeroData))
            {
                return new GameCharacterStatusDTO() { ObjectId = characterObjectDTO.CharacterId, CharacterAttributes = [.. GetCharacterStatusImp(ptr_HeroData)] };
            }

            return GameException.Throw<GameCharacterStatusDTO>("NOT FOUND");

        }
        bool TryGetHero(GameCharacterObjectDTO characterObjectDTO, out HeroData.Ptr_HeroData ptr_HeroData)
        {
            Unsafe.SkipInit(out ptr_HeroData);
            var id = characterObjectDTO.UCharacterId;
            foreach (var hero in this.Ptr_WorldData.HEROS.AsReadOnlySpan())
            {
                ulong hero_id = (ulong)hero.HERO_ID;
                if (hero_id == id)
                {
                    ptr_HeroData = hero;
                    return true;
                }
            }
            return false;
        }

        //public IEnumerable<GameSkillInfoDTO> GetGameCharacterSkillImp(HeroData.Ptr_HeroData ptr_HeroData)
        //{ 
        
        //}

    }

    public enum EnumHeroType
    {
        A_Player,
        B_Friend,
        C_Enemy,
        D_NPC
    }
}
