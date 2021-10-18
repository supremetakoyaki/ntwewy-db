namespace NTwewyDb
{
    public class Event
    {
		public uint Id { get; set; }
		public int SaveIndex { get; set; }
		public ScenarioBelong Belong { get; set; }
		public byte Priority { get; set; }
		public bool ResultUpdate { get; set; }
		public bool SetData { get; set; }

        public Event(uint id, int saveIndex, ScenarioBelong belong, byte priority, bool resultUpdate, bool setData)
        {
            Id = id;
            SaveIndex = saveIndex;
            Belong = belong;
            Priority = priority;
            ResultUpdate = resultUpdate;
            SetData = setData;
        }

        public EventName Name
        {
            get
            {
                return (EventName)Id;
            }
        }

        public string NameStr
        {
            get
            {
                return nameof(Name);
            }
        }

        public string BelongStr
        {
            get
            {
                return nameof(Belong);
            }
        }
    }
}
