namespace NTwewyDb
{
    public class CDItem : IGameItem
    {
        public ushort GlobalId { get; set; }
        public ushort ParticularId { get; set; }
        public ItemType Type { get; set; }
        public string Name { get; set; }
        public string Sprite { get; set; }
        public string Info { get; set; }
        public byte Brand { get; set; }
        public int CollectionSaveIndex { get; set; }

        public ushort BgmId { get; set; }
        public string BgmName { get; set; }

        public CDItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, ushort bgmId, string bgmName)
        {
            GlobalId = globalId;
            ParticularId = particularId;
            Type = type;
            Name = name;
            Info = info;
            Sprite = sprite;
            Brand = brand;
            CollectionSaveIndex = collectionSaveIndex;
            BgmId = bgmId;
            BgmName = bgmName;
        }
    }
}
