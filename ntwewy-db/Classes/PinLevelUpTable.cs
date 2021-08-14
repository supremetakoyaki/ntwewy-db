namespace NTwewyDb
{
    public class PinLevelUpTable
    {
        public byte Id { get; set; }
        public byte Level { get; set; }
        public uint[] Exp { get; set; }

        public PinLevelUpTable(byte id, byte level, uint[] exp)
        {
            Id = id;
            Level = level;
            Exp = exp;
        }
    }
}
