namespace NTwewyDb
{
    public class Scenario
    {
        public uint Id { get; set; }
        public ScenarioCategory Category { get; set; }
        public ScenarioBelong[] Belong { get; set; }
        public bool Access { get; set; }
        public int SaveIndex { get; set; }

        public Scenario(uint id, ScenarioCategory category, ScenarioBelong[] belong, bool access, int saveIndex)
        {
            Id = id;
            Category = category;
            Belong = belong;
            Access = access;
            SaveIndex = saveIndex;
        }

        public ScenarioName Name
        {
            get
            {
                return (ScenarioName)Id;
            }
        }

        public string NameStr
        {
            get
            {
                return nameof(Name);
            }
        }

        public string CategoryStr
        {
            get
            {
                return nameof(Category);
            }
        }
    }
}
