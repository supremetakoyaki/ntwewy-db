namespace NTwewyDb
{
    public class Ability
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public short Type { get; set; }
        public sbyte Target { get; set; }
        public sbyte CharacterRestriction { get; set; }
        public float[] Params { get; set; }
        public sbyte BrandParam { get; set; }
        public sbyte Element { get; set; }

        public Ability(ushort id, string name, string info, short type, sbyte target, sbyte characterRestriction, float[] @params, sbyte brandParam, sbyte element)
        {
            Id = id;
            Name = name;
            Info = info;
            Type = type;
            Target = target;
            CharacterRestriction = characterRestriction;
            Params = @params;
            BrandParam = brandParam;
            Element = element;
        }
    }
}
