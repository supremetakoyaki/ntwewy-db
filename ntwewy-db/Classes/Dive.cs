namespace NTwewyDb
{
    public class Dive
    {
        public uint Id { get; set; }
        public int Belong { get; set; }
        public string MapEnvParam { get; set; }
        public byte EmotionalType { get; set; }
        public ushort Battle { get; set; }
        public byte DifficultyLevel { get; set; }
        public ushort TimeLimit { get; set; }
        public ushort Gold { get; set; }
        public ushort Silver { get; set; }
        public ushort Bronze { get; set; }
        public short GoldItem { get; set; }
        public short GoldFriendPoint { get; set; }
        public short SilverItem { get; set; }
        public short SilverFriendPoint { get; set; }
        public short BronzeItem { get; set; }
        public short BronzeFriendPoint { get; set; }
        public int SaveIndex { get; set; }

        public Dive(uint id, int belong, string mapEnvParam, byte emotionalType, ushort battle, byte difficultyLevel, ushort timeLimit, ushort gold, ushort silver, ushort bronze, short goldItem, short goldFriendPoint, short silverItem, short silverFriendPoint, short bronzeItem, short bronzeFriendPoint, int saveIndex)
        {
            Id = id;
            Belong = belong;
            MapEnvParam = mapEnvParam;
            EmotionalType = emotionalType;
            Battle = battle;
            DifficultyLevel = difficultyLevel;
            TimeLimit = timeLimit;
            Gold = gold;
            Silver = silver;
            Bronze = bronze;
            GoldItem = goldItem;
            GoldFriendPoint = goldFriendPoint;
            SilverItem = silverItem;
            SilverFriendPoint = silverFriendPoint;
            BronzeItem = bronzeItem;
            BronzeFriendPoint = bronzeFriendPoint;
            SaveIndex = saveIndex;
        }
    }

    public enum DiveRank
    {
        None = 0,
        Bronze = 1,
        Silver = 2,
        Gold = 3
    }
}
