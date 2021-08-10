namespace NTwewyDb
{
    public class Noise
    {
        public uint Id { get; set; }
        public byte Class { get; set; }
        public ushort Type { get; set; }
        public byte TypeVersion { get; set; }
        public string SoFileName { get; set; }
        public ushort ResourceData { get; set; }
        public ushort BaseParam { get; set; }
        public uint[] Attack { get; set; }
        public float[] AttackWeightEasy { get; set; }
        public float[] AttackWeightNormal { get; set; }
        public float[] AttackWeightHard { get; set; }
        public float[] AttackWeightUltimate { get; set; }
        public byte ShacHateGaugeMax { get; set; }
        public byte ShacTriggerLine { get; set; }
        public byte ShacAttackIndex { get; set; }
        public string ShacStateName { get; set; }
        public byte SightAngle { get; set; }
        public float Scale { get; set; }
        public ushort Exp { get; set; }
        public ushort Bp { get; set; }
        public float BattleTime { get; set; }
        public byte[] Param { get; set; }
        public float BlowedColRadius { get; set; }
        public int DesperateSe { get; set; }
        public int EscapeSe { get; set; }
        public int DesperateVoice { get; set; }
        public ushort[] PinDropId { get; set; }
        public float[] DropRate { get; set; }
        public byte DynamicBoneFps { get; set; }
        public byte DynamicBoneDistance { get; set; }
        public byte DiseaseSyncroUpRate { get; set; }
        public byte DiseaseDamageCutRate { get; set; }
        public byte Level { get; set; }
        public byte ResultCp { get; set; }
        public ushort Hp { get; set; }
        public ushort AttackValue { get; set; }
        public ushort Damage { get; set; }
        public byte Weight { get; set; }

        public Noise(uint id, byte _class, ushort type, byte typeVersion, string soFileName, ushort resourceData, ushort baseParam, uint[] attack, float[] attackWeightEasy, float[] attackWeightNormal, float[] attackWeightHard, float[] attackWeightUltimate, byte shacHateGaugeMax, byte shacTriggerLine, byte shacAttackIndex, string shacStateName, byte sightAngle, float scale, ushort exp, ushort bp, float battleTime, byte[] param, float blowedColRadius, int desperateSe, int escapeSe, int desperateVoice, ushort[] pinDropId, float[] dropRate, byte dynamicBoneFps, byte dynamicBoneDistance, byte diseaseSyncroUpRate, byte diseaseDamageCutRate, byte level, byte resultCp, ushort hp, ushort attackValue, ushort damage, byte weight)
        {
            Id = id;
            Class = _class;
            Type = type;
            TypeVersion = typeVersion;
            SoFileName = soFileName;
            ResourceData = resourceData;
            BaseParam = baseParam;
            Attack = attack;
            AttackWeightEasy = attackWeightEasy;
            AttackWeightNormal = attackWeightNormal;
            AttackWeightHard = attackWeightHard;
            AttackWeightUltimate = attackWeightUltimate;
            ShacHateGaugeMax = shacHateGaugeMax;
            ShacTriggerLine = shacTriggerLine;
            ShacAttackIndex = shacAttackIndex;
            ShacStateName = shacStateName;
            SightAngle = sightAngle;
            Scale = scale;
            Exp = exp;
            Bp = bp;
            BattleTime = battleTime;
            Param = param;
            BlowedColRadius = blowedColRadius;
            DesperateSe = desperateSe;
            EscapeSe = escapeSe;
            DesperateVoice = desperateVoice;
            PinDropId = pinDropId;
            DropRate = dropRate;
            DynamicBoneFps = dynamicBoneFps;
            DynamicBoneDistance = dynamicBoneDistance;
            DiseaseSyncroUpRate = diseaseSyncroUpRate;
            DiseaseDamageCutRate = diseaseDamageCutRate;
            Level = level;
            ResultCp = resultCp;
            Hp = hp;
            AttackValue = attackValue;
            Damage = damage;
            Weight = weight;
        }
    }
}
