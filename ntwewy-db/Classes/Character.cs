namespace NTwewyDb
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CharacterType Type { get; set; }
        public Gender Gender { get; set; }

        public Character(int id, string name, CharacterType type, Gender gender)
        {
            Id = id;
            Name = name;
            Type = type;
            Gender = gender;
        }
    }
}
