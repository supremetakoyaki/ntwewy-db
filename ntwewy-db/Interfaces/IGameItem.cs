namespace NTwewyDb
{
    public interface IGameItem
    {
        ushort GlobalId { get; set; }
        ushort ParticularId { get; set; }
        ItemType Type { get; set; }
        string Name { get; set; }
        string Info { get; set; }
        string Sprite { get; set; }
        byte Brand { get; set; }
        int CollectionSaveIndex { get; set; }
    }
}
