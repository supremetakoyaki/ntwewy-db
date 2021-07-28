namespace NTwewyDb
{
    public class ClothingItem : IGameItem
    {
        public ushort GlobalId { get; set; }
        public ushort ParticularId { get; set; }
        public ItemType Type { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Sprite { get; set; }
        public byte Brand { get; set; }
        public int CollectionSaveIndex { get; set; }

        public byte SlotType { get; set; }
        public ushort AbilityId { get; set; }
        public ushort StyleReq { get; set; }
        public ushort HpBoost { get; set; }
        public ushort AtkBoost { get; set; }
        public ushort DefBoost { get; set; }

        public ClothingItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, byte slotType, ushort abilityId, ushort styleReq, ushort hpBoost, ushort atkBoost, ushort defBoost)
        {
            GlobalId = globalId;
            ParticularId = particularId;
            Type = type;
            Name = name;
            Info = info;
            Sprite = sprite;
            Brand = brand;
            CollectionSaveIndex = collectionSaveIndex;
            SlotType = slotType;
            AbilityId = abilityId;
            StyleReq = styleReq;
            HpBoost = hpBoost;
            AtkBoost = atkBoost;
            DefBoost = defBoost;
        }
    }
}