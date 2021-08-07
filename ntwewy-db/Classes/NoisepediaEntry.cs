namespace NTwewyDb
{
    public class NoisepediaEntry
    {
        public byte Id { get; set; }
        public byte SortIndex { get; set; }
        public int CharacterId { get; set; }
        public int[] GroupCharacterIds { get; set; }
        public ushort NoiseId { get; set; }
        public string Icon { get; set; }
        public byte SymbolType { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public bool IsBoss { get; set; }
        public byte[] WeaknessElements { get; set; }
        public string NoiseImagePath { get; set; }

        public NoisepediaEntry(byte id, byte sortIndex, int characterId, int[] groupCharacterIds, ushort noiseId, string icon, byte symbolType, string name, string info, bool isBoss, byte[] weaknessElements, string noiseImagePath)
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