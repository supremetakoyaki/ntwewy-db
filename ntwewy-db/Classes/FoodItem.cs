namespace NTwewyDb
{
    public class FoodItem : IGameItem
    {
        public ushort GlobalId { get; set; }
        public ushort ParticularId { get; set; }
        public ItemType Type { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Sprite { get; set; }
        public byte Brand { get; set; }
        public int CollectionSaveIndex { get; set; }

        public ushort Calories { get; set; }
        public ushort HpBoost { get; set; }
        public ushort AtkBoost { get; set; }
        public ushort DefBoost { get; set; }
        public ushort StyleBoost { get; set; }
        public byte[] CharaLikeness { get; set; }

        public FoodItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, ushort calories, ushort hpBoost, ushort atkBoost, ushort defBoost, ushort styleBoost, byte[] charaLikeness)
        {
            GlobalId = globalId;
            ParticularId = particularId;
            Type = type;
            Name = name;
            Info = info;
            Sprite = sprite;
            Brand = brand;
            CollectionSaveIndex = collectionSaveIndex;
            Calories = calories;
            HpBoost = hpBoost;
            AtkBoost = atkBoost;
            DefBoost = defBoost;
            StyleBoost = styleBoost;
            CharaLikeness = charaLikeness;
        }
    }
}
