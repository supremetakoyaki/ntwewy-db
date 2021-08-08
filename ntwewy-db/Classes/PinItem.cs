namespace NTwewyDb
{
    public class PinItem : IGameItem
    {
        public ushort GlobalId { get; set; }
        public ushort ParticularId { get; set; }

        public ItemType Type { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Sprite { get; set; }
        public byte Brand { get; set; }
        public int CollectionSaveIndex { get; set; }

        public ushort ChanceType { get; set; }
        public short Psych { get; set; }
        public sbyte InputKey { get; set; }

        public short AtkBoost { get; set; }
        public float ChargeTime { get; set; }
        public ushort ComboCount { get; set; }
        public float RebootTime { get; set; }
        public float AutoRecoverTime { get; set; }

        public byte MaxLevel { get; set; }
        public byte LevelUpType { get; set; }
        public float LevelUpRate { get; set; }

        public ushort[] Abilities { get; set; }
        public int SellPrice { get; set; }

        public byte PinClass { get; set; }

        public byte EvolutionLevel { get; set; }
        public short EvolutionCommon { get; set; }
        public short[] EvolutionPins { get; set; }
        public sbyte MashupElement { get; set; }

        public PinItem(ushort globalId, ushort particularId, ItemType type, string name, string info, string sprite, byte brand, int collectionSaveIndex, ushort chanceType, short psych, sbyte inputKey, short atkBoost, float chargeTime, ushort comboCount, float rebootTime, float autoRecoverTime, byte maxLevel, byte levelUpType, float levelUpRate, ushort[] abilities, int sellPrice, byte pinClass, byte evolutionLevel, short evolutionCommon, short[] evolutionPins, sbyte mashupElement)
        {
            GlobalId = globalId;
            ParticularId = particularId;
            Type = type;
            Name = name;
            Info = info;
            Sprite = sprite;
            Brand = brand;
            CollectionSaveIndex = collectionSaveIndex;
            ChanceType = chanceType;
            Psych = psych;
            InputKey = inputKey;
            AtkBoost = atkBoost;
            ChargeTime = chargeTime;
            ComboCount = comboCount;
            RebootTime = rebootTime;
            AutoRecoverTime = autoRecoverTime;
            MaxLevel = maxLevel;
            LevelUpType = levelUpType;
            LevelUpRate = levelUpRate;
            Abilities = abilities;
            SellPrice = sellPrice;
            PinClass = pinClass;
            EvolutionLevel = evolutionLevel;
            EvolutionCommon = evolutionCommon;
            EvolutionPins = evolutionPins;
            MashupElement = mashupElement;
        }
    }
}
