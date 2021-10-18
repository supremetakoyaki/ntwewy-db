namespace NTwewyDb
{
    public class EventLog
    {
        public ushort Id { get; set; }
        public int SaveId { get; set; }
        public byte Chapter { get; set; }

        public EventLog(ushort id, int saveId, byte chapter)
        {
            Id = id;
            SaveId = saveId;
            Chapter = chapter;
        }

        public EventLogName Name
        {
            get
            {
                return (EventLogName)Id;
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
