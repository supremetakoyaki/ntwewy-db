namespace NTwewyDb
{
    public class NoisepediaEntry
    {
        public byte Id { get; set; }
        public byte SortIndex { get; set; }
        public int CharacterId { get; set; }
        public ushort[] GroupCharacterIds { get; set; }
        public uint NoiseId { get; set; }
        public string Icon { get; set; }
        public byte SymbolType { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public bool IsBoss { get; set; }
        public sbyte[] WeaknessElements { get; set; }
        public string NoiseImagePath { get; set; }

        public NoisepediaEntry(byte id, byte sortIndex, int characterId, ushort[] groupCharacterIds, uint noiseId, string icon, byte symbolType, string name, string info, bool isBoss, sbyte[] weaknessElements, string noiseImagePath)
        {
            Id = id;
            SortIndex = sortIndex;
            CharacterId = characterId;
            GroupCharacterIds = groupCharacterIds;
            NoiseId = noiseId;
            Icon = icon;
            SymbolType = symbolType;
            Name = name;
            Info = info;
            IsBoss = isBoss;
            WeaknessElements = weaknessElements;
            NoiseImagePath = noiseImagePath;
        }
    }
}