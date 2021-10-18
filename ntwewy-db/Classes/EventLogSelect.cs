namespace NTwewyDb
{
    public class EventLogSelect
    {
        public byte Id { get; set; }
        public int SaveId { get; set; }

        public EventLogSelect(byte id, int saveId)
        {
            Id = id;
            SaveId = saveId;
        }

        public EventLogSelectName Name
        {
            get
            {
                return (EventLogSelectName)Id;
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
