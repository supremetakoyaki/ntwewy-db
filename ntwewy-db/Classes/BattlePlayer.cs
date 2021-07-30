namespace NTwewyDb
{
    public class BattlePlayer
    {
        public int Id { get; set; }
        public int GlobalId { get; set; }
        public float DropRate { get; set; }
        public int BaseHp { get; set; }
        public int BaseAtk { get; set; }
        public int BaseDef { get; set; }
        public int BaseSense { get; set; }
        public byte SortOrder { get; set; }

        public BattlePlayer(int id, int globalId, float dropRate, int baseHp, int baseAtk, int baseDef, int baseSense, byte sortOrder)
        {
            Id = id;
            GlobalId = globalId;
            DropRate = dropRate;
            BaseHp = baseHp;
            BaseAtk = baseAtk;
            BaseDef = baseDef;
            BaseSense = baseSense;
            SortOrder = sortOrder;
        }
    }
}
