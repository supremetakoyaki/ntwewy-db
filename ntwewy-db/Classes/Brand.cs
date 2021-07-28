namespace NTwewyDb
{
    public class Brand
    {
        public byte Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Sprite
        {
            get;
            set;
        }

        public int SaveIndex
        {
            get;
            set;
        }

        public ushort[] RankPoints
        {
            get;
            set;
        }

        public Brand(byte id, string name, string sprite, int saveIndex, ushort[] rankPoints)
        {
            Id = id;
            Name = name;
            Sprite = sprite;
            SaveIndex = saveIndex;
            RankPoints = rankPoints;
        }
    }
}
