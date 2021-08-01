namespace NTwewyDb
{
    public class Skill
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public ushort PointsRequired { get; set; }
        public float[] Parameters { get; set; }
        public int ShopReward { get; set; }
        public string DialogImage { get; set; }
        public int SaveIndex { get; set; }

        public Skill(ushort id, string name, string info, ushort pointsRequired, float[] parameters, int shopReward, string dialogImage, int saveIndex)
        {
            Id = id;
            Name = name;
            Info = info;
            PointsRequired = pointsRequired;
            Parameters = parameters;
            ShopReward = shopReward;
            DialogImage = dialogImage;
            SaveIndex = saveIndex;
        }
    }
}
