namespace NTwewyDb
{
    public class Trophy
    {
        public byte Id { get; set; }
        public byte SortIndex { get; set; }
        public int Param { get; set; }
        public string TrophyTitle { get; set; }
        public string TrophySummary { get; set; }
        public string TrophyHint { get; set; }
        public string TrophyIcon { get; set; }
        public byte TrophyGrade { get; set; }

        public Trophy(byte id, byte sortIndex, int param, string trophyTitle, string trophySummary, string trophyHint, string trophyIcon, byte trophyGrade)
        {
            Id = id;
            SortIndex = sortIndex;
            Param = param;
            TrophyTitle = trophyTitle;
            TrophySummary = trophySummary;
            TrophyHint = trophyHint;
            TrophyIcon = trophyIcon;
            TrophyGrade = trophyGrade;
        }
    }
}
