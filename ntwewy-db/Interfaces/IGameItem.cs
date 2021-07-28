namespace NTwewyDb
{
    public interface IGameItem
    {
        public ushort GlobalId { get; set; }
        public ushort ParticularId { get; set; }
        public ItemType Type { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Sprite { get; set; }
        public byte Brand { get; set; }
        public int CollectionSaveIndex { get; set; }
    }
}
