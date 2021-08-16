namespace NTwewyDb
{
    public class TurfWar
    {
        public ushort Id { get; set; }
        public string Title { get; set; }
        public string RuleTitle { get; set; }
        public string[] Rule { get; set; }
        public string Sub { get; set; }
        public byte Rewards { get; set; }
        public ushort Noise { get; set; }
        public int Scenario { get; set; }
        public string StartDataSo { get; set; }
        public byte HideTeam { get; set; }
        public string MapOpenArea { get; set; }
        public int SaveIndex { get; set; }

        public TurfWar(ushort id, string title, string ruleTitle, string[] rule, string sub, byte rewards, ushort noise, int scenario, string startDataSo, byte hideTeam, string mapOpenArea, int saveIndex)
        {
            Id = id;
            Title = title;
            RuleTitle = ruleTitle;
            Rule = rule;
            Sub = sub;
            Rewards = rewards;
            Noise = noise;
            Scenario = scenario;
            StartDataSo = startDataSo;
            HideTeam = hideTeam;
            MapOpenArea = mapOpenArea;
            SaveIndex = saveIndex;
        }
    }
}
