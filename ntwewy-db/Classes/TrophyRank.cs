namespace NTwewyDb
{
    public class TrophyRank
    {
        public byte Id { get; set; }
        public string RankTitleIcon { get; set; }
        public byte Rate { get; set; }

        public TrophyRank(byte id, string rankTitleIcon, byte rate)
        {
            Id = id;
            RankTitleIcon = rankTitleIcon;
            Rate = rate;
        }
    }
}
