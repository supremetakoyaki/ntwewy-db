namespace NTwewyDb
{
    public class BookItem : IGameItem
    {
        public ushort GlobalId { get; set; }
        public ushort ParticularId { get; set; }
        public ItemType Type { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Sprite { get; set; }
        public byte Brand { get; set; }
        public int CollectionSaveIndex { get; set; }

        public short Tips { get; set; }
        public string[] Text { get; set; }
        public sbyte SecretId { get; set; }

        public BookItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, short tips, string[] text, sbyte secretId)
        {
            GlobalId = globalId;
            ParticularId = particularId;
            Type = type;
            Name = name;
            Info = info;
            Sprite = sprite;
            Brand = brand;
            CollectionSaveIndex = collectionSaveIndex;
            Tips = tips;
            Text = text;
            SecretId = secretId;
        }
    }
}
