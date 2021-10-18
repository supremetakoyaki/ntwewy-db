namespace NTwewyDb
{
    public class EventData
    {
        public uint Id {  get; set; }
        public uint EventId { get; set; }
        public int SaveIndex { get; set; }

        public EventData(uint id, uint eventId, int saveIndex)
        {
            Id = id;
            EventId = eventId;
            SaveIndex = saveIndex;
        }

        public EventName Name
        {
            get
            {
                return (EventName)EventId;
            }
        }

        public string NameStr
        {
            get
            {
                return nameof(Name);
            }
        }
    }
}
