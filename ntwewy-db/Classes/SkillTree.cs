namespace NTwewyDb
{
    public class SkillTree
    {
        public short Id { get; set; }
        public string CharacterName { get; set; }
        public string[] CharacterInfo { get; set; }
        public bool InfoUpdateIfConnect { get; set; }
        public int InfoUpdateScenario { get; set; }
        public string DayText { get; set; }
        public string PlaceText { get; set; }
        public sbyte ShopId { get; set; }
        public int ReleaseValue { get; set; }
        public int Board { get; set; }
        public sbyte SkillId { get; set; }
        public string CharacterIcon { get; set; }
        public int EntryDay { get; set; }
        public int ConnectDay { get; set; }
        public short ParentId { get; set; }
        public int SaveIndex { get; set; }

        public SkillTree(short id, string characterName, string[] characterInfo, bool infoUpdateIfConnect, int infoUpdateScenario, string dayText, string placeText, sbyte shopId, int releaseValue, int board, sbyte skillId, string characterIcon, int entryDay, int connectDay, short parentId, int saveIndex)
        {
            Id = id;
            CharacterName = characterName;
            CharacterInfo = characterInfo;
            InfoUpdateIfConnect = infoUpdateIfConnect;
            InfoUpdateScenario = infoUpdateScenario;
            DayText = dayText;
            PlaceText = placeText;
            ShopId = shopId;
            ReleaseValue = releaseValue;
            Board = board;
            SkillId = skillId;
            CharacterIcon = characterIcon;
            EntryDay = entryDay;
            ConnectDay = connectDay;
            ParentId = parentId;
            SaveIndex = saveIndex;
        }
    }
}
